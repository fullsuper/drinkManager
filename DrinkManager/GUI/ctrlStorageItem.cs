using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkManager.BLL;
using System.Runtime.InteropServices;

namespace DrinkManager.GUI
{
    public partial class ctrlStorageItem : UserControl
    {
        #region animation
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int HeightEllipse
        );
        private void ptbCancel_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as PictureBox).BackColor = Color.LightSeaGreen;
        }

        private void ptbCancel_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void ptbCancel_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void ptbCancel_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromKnownColor(KnownColor.HotTrack);
        }
        #endregion

        #region variable
        bool isAdding;
        #endregion

        public ctrlStorageItem()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            dgvItemTable.DataSource = BLLStorageItem.Instance.StorageItemTable();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgvItemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = dgvItemTable.CurrentCell.RowIndex;
            DataGridViewCellCollection c = dgvItemTable.Rows[indexSelected].Cells;
            txtID.Text = c[0].Value.ToString();       
            txtType.Text = c[1].Value.ToString();
            txtName.Text = c[2].Value.ToString();
            txtAmount.Text = c[4].Value.ToString();
            txtValue.Text = c[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtName.ResetText();
            txtType.ResetText();
            txtValue.ResetText();
            txtAmount.ResetText();
            txtName.Enabled = true;
            txtType.Enabled = true;
            txtValue.Enabled = true;
            txtAmount.Enabled = true;
            txtName.Focus();
            EnableText(true);
            isAdding = true;
        }

        private void ptbSave_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt16(txtAmount.Text);
                long price = Convert.ToInt64(txtValue.Text);
                
                if (isAdding)
                    BLLStorageItem.Instance.InsertNewItem(new DTO.Item(txtType.Text, txtName.Text, price, amount));
                else
                {
                    int id = Convert.ToInt16(txtID.Text);
                    BLLStorageItem.Instance.UpdateItem(new DTO.Item(id,txtType.Text, txtName.Text, price, amount));
                }
                LoadDGV();
                EnableText(false);
            }
            catch { MessageBox.Show("Không hợp lệ!"); }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (dgvItemTable.CurrentCell.RowIndex == -1)
                return;
            txtName.Enabled = true;
            txtType.Enabled = true;
            txtValue.Enabled = true;
            txtAmount.Enabled = true;
            isAdding = false;
            EnableText(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                return;
            DialogResult result = MessageBox.Show("Chắc chắn xóa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            BLLStorageItem.Instance.DeleteItem(Convert.ToInt16(txtID.Text));
            LoadDGV();
        }
        private void EnableText(bool flag)
        {
            txtName.Enabled = txtType.Enabled = txtValue.Enabled = txtAmount.Enabled = flag;
        }

        private void ptbCancel_Click(object sender, EventArgs e)
        {
            EnableText(false);
        }
    }
}
