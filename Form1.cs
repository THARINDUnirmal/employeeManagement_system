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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string userName = guna2TextBox1.Text;
            string pass = guna2TextBox2.Text;

            if (userName=="" || pass=="")
            {
                MessageBox.Show("Missing Information");   
            }
            else if(userName == "admin" || pass == "1234")
            {
                MessageBox.Show("LOGIN SUCCSESS....");
                mainMenu obj = new mainMenu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Nmae or Password");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
        }
    }
}


