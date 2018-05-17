using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkManager.Report
{
    public partial class Bill : Form
    {
        private int bill;
        public Bill(int bid)
        {
            InitializeComponent();
            bill = bid;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSQLTS.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dSQLTS.DataTable2,bill);
            this.reportViewer1.RefreshReport();
        }
    }
}
