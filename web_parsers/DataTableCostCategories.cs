using System;
using System.Data;

namespace web_parsers
{
    public static class DataTableCostCategories
    {
        public static DataTable CostsBreakdown()
        {
            DataTable dt = new DataTable("Breakdown");
            DataColumn[] columns =
            {
                new DataColumn("Make",typeof(String)),
                new DataColumn("Model",typeof(String)),
                new DataColumn("Year",typeof(String)),
                new DataColumn("Insurance",typeof(Decimal)),
                new DataColumn("Maintenance",typeof(Decimal)),
                new DataColumn("Repairs",typeof(Decimal)),
                new DataColumn("Taxesandfees",typeof(Decimal)),
                new DataColumn("Financing",typeof(Decimal)),
                new DataColumn("Depreciation",typeof(Decimal)),
                new DataColumn("Fuel",typeof(Decimal)),
            };

            dt.Columns.AddRange(columns);
            return dt;
        }

        public static DataTable CostTotal()
        {
            DataTable dt = new DataTable("Totals");
            DataColumn[] columns =
            {
                new DataColumn("Make",typeof(String)),
                new DataColumn("Model",typeof(String)),
                new DataColumn("Year",typeof(String)),
                new DataColumn("Insurance",typeof(Decimal)),
                new DataColumn("Maintenance",typeof(Decimal)),
                new DataColumn("Repairs",typeof(Decimal)),
                new DataColumn("Taxesandfees",typeof(Decimal)),
                new DataColumn("Financing",typeof(Decimal)),
                new DataColumn("Depreciation",typeof(Decimal)),
                new DataColumn("Fuel",typeof(Decimal)),
                new DataColumn("Taxcredit",typeof(Decimal)),
                //new DataColumn("Grand Total",typeof(Decimal))
        };
            //Create Grand Total column
            DataColumn Total = new DataColumn();
            Total.DataType = System.Type.GetType("System.Decimal");
            Total.ColumnName = "Grand Total";
            Total.Expression = "Insurance + Maintenance + Repairs + Taxesandfees + Financing + Depreciation + Fuel + Taxcredit";

            //Add all columns to data table.
            dt.Columns.AddRange(columns);
            dt.Columns.Add(Total);
            return dt;
        }
    }
}
