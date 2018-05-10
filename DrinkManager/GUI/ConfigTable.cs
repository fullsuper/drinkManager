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
    public partial class ConfigTable : UserControl
    {
        List<DTO.Table> lstTable;
        public ConfigTable()
        {
            InitializeComponent();
            showTable();
        }

        private void showTable()
        {
            flpScreen.Controls.Clear();
            lstTable = BLL.BLLTable.Instance.getListTable();       
            foreach(DTO.Table temp in lstTable)
            {
                ButtonImage1 bi = new ButtonImage1() { TextButton = temp.Id + "", ImageIcon = (Image)(Properties.Resources.table) };
                bi.Click += Bi_Click;
                flpScreen.Controls.Add(bi);
            }
        }

        private void Bi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16((sender as ButtonImage1).TextButton);
            DTO.Table tbshow =null;
            foreach(DTO.Table tb in lstTable)
            {
                if(tb.Id == id)
                {
                    tbshow = tb;
                    break;
                }
            }
            MessageBox.Show("Table      No." +tbshow.Id +"\nFloor      : " +tbshow.Floor +"\nPosition : "+tbshow.Position,"Infomation Table",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            NewTable nt = new NewTable();
            nt.Disposed += Nt_Disposed;
            nt.Show();
        }

        private void Nt_Disposed(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
