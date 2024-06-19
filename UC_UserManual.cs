using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UC_UserManual : UserControl
    {
        public UC_UserManual()
        {
            InitializeComponent();
            ShowBonus();
        }

        private readonly SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;");

        private void Clear()
        {
            BNameTb.Text = "";
            BAmountTb.Text = "";
            Key = 0;
        }

        private void ShowBonus()
        {
            Con.Open();
            string query = "Select * from BonusTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            BonusDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BNameTb.Text) || string.IsNullOrEmpty(BAmountTb.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO BonusTb1(BName,BAmt) VALUES (@BN, @BA)", con))
                    {
                        cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                        cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bonus Saved");
                        ShowBonus();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private int Key = 0;

        private void BonusDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BonusDVG.Rows[e.RowIndex];
                BNameTb.Text = row.Cells[1].Value.ToString();
                BAmountTb.Text = row.Cells[2].Value.ToString();
                Key = BNameTb.Text == "" ? 0 : Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BNameTb.Text) || string.IsNullOrEmpty(BAmountTb.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Update BonusTb1 Set BName=@BN, BAmt=@BA where BId=@BKey", con))
                    {
                        cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                        cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                        cmd.Parameters.AddWithValue("@BKey", Key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bonus Updated");
                        ShowBonus();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Bonus");
            }
            else
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=LOQ_GAMING;Initial Catalog=Esoft;Integrated Security=True;"))
                    {
                        Con.Open();
                        using (SqlCommand Cmd = new SqlCommand("Delete from BonusTb1 Where BId=@BKey", Con))
                        {
                            Cmd.Parameters.AddWithValue("@BKey", Key);

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Bonus Deleted");
                            Con.Close();
                            ShowBonus();
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
