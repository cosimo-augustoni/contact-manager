using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace contact_manager.Models.Domain.Search;

public class SearchScope
{
    internal SearchScope(ScopeType scopeType, string displayName, PropertyInfo? property = null)
    {
        this.Property = property;
        this.ScopeType = scopeType;
        this.DisplayName = displayName;
    }

    internal SearchScope(PropertyInfo property)
        : this(ScopeType.Property, property.GetCustomAttribute<DisplayAttribute>()?.Name ?? property.Name, property)
    {
    }

    public PropertyInfo? Property { get; }
    public string DisplayName { get; }
    internal ScopeType ScopeType { get; }
}
