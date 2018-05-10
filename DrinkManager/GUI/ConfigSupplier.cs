using System;
using System.Windows.Forms;

namespace DrinkManager.GUI
{
    public partial class ConfigSupplier : UserControl
    {
        public ConfigSupplier()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            dgvSupplier.DataSource = BLL.BLLSupplier.Instance.getSupplierEmployee().Tables[0];
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = dgvSupplier.CurrentCell.RowIndex;
            DataGridViewCellCollection c = dgvSupplier.Rows[indexSelected].Cells;
            txtID.Text = c[0].Value.ToString();
            txtName.Text = c[1].Value.ToString();
            txtAddress.Text = c[2].Value.ToString();
            txtPhone.Text = c[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rl = MessageBox.Show("Chắc Chắn Xóa NCC Này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rl == DialogResult.Yes)
                       BLL.BLLSupplier.Instance.deleteSupplier(Convert.ToInt16(txtID.Text));
                LoadDGV();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy đối tượng xóa!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Button a = (sender as Button);
            if (a.Text.Equals("Save"))
            {
                try
                {
                    BLL.BLLSupplier.Instance.insertSupplier(new DTO.Supplier(txtName.Text,txtAddress.Text,Convert.ToInt64(txtPhone.Text)));
                    LoadDGV();
                    a.Text = "New";
                    setEnable(false);
                }
                catch { MessageBox.Show("Xin Điền đúng thông tin!", "Nhắc nhở"); }
            }
            else
            if (a.Text.Equals("New"))
            {
                resetTextbox();
                txtID.ResetText();
                setEnable(true);
                a.Enabled = true;
                a.Text = "Save";
            }
        }
        private void resetTextbox()
        {
            txtAddress.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();
        }
        private void setEnable(bool flag)
        {
            txtPhone.Enabled = flag;
            txtName.Enabled = flag;
            txtAddress.Enabled = flag;
            btnCustom.Enabled = !flag;
            btnNew.Enabled = !flag;
            btnDelete.Enabled = !flag;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            Button a = (sender as Button);
            if (a.Text.Equals("Save"))
            {
                try
                {
                    BLL.BLLSupplier.Instance.customSupplier(new DTO.Supplier(Convert.ToInt16(txtID.Text),txtName.Text, txtAddress.Text, Convert.ToInt64(txtPhone.Text)));
                    LoadDGV();
                    a.Text = "Custom";
                    setEnable(false);
                }
                catch { MessageBox.Show("Xin Điền đúng thông tin!", "Nhắc nhở"); }
            }
            else
            if (a.Text.Equals("Custom"))
            {
                setEnable(true);
                a.Enabled = true;
                a.Text = "Save";
            }
        }
    }
}
