using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class addnewcase : Form
    {
        private static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public addnewcase()
        {
            InitializeComponent();
            addnewcase();
        }
        private void addnewcase()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT `Kasambahay_Name`, `Home_Address`, ` Case_Name`, Status ,  'Date_Created' FROM kasambahayaddnewcase", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView3.DataSource = dt;

                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Savenewcase()
        {
            using (MySqlConnection conn1 = new MySqlConnection(connection))
            {
                try
                {
                    conn1.Open();
                    MySqlCommand cmd = conn1.CreateCommand();
                    cmd.CommandText = "INSERT INTO kasambahayaddnewcase (`Kasambahay_Name`,`Home_Address`, `Case_Name`, Status , 'Date_Created') VALUES (@Kasambahay_Name, @Home_Address, @Case_Name, @Status, 'Date_Created')";
                    cmd.Parameters.AddWithValue("@Kasambahay_Name", $"{textBox1.Text} {textBox2.Text} {textBox3.Text}");
                    cmd.Parameters.AddWithValue("@Home_Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Case_Name", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Status", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Date_Created", dateTimePicker1.Text);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Saved in Kasambahay records");
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn1.Close();
                }
            }
        }
        private void ClearInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        }
}
