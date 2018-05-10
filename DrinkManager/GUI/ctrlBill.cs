using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkManager.GUI
{
    public partial class ctrlBill : UserControl
    {
        public ctrlBill()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            dgvBill.DataSource = BLL.BLLBill.Instance.getBillTable().Tables[0];
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = dgvBill.CurrentCell.RowIndex;
            DataGridViewCellCollection c = dgvBill.Rows[indexSelected].Cells;
            
            lblID.Text = c[0].Value.ToString();
            lblCustomer.Text = c[1].Value.ToString();
            lblPrice.Text = c[2].Value.ToString();
            lblStaff.Text = c[3].Value.ToString();
            lblDate.Text = c[4].Value.ToString();
            if (c[5].Value != null)
                lblTable.Text = c[5].Value.ToString();
        }

        private void buttonImage11_Click(object sender, EventArgs e)
        {
            int bid = Convert.ToInt16(lblID.Text);
            (new BillInfoForm(bid)).ShowDialog();
        }
    }
}
