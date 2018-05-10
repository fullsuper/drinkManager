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
    public partial class ctrlConfigure : UserControl
    {
        UserControl uc = new UserControl();
        public ctrlConfigure()
        {
            InitializeComponent();
        }

        private void rdbTable_Click(object sender, EventArgs e)
        {
            uc.Dispose();
            uc = new ConfigTable();
            pnlConfig.Controls.Add(uc);
            uc.Show();
        }

        private void rdbSupplier_Click(object sender, EventArgs e)
        {
            uc.Dispose();
            uc = new ConfigSupplier();
            pnlConfig.Controls.Add(uc);
            uc.Show();
        }

        private void rdbType_Click(object sender, EventArgs e)
        {
            uc.Dispose();
            uc = new ConfigType();
            pnlConfig.Controls.Add(uc);
            uc.Show();
        }
    }
}
