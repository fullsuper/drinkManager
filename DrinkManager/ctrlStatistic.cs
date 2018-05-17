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
            LoadDGV();
        }
        private void LoadDGV()
        {
            dgvFriendlyCustomer.DataSource = BLL.BLLStatistic.Instance.getFriendlyCustomerTable();
        }

        private void btnFilt_Click(object sender, EventArgs e)
        {
            dgvFriendlyCustomer.DataSource = BLL.BLLStatistic.Instance.getFriendlyCustomerByTime(Convert.ToInt16(nudMonth.Value), Convert.ToInt16(nudYear.Value));
            lblSum.Text = BLL.BLLStatistic.Instance.monthlyIncome(Convert.ToInt16(nudMonth.Value), Convert.ToInt16(nudYear.Value)) +"";
        }

    }
}
