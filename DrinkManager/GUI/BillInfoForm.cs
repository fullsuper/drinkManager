using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkManager.DTO;

namespace DrinkManager.GUI
{
    public partial class BillInfoForm : Form
    {
        List<DTO.DetailBill> lstDB;
        public BillInfoForm()
        {
            InitializeComponent();
            btnPrintBill.Dispose();
        }
        public BillInfoForm(int bid)
        {
            InitializeComponent();
            LoadBill(bid);
            LoadDetailItemBill(bid);
            btnPrintBill.Dispose();
        }
        public BillInfoForm(List<DTO.DetailBill> lstDB, String Customer, String Staff, int table, DateTime date)
        {
            //create temp bill
            InitializeComponent();
            this.lstDB = lstDB;
            lblCashier.Text = Staff;
            lblCustomer.Text = Customer;
            lblDate.Text = date + "";
            lblTable.Text = table + "";
            foreach (DetailBill db in lstDB)
            {
                ListViewItem lvi = new ListViewItem(db.Item);
                lvi.SubItems.Add(db.Amount + "");
                lvi.SubItems.Add(db.Price + "");
                lsvItemBill.Items.Add(lvi);
            }
            lblTotalPrice.Text = SumValue(lstDB) + "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BillInfoForm_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadBill(int bid)
        {
            DTO.Bill bill = BLL.BLLBill.Instance.getBill(bid);
            lblCashier.Text = bill.Cashier;
            lblCustomer.Text = bill.CustomerName;
            lblDate.Text = bill.Purchasedate +"";
            lblTotalPrice.Text = bill.Price + "";
            lblID.Text = bill.Id +"";
            lblTable.Text = bill.Table +"";

        }
        private void LoadDetailItemBill(int bid)
        {
            lstDB = BLL.BLLBill.Instance.getListItemInBill(bid);
            foreach(DetailBill db in lstDB)
            {
                ListViewItem lvi = new ListViewItem(db.Item);
                lvi.SubItems.Add(db.Amount+"");
                lvi.SubItems.Add(db.Price+ "");
                lsvItemBill.Items.Add(lvi);
            }
        }
        private long SumValue(List<DetailBill> lstDB)
        {
            long sumValue = 0;
            foreach(DetailBill db in lstDB)
            {
                sumValue += db.Price * db.Amount;
            }
            return sumValue;
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            // Đoạn này làm thao tác bán hàng

            // tạo bill : cus,staff,table,date => (lấy bid - > lấy last bid)
            BLL.BLLPurchase.Instance.insertBill(new Bill(lblCustomer.Text,Convert.ToInt64(lblTotalPrice.Text),lblCashier.Text,Convert.ToDateTime(lblDate.Text),Convert.ToInt16(lblTable.Text)));
            int bid = BLL.BLLPurchase.Instance.getLastBillID();
            // insert detailbill => trừ amount bên item (param bid)
            foreach (DetailBill i in lstDB)
            {
                BLL.BLLPurchase.Instance.insertDetailBill(i.Item, bid, i.Amount);
                BLL.BLLPurchase.Instance.updateItems(i);
            }
                
            BLL.BLLPurchase.Instance.Done = true;

            Dispose();
        }
    }
}
