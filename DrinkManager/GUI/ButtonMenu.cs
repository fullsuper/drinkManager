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
    public partial class ButtonMenu : UserControl
    {
        public ButtonMenu()
        {
            InitializeComponent();
        }
        public string TextButton
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        public Image IconImage
        {
            get { return ptbImage.BackgroundImage; }
            set { ptbImage.BackgroundImage = value; }
        }


        private void ptbImage_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void ButtonMenu_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(81, 74, 114);
        }

        private void ButtonMenu_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44,40,62);
        }

        private void ButtonMenu_MouseDown(object sender, MouseEventArgs e)
        {
                this.BackColor = Color.FromArgb(34, 28, 61);
            
        }

        private void ButtonMenu_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 40, 62);
        }
    }
}
