using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkManager
{
    public partial class ctrlStatistic : UserControl
    {
        public ctrlStatistic()
        {
            InitializeComponent();
            LoadDGVCustomer();
            LoadDGVImporting();
        }
        private void LoadDGVCustomer()
        {
            dgvFriendlyCustomer.DataSource = BLL.BLLStatistic.Instance.getFriendlyCustomerTable();
        }
        private void LoadDGVImporting()
        {
            dgvImportGood.DataSource = BLL.BLLStatistic.Instance.getImportGood();
        }
        private void btnFilt_Click(object sender, EventArgs e)
        {
            dgvFriendlyCustomer.DataSource = BLL.BLLStatistic.Instance.getFriendlyCustomerByTime(Convert.ToInt16(nudMonth.Value), Convert.ToInt16(nudYear.Value));
            lblSum.Text = BLL.BLLStatistic.Instance.monthlyIncome(Convert.ToInt16(nudMonth.Value), Convert.ToInt16(nudYear.Value)) +"";
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlStatisticCustomer.Show();
            pnlProductImport.Hide();
        }

        private void statisticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlProductImport.Show();
            pnlStatisticCustomer.Hide();
        }

        private void btnRefiltImport_Click(object sender, EventArgs e)
        {
            dgvImportGood.DataSource = BLL.BLLStatistic.Instance.getImportGoodByTime(Convert.ToInt16(nudMonthImport.Value), Convert.ToInt16(nudYearImport.Value));
        }
    }
}
