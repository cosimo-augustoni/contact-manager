using System.ComponentModel;
using Enum = System.Enum;

namespace contact_manager.Views
{
    public class DataGridViewEnumColumn : DataGridViewTextBoxColumn
    {
        public override DataGridViewCell CellTemplate => new DataGridViewEnumCell();
    }

    public class DataGridViewEnumCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle,
            TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            if (value is Enum @enum)
            {
                return @enum.GetDisplayName();
            }

            return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context) ?? value;
        }
    }
}
