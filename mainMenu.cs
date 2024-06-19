using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            
            si.SetShadowForm(this);
        }

        private void guna2TileButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2TileButton1.Checked) uC_MyPage1.BringToFront();
        }

        private void guna2TileButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2TileButton2.Checked) uC_Dashboard1.BringToFront();
        }

        private void guna2TileButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2TileButton3.Checked) uC_UserManual1.BringToFront();
        }

        private void guna2TileButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2TileButton4.Checked) uC_DevInfo1.BringToFront();
        }
        


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2TileButton7_Click(object sender, EventArgs e)
        {
            if (guna2TileButton7.Checked) feature1.BringToFront();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            if (guna2TileButton5.Checked) bonus1.BringToFront();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TileButton1.Checked) aboutUs1.BringToFront();
        }
    }
}
