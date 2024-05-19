using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();

        }
        public static string name, position;
        private void LOGIN()
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT Name,Position,Username, Password FROM loginform WHERE Username = @username and Password = @password";
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.CommandTimeout = 3600;

                        using (MySqlDataReader uf = cmd.ExecuteReader())
                        {
                            for (int i = 0; i < 5; i++)  // Replace 5 with the desired number of iterations
                            {
                                // Your loop logic here
                            }

                            if (uf.Read())
                            {
                                xMAIN m = new xMAIN();
                                this.Hide();
                                m.Show();
                                m.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login. Please check username and password.");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An error occurred during login. Please contact support.\n\nError Details: " + ex.Message);
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred during login. Please contact support.\n\nError Details: " + ex.Message);
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LOGIN();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           // panel1.BackColor = Color.FromArgb(255, 147, 65);
        
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            username.Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, username.Width, username.Height, 2, 2));
            password.Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, password.Width, password.Height, 2, 2));
            //  pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);''

            panel2.BackColor = Color.FromArgb(40, panel2.BackColor);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           // panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(121, 52, 0);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LOGIN();
        }
    }
}
