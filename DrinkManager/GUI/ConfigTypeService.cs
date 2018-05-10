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
    public partial class ConfigTypeService : UserControl
    {
        List<DTO.Service> lstService;
        public ConfigTypeService()
        {
            InitializeComponent();
            lstService = BLL.BLLType.Instance.getListService();
            LoadService();
            trvService.ExpandAll();
        }
        private void LoadService()
        {
            foreach(DTO.Service s in lstService)
            {
                trvService.Nodes["rootService"].Nodes.Add(new TreeNode(s.Typeservice));
            }
        }

        private void trvService_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (trvService.SelectedNode == null)
                return;
            else
            {
                setText(e.Node.Text);
            }

        }
        void setText(string service)
        {
            lblService.Text = service;
            foreach (DTO.Service temp in lstService)
            {
                if (temp.Typeservice.Equals(service))
                {
                    lblContent.Text = "      " + temp.Detail;
                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             setText("Quản lý");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            setText("Phục Vụ");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setText("Tạp Vụ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            setText("Thanh Toán");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setText("Kiểm Soát");
        }
    }
}
