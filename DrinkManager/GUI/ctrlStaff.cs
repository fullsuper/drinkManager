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
    public partial class ctrlStaff : UserControl
    {
        private bool isAdding;
        public ctrlStaff()
        {
            InitializeComponent();
            LoadDGV();
            foreach(DTO.Service s in BLL.BLLEmployee.LisService)
            {
                cbbService.Items.Add(s.Typeservice);
            }
        }

        private void LoadDGV()
        {
            dgvEmployeeTable.DataSource = BLL.BLLEmployee.Instance.getTableEmployee().Tables[0];
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void setEnable(bool flag)
        {
            dtpHireDate.Enabled = flag;
            cbbService.Enabled = flag;
            txtName.Enabled = flag;
            txtSalary.Enabled = flag;
            txtPhoneNumber.Enabled = flag;
            ptbSave.Enabled = flag;
            ptbCancel.Enabled = flag;
            btnAdd.Enabled = btnDelete.Enabled = btnFilt.Enabled = btnCustom.Enabled = !flag;
            ptbSave.Enabled = ptbCancel.Enabled = flag;
        }
        private void resetInfo()
        {
            txtName.ResetText();
            txtSalary.ResetText();
            txtPhoneNumber.ResetText();
            cbbService.Text = cbbService.Items[0].ToString();
            dtpHireDate.Value = DateTime.Now;
        }

        private void dgvEmployeeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = dgvEmployeeTable.CurrentCell.RowIndex;
            DataGridViewCellCollection c = dgvEmployeeTable.Rows[indexSelected].Cells;
            txtID.Text = c[0].Value.ToString();
            cbbService.Text = c[2].Value.ToString();
            txtName.Text = c[1].Value.ToString();
            dtpHireDate.Value = Convert.ToDateTime(c[3].Value);
            txtPhoneNumber.Text = c[5].Value.ToString();
            txtSalary.Text = c[4].Value.ToString();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chọn đối tượng sửa!","Nhắc nhở");
                return;
            }
            setEnable(true);
            isAdding = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEnable(true);
            txtID.ResetText();
            resetInfo();
            isAdding = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                return;
            int id = Convert.ToInt16(txtID.Text);
            DialogResult res = MessageBox.Show("Có chắc chắn sa thải?","Sa Thải",MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (res == DialogResult.Yes)
                BLL.BLLEmployee.Instance.deleteEmployee(id);
            LoadDGV();

        }

        private void btnFilt_Click(object sender, EventArgs e)
        {

        }


        private void ptbSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdding)
                    BLL.BLLEmployee.Instance.insertNewEmploy(new DTO.Employee(txtName.Text, 
                        dtpHireDate.Value, cbbService.Text, 
                        Convert.ToInt64(txtPhoneNumber.Text), 
                        Convert.ToInt64(txtSalary.Text)));
                else
                    BLL.BLLEmployee.Instance.updateEmployee(new DTO.Employee(Convert.ToUInt16(txtID.Text),
                        txtName.Text,
                        dtpHireDate.Value, cbbService.Text,
                        Convert.ToInt64(txtPhoneNumber.Text),
                        Convert.ToInt64(txtSalary.Text)));

                LoadDGV();
                setEnable(false);
            }
            catch(Exception ea) { MessageBox.Show(ea.ToString()); }
        }

        private void ptbCancel_Click(object sender, EventArgs e)
        {
            resetInfo();
            setEnable(false);
            resetInfo();


        }


    }
}
