using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.Search;

internal interface ISearchService<T> where T : Person
{
    List<SearchScope> GetSearchScopes();
    List<T> SearchBySearchTerm(SearchScope searchScope, string searchTerm);
}
