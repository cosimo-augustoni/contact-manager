using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;
using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.Search
{
    internal class SearchService<T> : ISearchService<T> where T : Person
    {
        private readonly IRepository<T> _repository;

        public SearchService(IRepository<T> repository)
        {
            this._repository = repository;
        }

        public List<SearchScope> GetSearchScopes()
        {
            var searchScopes = new List<SearchScope> { new SearchScope(ScopeType.All, "Alles") };
            var propertySearchScopes = GetAllProperties()
                .Select(p => new SearchScope(p))
                .OrderBy(s => s.DisplayName);
            return searchScopes.Union(propertySearchScopes).ToList();
        }

        public List<T> SearchBySearchTerm(SearchScope searchScope, string searchTerm)
        {
            Expression<Func<T, bool>> searchPredicate;
            if (searchScope.ScopeType == ScopeType.Property && searchScope.Property != null)
            {
                searchPredicate = this.GetSearchPredicateByProperty(searchScope.Property, searchTerm);
            }
            else
            {
                searchPredicate = this.GetSearchPredicateForAllProperties(searchTerm);
            }

            return this._repository.GetAll().AsQueryable().Where(searchPredicate).ToList();
        }

        private Expression<Func<T, bool>> GetSearchPredicateForAllProperties(string searchTerm)
        {
            Expression<Func<T, bool>> searchExpression = p => string.IsNullOrWhiteSpace(searchTerm);
            return GetAllProperties().Select(property => this.GetSearchPredicateByProperty(property, searchTerm))
                .Aggregate(searchExpression, ExpressionHelper.Or);
        }

        private Expression<Func<T, bool>> GetSearchPredicateByProperty(PropertyInfo propertyInfo, string searchTerm)
        {
            Expression<Func<T, object?>> accessFieldExpression = p => propertyInfo.GetValue(p);
            var match = GetMatchExpressionByPropertyType(propertyInfo, searchTerm);

            var parameter = Expression.Parameter(typeof(T));

            var fieldExpression = ExpressionHelper.ReplaceParameter(accessFieldExpression, parameter);
            var matchExpression = ExpressionHelper.ReplaceParameter(match, fieldExpression);

            return Expression.Lambda<Func<T, bool>>(matchExpression, parameter);
        }

        private static Expression<Func<object?, bool>> GetMatchExpressionByPropertyType(PropertyInfo propertyInfo, string searchTerm)
        {
            if(propertyInfo.PropertyType == typeof(string))
                return GetStringPredicate(searchTerm);
            if (propertyInfo.PropertyType == typeof(int) || propertyInfo.PropertyType == typeof(int?))
                return GetIntPredicate(searchTerm);
            if (propertyInfo.PropertyType == typeof(DateTime) || propertyInfo.PropertyType == typeof(DateTime?))
                return GetDateTimePredicate(searchTerm);
            if (propertyInfo.PropertyType.IsEnum)
                return GetEnumPredicate(propertyInfo, searchTerm);
            return f => string.IsNullOrWhiteSpace(searchTerm);
        }

        private static Expression<Func<object?, bool>> GetStringPredicate(string searchTerm)
        {
            return f => ((string?)f) != null ? ((string)f).Contains(searchTerm) : string.IsNullOrWhiteSpace((string?)f) && string.IsNullOrWhiteSpace(searchTerm);
        }

        private static Expression<Func<object?, bool>> GetIntPredicate(string searchTerm)
        {
            if (int.TryParse(searchTerm, out var searchTermInt))
                return f => ((int?) f) == searchTermInt;
            return f => false;
        }

        private static Expression<Func<object?, bool>> GetDateTimePredicate(string searchTerm)
        {
            if (DateTime.TryParse(searchTerm, out var searchTermDate))
                return f => ((DateTime?) f) == searchTermDate.Date;
            return f => f == null && string.IsNullOrWhiteSpace(searchTerm);
        }

        private static Expression<Func<object?, bool>> GetEnumPredicate(PropertyInfo propertyInfo, string searchTerm)
        {
            if (Enum.TryParse(propertyInfo.PropertyType, searchTerm, out var searchTermEnum))
                return f => f == searchTermEnum;

            var enumMember = propertyInfo.PropertyType.GetFields().FirstOrDefault(m => m.GetCustomAttribute<DisplayAttribute>()?.Name?.Contains(searchTerm) ?? false);
            if (enumMember != null)
                return f => enumMember.GetValue(null)!.Equals(f);

            return f => f == null && string.IsNullOrWhiteSpace(searchTerm);
        }

        private static IEnumerable<PropertyInfo> GetAllProperties()
        {
            return typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
    }
}
