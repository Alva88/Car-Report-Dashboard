using System.Collections.Generic;
using System.Linq;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace web_parsers
{
    public static class PreProcessor
    {
        public static void MemoryDisposal()
        {
            //disposing stored costs
            if (CostCategoriesTotals.Values != null)
            {
                CostCategoriesTotals.Values.Dispose();
            }
            if (CostCategoriesBreakdowns.Values != null)
            {
                CostCategoriesBreakdowns.Values.Dispose();
            }
            //closing opened datagridviews
            if (Application.OpenForms.OfType<F_Costs>().Count() == 1)
                Application.OpenForms.OfType<F_Costs>().First().Close();
        }

        public static void ProcessData(string GridData, string State, string ZipCode)
        {
            //Free up memory from previously ran queries.
            MemoryDisposal();
            //create data tables
            DataTable dtCostBreakdown = DataTableCostCategories.CostsBreakdown();
            DataTable dtCostTotals = DataTableCostCategories.CostTotal();

            //Split grid data by @
            string[] lines = GridData.Split('@');
            foreach (string row in lines)
            {
                //seperate columns by delimiters
                string[] ln = row.Split('$');
                //get style in order to get the cost elements.

                string Style = DataLayer.GetStyle(ln[0], ln[1], ln[2]);

                if (Style != null)
                {
                    //Loading costs for selection, hard coding zip code and state for now.
                    JObject Costs = DataLayer.GetCosts(ln[0], ln[1], ln[2], Style, State, ZipCode);
                    if (Costs != null)
                    {
                        //insurance amounts.
                        IEnumerable<JToken> Insurance = Costs.SelectTokens("$.insurance.values");
                        string filter = "$.insurance.total";
                        float insuranceTotal = (float)Costs.SelectToken(filter);

                        //maintenance amounts
                        IEnumerable<JToken> Maintenance = Costs.SelectTokens("$.maintenance.values");
                        filter = "$.maintenance.total";
                        float maintenanceTotal = (float)Costs.SelectToken(filter);

                        //repairs amount
                        IEnumerable<JToken> Repairs = Costs.SelectTokens("$.repairs.values");
                        filter = "$.repairs.total";
                        float repairsTotal = (float)Costs.SelectToken(filter);

                        //tax and fees amount
                        IEnumerable<JToken> Taxandfees = Costs.SelectTokens("$.taxandfees.values");
                        filter = "$.taxandfees.total";
                        float taxandfeesTotal = (float)Costs.SelectToken(filter);

                        //financing amount
                        IEnumerable<JToken> Financing = Costs.SelectTokens("$.financing.values");
                        filter = "$.financing.total";
                        float financingTotal = (float)Costs.SelectToken(filter);

                        //depreciation amount
                        IEnumerable<JToken> Depreciation = Costs.SelectTokens("$.depreciation.values");
                        filter = "$.depreciation.total";
                        float depreciationTotal = (float)Costs.SelectToken(filter);

                        //fuel amount
                        IEnumerable<JToken> Fuel = Costs.SelectTokens("$.fuel.values");
                        filter = "$.fuel.total";
                        float fuelTotal = (float)Costs.SelectToken(filter);

                        //taxcredit amount
                        filter = "$.taxcredit";
                        float taxcreditTotal = (float)Costs.SelectToken(filter);
                        //calculate total costs for car.
                        //add row to totals data table
                        DataRow rw = dtCostTotals.NewRow();
                        rw["Make"] = ln[0];
                        rw["Model"] = ln[1];
                        rw["Year"] = ln[2];
                        rw["Insurance"] = insuranceTotal;
                        rw["Maintenance"] = maintenanceTotal;
                        rw["Repairs"] = repairsTotal;
                        rw["Taxesandfees"] = taxandfeesTotal;
                        rw["Financing"] = financingTotal;
                        rw["Depreciation"] = depreciationTotal;
                        rw["Fuel"] = fuelTotal;
                        rw["Taxcredit"] = taxcreditTotal;
                        dtCostTotals.Rows.Add(rw);

                        int x = dtCostBreakdown.Rows.Count;
                        int y = 5;
                        if (x > 0)
                        {
                            x = x++;
                            y = x + 5;
                        }
                        //add cost break down records to data table
                        for (int i = x; i < y; i++)
                        {
                            DataRow rw2 = dtCostBreakdown.NewRow();
                            rw2["Make"] = ln[0];
                            dtCostBreakdown.Rows.Add(rw2);
                        }
                        for (int i = x; i < y; i++)
                        {
                            dtCostBreakdown.Rows[i]["Model"] = ln[1];
                        }
                        for (int i = x; i < y; i++)
                        {
                            dtCostBreakdown.Rows[i]["Year"] = ln[2];
                        }

                        foreach (JToken item in Insurance)
                        {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                            {
                                idx++;
                                dtCostBreakdown.Rows[i]["Insurance"] = item[idx];
                            }
                        }
                       
                       //Insert in row since it already exists
                       foreach (JToken item in Maintenance)
                       {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                           {
                                idx++;
                                dtCostBreakdown.Rows[i]["Maintenance"] = item[idx];
                           }
                       }
                       foreach (JToken item in Repairs)
                       {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                           {
                                idx++;
                                dtCostBreakdown.Rows[i]["Repairs"] = item[idx];
                           }
                       }
                       foreach (JToken item in Taxandfees)
                       {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                           {
                                idx++;
                                dtCostBreakdown.Rows[i]["Taxesandfees"] = item[idx];
                           }
                       }
                       foreach (JToken item in Financing)
                       {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                           {
                                idx++;
                                dtCostBreakdown.Rows[i]["Financing"] = item[idx];
                           }
                       }
                       foreach (JToken item in Depreciation)
                       {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                           {
                                idx++;
                                dtCostBreakdown.Rows[i]["Depreciation"] = item[idx];
                           }
                       }
                       foreach (JToken item in Fuel)
                       {
                            int idx = -1;
                            for (int i = x; i < y; i++)
                           {
                                idx++;
                                dtCostBreakdown.Rows[i]["Fuel"] = item[idx];
                           }
                       }
                    }
                }
            }
            //Load dataset to grid
            if (dtCostTotals.Rows.Count > 0)
            {
                //Create dataset and build relationship
                //between totals and breakdown datatables


                DataSet dsDataSet = new DataSet();
                dsDataSet.Tables.Add(dtCostTotals);
                dsDataSet.Tables.Add(dtCostBreakdown);
                dsDataSet.Relations.Add(new DataRelation("Cost Break Down", new DataColumn[] { dtCostTotals.Columns["Make"], dtCostTotals.Columns["Model"], dtCostTotals.Columns["Year"] }, new DataColumn[] { dtCostBreakdown.Columns["Make"], dtCostBreakdown.Columns["Model"], dtCostBreakdown.Columns["Year"]},false));
                dsDataSet.Relations["Cost Break Down"].Nested = true;

                CostCategoriesTotals.Values = dtCostTotals;
                CostCategoriesBreakdowns.Values = dtCostBreakdown;
                TableDataSet.Dset = dsDataSet;

                dtCostTotals.Dispose();
                dtCostBreakdown.Dispose();
                F_Costs form = new F_Costs();
                form.Show();
            }
            else
            {
                dtCostTotals.Dispose();
                dtCostBreakdown.Dispose();
            }
        }
    }
}
