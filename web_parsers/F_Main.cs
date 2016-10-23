using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Diagnostics;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/*
Developed by Andretti Giovanni Medina
10/22/2016
*/
namespace web_parsers
{

    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }


        private void F_Main_Load(object sender, EventArgs e)
        {
            try
            {
                //Load makes on load          
                IEnumerable<JToken> Makes = DataLayer.GetMakes();
                foreach (JToken item in Makes)
                {
                    cbMake.Items.Add(item);
                }
                //Load states
                string[] States = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
                foreach (string arr in States)
                {
                    cbState.Items.Add(arr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Unable to connect error message.
                MessageBox.Show("System's firewall may be blocking data requests" + Environment.NewLine + Environment.NewLine +
                    "Closing program", "Experiencing connection issues",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //adds row to datagridview
            if (cbMake.Text != "" && cbModel.Text != "" && cbYear.Text != "")
            {
                try
                {
                    if (dataGridView1.RowCount == 1)
                    {
                        this.dataGridView1.Rows.Add(cbMake.Text, cbModel.Text, cbYear.Text);
                        cbMake.Text = ""; cbModel.Text = ""; cbYear.Text = "";
                    }
                    else
                    {
                        bool u = false;
                        //loop through grid to make sure selection doesn't already exist
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == cbMake.Text && dataGridView1.Rows[i].Cells[1].Value.ToString() == cbModel.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == cbYear.Text)
                            {
                                u = true;
                            }
                        }
                        if (u == false)
                        {
                            this.dataGridView1.Rows.Add(cbMake.Text, cbModel.Text, cbYear.Text);
                            cbMake.Text = ""; cbModel.Text = ""; cbYear.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMake.Text != "")
            {
                try
                {
                    //Load models based on selected make.
                    IEnumerable<JToken> Models = DataLayer.GetModels(cbMake.Text);
                    cbModel.Text = "";
                    cbModel.Items.Clear();
                    foreach (JToken item in Models)
                    {
                        cbModel.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModel.Text != "")
            {
                try
                {
                    //Load years based on selected model.
                    IEnumerable<JToken> years = DataLayer.GetYearsByModel(cbMake.Text, cbModel.Text);
                    cbYear.Text = "";
                    cbYear.Items.Clear();
                    foreach (JToken item in years)
                    {
                        cbYear.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (cbState.Text != null || cbState.Text != "" || txtZip.Text != "")
            {
                //build a string with the make, model, and year then a record delimiter.
                StringBuilder sb = new StringBuilder();
                try
                {
                    //Check if file exists, if it does, delete it.
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sb.Append(row.Cells["Make"].Value.ToString() + "$" + row.Cells["Model"].Value.ToString() + "$" + row.Cells["Year"].Value.ToString() + "@");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //if grid data found, continue process.
                if (sb.ToString() != "")
                {
                    //trimming off the last uneeded record delimiter and passing result as argument to be parsed and processed.
                    PreProcessor.ProcessData(sb.ToString().Substring(0, sb.ToString().Length - 1).ToString(),cbState.Text,txtZip.Text);
                }
            }
        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) e.Handled = true;
        }
    }
}
