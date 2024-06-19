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
    public partial class Feature : UserControl
    {
        public Feature()
        {
            InitializeComponent();
            ShowAttendance();
            GetEmployees();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;");

        private void Clear()
        {
            EmpNameTb.Text = "";
            PresenceTb.Text = "";
            AbsTb.Text = "";
            ExcusedTb.Text = ""; 
            Key = 0;
        }
        private void ShowAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendanceTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDVG.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeTb1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetEmployeeName()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb1 where EmpId=" + EmpIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
            }
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpNameTb.Text) ||
                string.IsNullOrEmpty(PresenceTb.Text) ||
                string.IsNullOrEmpty(ExcusedTb.Text) ||
                string.IsNullOrEmpty(AbsTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    using (SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                    {
                        Con.Open();
                        using (SqlCommand Cmd = new SqlCommand("INSERT INTO AttendanceTb1 (EmpId, EmpName, DayPres, DayAbs, DayExcused, Period) VALUES (@EI, @EN, @DP, @DA, @DE, @Per)", Con))
                        {
                            Cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                            Cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                            Cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                            Cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                            Cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                            Cmd.Parameters.AddWithValue("@Per", Period);
                            

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Attendance Saved");
                            Con.Close();
                            ShowAttendance();
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
        private void AttendanceDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = AttendanceDVG.SelectedRows[0].Cells[2].Value.ToString();
            EmpIdCb.SelectedItem = AttendanceDVG.SelectedRows[0].Cells[1].Value.ToString();
            PresenceTb.Text = AttendanceDVG.SelectedRows[0].Cells[3].Value.ToString();
            AbsTb.Text = AttendanceDVG.SelectedRows[0].Cells[4].Value.ToString();
            ExcusedTb.Text = AttendanceDVG.SelectedRows[0].Cells[5].Value.ToString();
            AttDate.Text = AttendanceDVG.SelectedRows[0].Cells[6].Value.ToString();


            

            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendanceDVG.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpNameTb.Text) ||
                string.IsNullOrEmpty(PresenceTb.Text) ||
                string.IsNullOrEmpty(ExcusedTb.Text) ||
                string.IsNullOrEmpty(AbsTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    using (SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                    {
                        Con.Open();
                        using (SqlCommand Cmd = new SqlCommand("Update AttendanceTb1 Set EmpId=@EI, EmpName=@EN, DayPres=@DP, DayAbs=@DA, " +
                            "DayExcused=@DE, Period=@Per where AttNum=@AttKey", Con))
                        {
                            Cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                            Cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                            Cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                            Cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                            Cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                            Cmd.Parameters.AddWithValue("@Per", Period);
                            Cmd.Parameters.AddWithValue("@AttKey", Key);


                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Attendance Updated");
                            Con.Close();
                            ShowAttendance();
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
                        using (SqlCommand Cmd = new SqlCommand("Delete from AttendanceTb1 Where AttNum=@AttKey", Con))
                        {
                            Cmd.Parameters.AddWithValue("@AttKey", Key);

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Attendance Deleted");
                            Con.Close();
                            ShowAttendance();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"An error occurred: {Ex.Message}");
                }
            }
        }
    }
}
