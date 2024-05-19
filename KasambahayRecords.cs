using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class KasambahayRecords : Form
    {
        private static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public KasambahayRecords()
        {
            InitializeComponent();
            LoadRecords();
        }

        private void LoadRecords()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT `Kasambahay Name`, `Employer Name`, `Nature of Work`, Salary FROM dt", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
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

        private void button25_Click_1(object sender, EventArgs e)
        {
            SaveKasambahayRecord();
            SaveFullList();
            LoadRecords(); // Refresh DataGridView1 in this form

            if (viewFullListForm != null && !viewFullListForm.IsDisposed)
            {
                viewFullListForm.LoadFullList(); // Refresh DataGridView2 in ViewFullList form
            }
        }
        private void SaveKasambahayRecord()
        {
            using (MySqlConnection conn1 = new MySqlConnection(connection))
            {
                try
                {
                    conn1.Open();
                    MySqlCommand cmd = conn1.CreateCommand();
                    cmd.CommandText = "INSERT INTO dt (`Kasambahay Name`, `Employer Name`, `Nature of Work`, Salary) VALUES (@KasambahayName, @EmployerName, @NatureofWork, @Salary)";
                    cmd.Parameters.AddWithValue("@KasambahayName", $"{textBox2.Text} {textBox3.Text} {textBox4.Text}");
                    cmd.Parameters.AddWithValue("@EmployerName", $"{textBox23.Text} {textBox21.Text} {textBox22.Text}");
                    cmd.Parameters.AddWithValue("@NatureofWork", $"{comboBox5.Text} {textBox20.Text}");
                    cmd.Parameters.AddWithValue("@Salary", textBox25.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved in Kasambahay records");
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

        private void SaveFullList()
        {
            using (MySqlConnection conn1 = new MySqlConnection(connection))
            {
                try
                {
                    conn1.Open();
                    MySqlCommand cmd = conn1.CreateCommand();
                    cmd.CommandText = "INSERT INTO fulllist (`Kasambahay_Name`, `Age`, `Date_of_Birth`, `Sex`, `Civil_Status`, `Employers_Address`, `Home_Address`, `SSS_No`, `PAGIBIG_No`, `Philhealth_No`, " +
                                      "`Spouse`, `Spouse_Contact_Number`, `Father`, `Fathers_Address`, `Mother`, `Mothers_Address`, `Contact_Person`, `Contact_Person_Number`, `Educational_Attainment`, `School`, `Employers_Name`, " +
                                      "`Monthly_Salary`, `Nature_of_Work`, `Employment_Arrangement`) " +
                                      "VALUES (@KasambahayName, @Age, @DateOfBirth, @Sex, @CivilStatus, @EmployersAddress, @HomeAddress, @SSSNo, @PAGIBIGNo, @PhilhealthNo, " +
                                      "@Spouse, @SpouseContactNumber, @Father, @FathersAddress, @Mother, @MothersAddress, @ContactPerson, @ContactPersonNumber, @EducationalAttainment, @School, @EmployersName, " +
                                      "@MonthlySalary, @NatureOfWork, @EmploymentArrangement)";

                    cmd.Parameters.AddWithValue("@KasambahayName", $"{textBox2.Text} {textBox3.Text} {textBox4.Text}");
                    cmd.Parameters.AddWithValue("@Age", textBox6.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker2.Value.ToString("yyyy-MM-dd")); // Ensure date format is correct for MySQL
                    cmd.Parameters.AddWithValue("@Sex", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@CivilStatus", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@EmployersAddress", textBox5.Text);
                    cmd.Parameters.AddWithValue("@HomeAddress", textBox8.Text);
                    cmd.Parameters.AddWithValue("@SSSNo", textBox9.Text);
                    cmd.Parameters.AddWithValue("@PAGIBIGNo", textBox14.Text);
                    cmd.Parameters.AddWithValue("@PhilhealthNo", textBox15.Text); // Correct parameter name
                    cmd.Parameters.AddWithValue("@Spouse", textBox18.Text);
                    cmd.Parameters.AddWithValue("@SpouseContactNumber", textBox16.Text);
                    cmd.Parameters.AddWithValue("@Father", textBox17.Text);
                    cmd.Parameters.AddWithValue("@FathersAddress", textBox13.Text); // Correct parameter name
                    cmd.Parameters.AddWithValue("@Mother", textBox12.Text);
                    cmd.Parameters.AddWithValue("@MothersAddress", textBox1.Text); // Correct parameter name
                    cmd.Parameters.AddWithValue("@ContactPerson", textBox24.Text);
                    cmd.Parameters.AddWithValue("@ContactPersonNumber", textBox27.Text);
                    cmd.Parameters.AddWithValue("@EducationalAttainment", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@School", textBox19.Text);
                    cmd.Parameters.AddWithValue("@EmployersName", $"{textBox23.Text} {textBox21.Text} {textBox22.Text}");
                    cmd.Parameters.AddWithValue("@MonthlySalary", textBox25.Text);
                    cmd.Parameters.AddWithValue("@NatureOfWork", $"{comboBox5.Text} {textBox20.Text}");
                    cmd.Parameters.AddWithValue("@EmploymentArrangement", comboBox4.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Full list saved");

                    // Clear inputs if necessary
                    ClearInputs();

                    // Refresh the DataGridView in the current form
                    LoadRecords();

                    // Refresh the DataGridView in the ViewFullList form
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is ViewFullList viewFullListForm)
                        {
                            viewFullListForm.LoadFullList();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn1.Close();
                }
            }
        }

        private void ClearInputs()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            dateTimePicker2.Value = DateTime.Today;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox5.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox18.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox1.Text = "";
            textBox24.Text = "";
            textBox27.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox19.Text = "";
            comboBox4.SelectedIndex = -1;
            textBox25.Text = "";
            comboBox5.SelectedIndex = -1;
            textBox20.Text = "";
            textBox23.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnew AN = new addnew();
            AN.Show();
        }

        
           private ViewFullList viewFullListForm;

        private void button2_Click(object sender, EventArgs e)
        {
            if (viewFullListForm == null || viewFullListForm.IsDisposed)
            {
                viewFullListForm = new ViewFullList();
            }
            viewFullListForm.Show();
            viewFullListForm.LoadFullList(); // Ensure the list is refreshed
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Implement search/filter logic here if needed
        }
    }
}
