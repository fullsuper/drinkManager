using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkManager.GUI
{
   
    public partial class ControlPanel : Form
    {
        #region curvature
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
        #endregion

        #region variable
        private UserControl ctrlMain;
        #endregion
        public ControlPanel()
        {
            ctrlMain = new UserControl();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void ptbQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            //(new Report.Form1()).Show();
        }

        private void buttonMenu1_Enter(object sender, EventArgs e)
        {

        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlStorageItem();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }

        private void btnStaffManage_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlStaff();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }

        private void btnBillStatistic_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlBill();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlConfigure();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlPurchase();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlImportGood();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ctrlMain.Dispose();
            ctrlMain = new ctrlStatistic();
            pnlMainScreen.Controls.Add(ctrlMain);
            ctrlMain.Show();
        }
    }
}
