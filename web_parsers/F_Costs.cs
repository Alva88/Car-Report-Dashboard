using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
namespace web_parsers
{
    public partial class F_Costs : Form
    {
        public F_Costs()
        {
            InitializeComponent();
        }

        private void F_Costs_Load(object sender, EventArgs e)
        {
           dataGrid1.DataSource = TableDataSet.Dset.Tables[0];
            //hide redunant fields; Make, Model. Year.
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
