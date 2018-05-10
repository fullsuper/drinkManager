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
    public partial class ConfigType : UserControl
    {
        UserControl controlContent = new UserControl();
        public ConfigType()
        {
            InitializeComponent();
            serviceTypeToolStripMenuItem.PerformClick();
        }

        private void itemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlContent.Dispose();
            controlContent = new ConfigTypeItem();
            panel1.Controls.Add(controlContent);
           // controlContent.Show();
        }

        private void serviceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlContent.Dispose();
            controlContent = new ConfigTypeService();
            panel1.Controls.Add(controlContent);
           // controlContent.Show();
        }
    }
}
