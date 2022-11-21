using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.User.Domain
{
    [ComplexType]
    public class Preference
    {
        [Required]
        private string PreferenceType { get; set; }

        [Required]
        private string PreferenceCategory { get; set; }

        public Preference()
        {
            PreferenceType = "";
            PreferenceCategory = "";
        }

        public Preference(string preferenceType, string preferenceCategory)
        {
            this.PreferenceType = preferenceType ?? throw new ArgumentNullException(nameof(preferenceType));
            this.PreferenceCategory = preferenceCategory ?? throw new ArgumentNullException(nameof(preferenceCategory));
        }

        public override bool Equals(object? obj)
        {
            return obj is Preference preference &&
                   PreferenceType == preference.PreferenceType &&
                   PreferenceCategory == preference.PreferenceCategory;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PreferenceType, PreferenceCategory);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
