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
    public partial class ButtonImage1 : UserControl
    {
        public ButtonImage1()
        {
            InitializeComponent();
        }

        public Image ImageIcon
        {
            get { return ptbIcon.BackgroundImage; }
            set { ptbIcon.BackgroundImage = value; }
        }
        public string TextButton
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        private void ButtonImage1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(95, 149, 198);
        }

        private void ButtonImage1_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(16, 100, 178);
        }

        private void ButtonImage1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(192, 192, 255);
        }

        private void ButtonImage1_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(192, 192, 255);
        }

        private void ptbIcon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
