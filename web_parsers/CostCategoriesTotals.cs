using System.Data;
namespace web_parsers
{
    //creating data table for use with data grid
    public static class CostCategoriesTotals
    {
        static DataTable _values;
        public static DataTable Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
            }
        }
    }
}
