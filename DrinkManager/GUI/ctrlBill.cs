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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnlFind.Visible == false)
            pnlFind.Visible = true;
            else pnlFind.Visible = false;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!checkIlegalValue())
            {
                MessageBox.Show("Thông tin không hợp lệ!");
                return;
            }
            dgvBill.DataSource = BLL.BLLBill.Instance.findData(txtFindCustomer.Text, txtFromPrice.Text, txtToPrice.Text, txtFindStaff.Text, txtFromDate.Text, txtToDate.Text, txtTable.Text);

        }

        private bool checkIlegalValue()
        {
            if (txtFindCustomer.Text == "" && txtFindStaff.Text == "" && txtFromDate.Text == "" && txtToDate.Text == "" && txtToPrice.Text == "" && txtFromPrice.Text == "" && txtTable.Text == "")
                return false;
            try
            {
                if(txtTable.Text!="")
                     Convert.ToInt16(txtTable.Text);
                if (txtToPrice.Text != "")
                    Convert.ToInt64(txtToPrice.Text);
                if (txtFromPrice.Text != "")
                    Convert.ToInt64(txtFromPrice.Text);
                if (txtToDate.Text != "")
                    Convert.ToDateTime(txtToDate.Text);
                if (txtFromDate.Text != "")
                    Convert.ToDateTime(txtFromDate.Text);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ptbReload_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
