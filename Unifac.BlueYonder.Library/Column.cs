namespace Unifac.BlueYonder.Web.Library
{
    public class Column
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool Nullable { get; set; }

        public override bool Equals(object obj)
        {
            var column = obj as Column;
            if (column == null)
            {
                return false;
            }
            return column.Nullable == Nullable
                && column.Name == Name
                && column.DataType == DataType;
        }
    }
}