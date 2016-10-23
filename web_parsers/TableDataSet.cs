using System.Data;
namespace web_parsers
{
    //adding accessable table relatopnship
    public static class TableDataSet
    {
        static DataSet _dSet;
        public static DataSet Dset
        {
            get
            {
                return _dSet;
            }
            set
            {
                _dSet = value;
            }
        }
    }
}