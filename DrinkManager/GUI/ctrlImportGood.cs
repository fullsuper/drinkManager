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
    public partial class ctrlImportGood : UserControl
    {
        List<String> lstSup = new List<String>();
        List<String> lstCensor = new List<String>();
        public ctrlImportGood()
        {
            InitializeComponent();
            LoadDGV();
            LoadControl();
        }
        private void LoadControl()
        {
            foreach(string s in BLL.BLLImportGoods.Instance.getListCensor())
            {
                lstCensor.Add(s);
                cbbCensor.Items.Add(s);
            }
            foreach (string s in BLL.BLLImportGoods.Instance.getListSupplier())
            {
                lstSup.Add(s);
                cbbSupplier.Items.Add(s);
            }
        }
        private void LoadDGV()
        {
            dgvItem.DataSource = BLL.BLLImportGoods.Instance.getItemTable();
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = dgvItem.CurrentCell.RowIndex;
            DataGridViewCellCollection c = dgvItem.Rows[indexSelected].Cells;
            txtID.Text = c[0].Value.ToString();
            txtName.Text = c[1].Value.ToString();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                return;
            ListViewItem lvi = new ListViewItem(new string[] { txtID.Text, txtName.Text, nudAmount.Value.ToString(), nudPrice.Value.ToString() });
            lstProduct.Items.Add(lvi);
            ResetChoosen();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in lstProduct.SelectedItems)
                    lstProduct.Items.Remove(lvi);
            }  
        }

        private void ptbOK_Click(object sender, EventArgs e)
        {
            if (!CheckOK())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
                return;

            }
            // tinh tong
            long sum = SumPrice(); // du thua`
            //create new shipment
            BLL.BLLImportGoods.Instance.insertShipment(new DTO.Shipment(dtpDateTrading.Value, cbbCensor.Text, cbbSupplier.Text, rtbRating.Text));
           //Lay shid cuoi cung
            int shid = BLL.BLLImportGoods.Instance.getIDLastShipment();

            //import detail shipment and update
            foreach(ListViewItem lvi in lstProduct.Items)
            {
                DTO.DetailShipment ds = new DTO.DetailShipment(shid, Convert.ToInt16(lvi.SubItems[0].Text), Convert.ToInt16(lvi.SubItems[2].Text));
                BLL.BLLImportGoods.Instance.insertDetailShipment(ds);
                BLL.BLLImportGoods.Instance.updateItem(ds);
            }
            ResetForm();

        }
        private long SumPrice()
        {
            long sum = 0;
            foreach(ListViewItem lvi in lstProduct.Items)
            {
                sum += Convert.ToInt64(lvi.SubItems[2].Text) * Convert.ToInt64(lvi.SubItems[3].Text);
            }
            return sum;
        }
        private void ResetForm()
        {
            lstProduct.Items.Clear();
            txtID.ResetText();
            txtName.ResetText();
            nudAmount.Value = 1;
            nudPrice.Value = 500;
            rtbRating.ResetText();
            cbbCensor.SelectionStart = 0;
            cbbSupplier.SelectionStart = 0;
        }
        private void ResetChoosen()
        {
            txtID.ResetText();
            txtName.ResetText();
            nudAmount.Value = 1;
            nudPrice.Value = 500;
        }
        private bool CheckOK()
        {
            if(lstSup.Exists(x=> x.Equals(cbbSupplier.Text)) && lstCensor.Exists(x => x.Equals(cbbCensor.Text)) && lstProduct.Items.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
