using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UC_MyPage : UserControl
    {
        public UC_MyPage()
        {
            InitializeComponent();
            CountEmployees();
            CountManagers();
            SumSalary();
            SumBonus();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;");

        private void CountEmployees()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTb1", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmpLb1.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountManagers()
        {
            string Pos = "Manager";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTb1 where EmpPos='" + Pos + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ManagerLb1.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumSalary()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBalance) from SalaryTb1 ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SalaryLb1.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumBonus()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBonus) from SalaryTb1 ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BonusLb1.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void UC_MyPage_Load(object sender, EventArgs e)
        {

        }
    }
}
