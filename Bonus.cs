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
    public partial class Bonus : UserControl
    {
        public Bonus()
        {
            InitializeComponent();
            GetEmployees();
            GetAttendance();
            GetBonus();
            ShowSalary();
        }

        private readonly string connectionString = @"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;";

        private void Clear()
        {
            EmpNameTb.Text = "";
            PresTb.Text = "";
            AbsTb.Text = "";
            ExcusedTb.Text = "";
            BaseSalaryTb.Text = "";
            BonusTb.Text = "";
            AdvanceTb.Text = "";
            BalanceTb.Text = "";
        }

        private void ShowSalary()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM SalaryTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                sda.Fill(ds);
                SalaryDVG.DataSource = ds.Tables[0];
            }
        }

        private void GetEmployees()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM EmployeeTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                EmpIdCb.ValueMember = "EmpId";
                EmpIdCb.DataSource = dt;
            }
        }

        private void GetBonus()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM BonusTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BonusIdCb.ValueMember = "BName";
                BonusIdCb.DataSource = dt;
            }
        }

        private void GetAttendance()
        {
            if (EmpIdCb.SelectedValue != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM AttendanceTb1 WHERE EmpId = @EmpId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmpId", EmpIdCb.SelectedValue);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    AttNumCb.ValueMember = "AttNum";
                    AttNumCb.DataSource = dt;
                }
            }
        }

        private void GetAttendanceData()
        {
            if (AttNumCb.SelectedValue != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM AttendanceTb1 WHERE AttNum = @AttNum";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AttNum", AttNumCb.SelectedValue);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        PresTb.Text = dr["DayPres"].ToString();
                        AbsTb.Text = dr["DayAbs"].ToString();
                        ExcusedTb.Text = dr["DayExcused"].ToString();
                    }
                }
            }
        }

        private void GetEmployeeName()
        {
            if (EmpIdCb.SelectedValue != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM EmployeeTb1 WHERE EmpId = @EmpId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmpId", EmpIdCb.SelectedValue);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        EmpNameTb.Text = dr["EmpName"].ToString();
                        BaseSalaryTb.Text = dr["EmpBasSal"].ToString();
                    }
                }
            }
        }

        private void GetBonusAmt()
        {
            if (BonusIdCb.SelectedValue != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM BonusTb1 WHERE BName = @BName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@BName", BonusIdCb.SelectedValue);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        BonusTb.Text = dr["BAmt"].ToString();
                    }
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpNameTb.Text) ||
                string.IsNullOrEmpty(AbsTb.Text) ||
                string.IsNullOrEmpty(ExcusedTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string period = SalDate.Value.Month + "-" + SalDate.Value.Year;
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO SalaryTb1 (EmpId, EmpName, EmpBasSal, EmpBonus, EmpAdvance, EmpTax, EmpBalance, SalPeriod) VALUES (@EI, @EN, @EBS, @EBon, @EAd, @ETax, @EBalance, @SPer)", con))
                        {
                            cmd.Parameters.AddWithValue("@EI", EmpIdCb.SelectedValue);
                            cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                            cmd.Parameters.AddWithValue("@EBS", BaseSalaryTb.Text);
                            cmd.Parameters.AddWithValue("@EBon", BonusTb.Text);
                            cmd.Parameters.AddWithValue("@EAd", AdvanceTb.Text);
                            cmd.Parameters.AddWithValue("@ETax", ToTax);
                            cmd.Parameters.AddWithValue("@EBalance", GrdTot);
                            cmd.Parameters.AddWithValue("@SPer", period);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Salary Saved");
                            ShowSalary();
                            Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
            GetAttendance();
        }

        private void BonusIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBonusAmt();
        }

        private void AttNumCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAttendanceData();
        }

        private int DailyBase = 0, Total = 0, Pres = 0, Abs = 0, Exc = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("APEX CREATORS....", new Font("Averia",12, FontStyle.Bold),Brushes.Red,new Point(160,25));
            e.Graphics.DrawString("Employee Management System  With PayRoll System 1.0", new Font("Averia", 10, FontStyle.Bold), Brushes.Blue, new Point(70, 45));

            string SalNum = SalaryDVG.SelectedRows[0].Cells[0].Value.ToString();
              string EmpId = SalaryDVG.SelectedRows[0].Cells[1].Value.ToString();
              string EmpName = SalaryDVG.SelectedRows[0].Cells[2].Value.ToString();
              string BasSal = SalaryDVG.SelectedRows[0].Cells[3].Value.ToString();
              string Bonus = SalaryDVG.SelectedRows[0].Cells[4].Value.ToString();
            string Advance = SalaryDVG.SelectedRows[0].Cells[5].Value.ToString();
            string Tax = SalaryDVG.SelectedRows[0].Cells[6].Value.ToString();
            string Balance = SalaryDVG.SelectedRows[0].Cells[7].Value.ToString();
            string Period = SalaryDVG.SelectedRows[0].Cells[8].Value.ToString();

            e.Graphics.DrawString("Salary Number: " + SalNum, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Employee Id: " + EmpId, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("Employee Name: " + EmpName, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(250, 150));
            e.Graphics.DrawString("Base Salary: " + BasSal, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 180));
            e.Graphics.DrawString("Bonus: Rs " + Bonus, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 210));
            e.Graphics.DrawString("Advance on Salary: Rs " + Advance, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 240));
            e.Graphics.DrawString("Tax: " + Tax, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 270));
            e.Graphics.DrawString("Total: " + Balance, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("Period: " + Period, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 330));

            e.Graphics.DrawString("Power By APEX CREATORS ", new Font("Bellota", 12, FontStyle.Bold), Brushes.Crimson, new Point(150, 420));
            e.Graphics.DrawString("***************Vertion 1.0***************", new Font("Bellota", 12, FontStyle.Bold), Brushes.Crimson, new Point(100, 435));
        }

        private void SalaryDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize=new System.Drawing.Printing.PaperSize("pprm",500, 800);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private double GrdTot = 0, ToTax = 0;

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BaseSalaryTb.Text) ||
                string.IsNullOrEmpty(BonusTb.Text) ||
                string.IsNullOrEmpty(AdvanceTb.Text))
            {
                MessageBox.Show("Select the Employee");
            }
            else
            {
                Pres = Convert.ToInt32(PresTb.Text);
                Abs = Convert.ToInt32(AbsTb.Text);
                Exc = Convert.ToInt32(ExcusedTb.Text);
                DailyBase = Convert.ToInt32(BaseSalaryTb.Text) / 28;
                Total = (DailyBase * Pres) + ((DailyBase / 2) * Exc);
                double tax = Total * 0.16;
                ToTax = Total - tax;
                GrdTot = ToTax + Convert.ToInt32(BonusTb.Text);
                BalanceTb.Text = "Rs " + GrdTot;
            }
        }
    }
}
