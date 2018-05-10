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
    public partial class ctrlPurchase : UserControl
    {

        List<DTO.DetailBill> lstDetail = new List<DTO.DetailBill>();
        List<DTO.Item> lstItem;
        public ctrlPurchase()
        {
            InitializeComponent();
            setContentCombobox();
        }

        private void setContentCombobox()
        {
            List<DTO.TypeItem> lstTypeItem = BLL.BLLPurchase.Instance.getTypeItem();
            List<DTO.Employee> lstStaff = BLL.BLLPurchase.Instance.getStaff();
            List<DTO.Table> lstTable = BLL.BLLPurchase.Instance.getTableID();
            foreach (DTO.TypeItem temp in lstTypeItem)
                cbbTypeDrink.Items.Add(temp.Typeitem);
            foreach (DTO.Employee temp in lstStaff)
                cbbStaff.Items.Add(temp.Name);
            foreach (DTO.Table temp in lstTable)
                cbbTable.Items.Add(temp.Id);
        }

        private void cbbTypeDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpItems.Controls.Clear();
            String typeitem = cbbTypeDrink.Text;
            lstItem = BLL.BLLPurchase.Instance.getItemByType(typeitem);
            foreach (DTO.Item item in lstItem)
            {
                ButtonItem drink = new ButtonItem();
                drink.TextIcon = item.Nameitem;
                flpItems.Controls.Add(drink);
                drink.Click += Drink_Click;
            }
        }

        private void Drink_Click(object sender, EventArgs e)
        {
            txtItem.Text = (sender as ButtonItem).TextIcon;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DTO.Item item=null;
            foreach (DTO.Item temp in lstItem)
            {
                if (temp.Nameitem.Equals(txtItem.Text))
                {
                    item = temp;
                    break;
                }
            }
            if (item!=null)
                lstDetail.Add(new DTO.DetailBill(item.Nameitem, (int)nudAmount.Value, item.Price));
            txtItem.ResetText();
            nudAmount.Value = 1;

            cbbListItem.Items.Add(lstDetail[lstDetail.Count-1].Item);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!checkIlegal())
            {
                MessageBox.Show("Thiếu Thông tin!", "Nhắc nhở");
                return;
            }
            BillInfoForm billform = new BillInfoForm(lstDetail, txtCus.Text, cbbStaff.Text, Convert.ToInt16(cbbTable.Text), DateTime.Now);
            billform.Show();
            billform.Disposed += Billform_Disposed;
        }

        private void Billform_Disposed(object sender, EventArgs e)
        {
            if(BLL.BLLPurchase.Instance.Done)
            {
                BLL.BLLPurchase.Instance.Done = false;
                lstDetail.Clear();
                cbbListItem.Items.Clear();
                txtCus.ResetText();
                cbbStaff.ResetText();
                cbbTable.ResetText();
             }

        }

        private bool checkIlegal()
        {
            if (cbbStaff.Text.Equals("") || cbbTable.Text.Equals("") || (lstDetail.Count == 0) || txtCus.Text.Equals(""))
                return false;
            return true;
        }

        private void cbbListItem_SelectedValueChanged(object sender, EventArgs e)
        {
            String item = cbbListItem.SelectedItem.ToString();
            DialogResult rl = MessageBox.Show("Loại "+ item+" khỏi hóa đơn?","Xóa mặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rl == DialogResult.Yes)
            {
                foreach(DTO.DetailBill db in lstDetail)
                {
                    if(db.Item.Equals(item))
                    {
                        lstDetail.Remove(db);
                        cbbListItem.Items.Remove(item);
                        return;
                    }
                }
            }
        }
    }
}
