using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class addnew : Form
    {
        //private DataTable dt;
        //private static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public addnew()
        {
            InitializeComponent();
            //views();
        }
        //private void views()
        //{
        //    try
        //    {
        //        using (MySqlConnection connm = new MySqlConnection(connection))
        //        {
        //            connm.Open();
        //            MySqlCommand cmdm = new MySqlCommand("SELECT `NAME`, ADDRESS, `CASE NAME`, STATUS, DATE FROM addnewemployer", connm);
        //            MySqlDataReader readerm = cmdm.ExecuteReader();
        //            DataTable dtm = new DataTable();
        //            dtm.Load(readerm);
        //            dataGridView2.DataSource = dtm;
        //        }
        //        foreach (DataGridViewColumn column in dataGridView2.Columns)
        //        {
        //            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}

        //private void button25_Click(object sender, EventArgs e)
        //{
        //    using (MySqlConnection conn1 = new MySqlConnection(connection))
        //    {
        //        MySqlCommand cmd;

        //        try
        //        {
        //            conn1.Open();
        //            cmd = conn1.CreateCommand();
        //            cmd.CommandText = "INSERT INTO dt (`NAME`, ADDRESS, `CASE NAME`, STATUS, DATE) VALUES (@name, @address, @casename, @status, @date)";

        //            cmd.Parameters.AddWithValue("@name", textBox2.Text + " " + textBox3.Text + " " + textBox4.Text);
        //            cmd.Parameters.AddWithValue("@address", textBox4.Text);
        //            cmd.Parameters.AddWithValue("@casename", textBox5.Text);
        //            cmd.Parameters.AddWithValue("@status", comboBox1.Text);
        //            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);

        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Saved");

        //            ClearInputs();
        //            views();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        finally
        //        {
        //            conn1.Close();
        //        }
        //    }
        //}

        //private void ClearInputs()
        //{
        //    textBox1.Text = "";
        //    textBox2.Text = "";
        //    textBox3.Text = "";
        //    textBox4.Text = "";
        //    textBox5.Text = "";
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        textBox2.Text = row.Cells["NAME"].Value.ToString();
        //        textBox4.Text = row.Cells["ADDRESS"].Value.ToString();
        //        textBox5.Text = row.Cells["CASE NAME"].Value.ToString();
        //        textBox5.Text = row.Cells["STATUS"].Value.ToString();
        //        textBox5.Text = row.Cells["DATE"].Value.ToString();
        //    }
        //}




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xMAIN KSBPOPUP = new xMAIN();
            KSBPOPUP.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xMAIN addnew = new xMAIN();
            addnew.ShowDialog();
            this.Hide();
        }
    }
}
