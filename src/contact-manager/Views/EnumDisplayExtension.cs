using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace contact_manager.Views
{
    internal static class EnumDisplayExtension
    {
        public static string GetDisplayName(this Enum @enum)
        {
            return @enum.GetType().GetMember(@enum.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.Name ?? string.Empty;
        }
    }
}
