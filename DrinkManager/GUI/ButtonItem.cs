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
    public partial class ButtonItem : UserControl
    {
        public ButtonItem()
        {
            InitializeComponent();
        }

        public string TextIcon
        {
            set { lblContent.Text = value; }
            get { return lblContent.Text; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void ButtonItem_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void ButtonItem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void ButtonItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ButtonItem_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
