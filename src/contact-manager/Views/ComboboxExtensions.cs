namespace contact_manager.Views
{
    internal static class ComboboxExtensions
    {
        public static void SetDataSource<TEnum>(this ComboBox comboBox)
            where TEnum : Enum
        {
            var salutations = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(m => new EnumMember<TEnum>(m, m.GetDisplayName())).ToList();
            comboBox.DisplayMember = nameof(EnumMember<TEnum>.Display);
            comboBox.ValueMember = nameof(EnumMember<TEnum>.Key);
            comboBox.DataSource = salutations;
        }

        private class EnumMember<TEnum>
        {
            public EnumMember(TEnum key, string display)
            {
                this.Key = key;
                this.Display = display;
            }

            public TEnum Key { get; set; }

            public string Display { get; set; }
        }
    }
}
