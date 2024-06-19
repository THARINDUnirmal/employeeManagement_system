using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace WindowsFormsApp2
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            ShowEmployee();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;");

        private void Clear()
        {
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpSalTb.Text = "";
            EmpGenCb.SelectedIndex = 0;
            EmpPosCb.SelectedIndex = 0;
            EmpQualCb.SelectedIndex = 0;
            Key = 0;
        }
        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDVG.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpNameTb.Text) ||
                string.IsNullOrEmpty(EmpPhoneTb.Text) ||
                EmpGenCb.SelectedIndex == -1 ||
                string.IsNullOrEmpty(EmpAddTb.Text) ||
                string.IsNullOrEmpty(EmpSalTb.Text) ||
                EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                    {
                        Con.Open();
                        using (SqlCommand Cmd = new SqlCommand("INSERT INTO EmployeeTb1 (EmpName, EmpGen, EmpDOB, EmpPhone, EmpAdd, EmpPos, JoinDate, EmpQual, EmpBasSal) VALUES (@EN, @EG, @ED, @EP, @EA, @EPos, @JD, @EQ, @EBS)", Con))
                        {
                            Cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                            Cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                            Cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                            Cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                            Cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                            Cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                            Cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                            Cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                            Cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee Saved");
                            Con.Close();
                            ShowEmployee();
                            Clear();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"An error occurred: {Ex.Message}");
                }
            }
        }
        int Key = 0;
        private void EmployeeDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeDVG.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenCb.SelectedItem = EmployeeDVG.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = EmployeeDVG.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmployeeDVG.SelectedRows[0].Cells[4].Value.ToString();
            EmpAddTb.Text = EmployeeDVG.SelectedRows[0].Cells[5].Value.ToString();
            EmpPosCb.SelectedItem = EmployeeDVG.SelectedRows[0].Cells[6].Value.ToString();
            JDate.Text = EmployeeDVG.SelectedRows[0].Cells[7].Value.ToString();
            EmpQualCb.SelectedItem = EmployeeDVG.SelectedRows[0].Cells[8].Value.ToString();
            EmpSalTb.Text = EmployeeDVG.SelectedRows[0].Cells[9].Value.ToString();
            
            if(EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeDVG.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpNameTb.Text) ||
                string.IsNullOrEmpty(EmpPhoneTb.Text) ||
                EmpGenCb.SelectedIndex == -1 ||
                string.IsNullOrEmpty(EmpAddTb.Text) ||
                string.IsNullOrEmpty(EmpSalTb.Text) ||
                EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                    {
                        Con.Open();
                        using (SqlCommand Cmd = new SqlCommand("Update EmployeeTb1 Set EmpName=@EN, EmpGen=@EG, EmpDOB=@ED, EmpPhone=@EP, EmpAdd=@EA, EmpPos=@EPos, JoinDate=@JD, EmpQual=@EQ, EmpBasSal=@EBS Where EmpId=@EmpKey", Con))
                        {
                            Cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                            Cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                            Cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                            Cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                            Cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                            Cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                            Cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                            Cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                            Cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                            Cmd.Parameters.AddWithValue("@EmpKey", Key);

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee Updated");
                            Con.Close();
                            ShowEmployee();
                            Clear();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"An error occurred: {Ex.Message}");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                    {
                        Con.Open();
                        using (SqlCommand Cmd = new SqlCommand("Delete from EmployeeTb1 Where EmpId=@EmpKey", Con))
                        {
                            Cmd.Parameters.AddWithValue("@EmpKey", Key);

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee Deleted");
                            Con.Close();
                            ShowEmployee();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"An error occurred: {Ex.Message}");
                }
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            EmpNameTb.Clear();
            EmpAddTb.Clear();
            EmpSalTb.Clear();
            EmpPhoneTb.Clear();

        }
    }
}
