using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class kasambahayform2 : Form
    {
        public kasambahayform2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Kasambahayform3 ksb3 = new Kasambahayform3();
            ksb3.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
