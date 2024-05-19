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
    public partial class Kasambahayform3 : Form
    {
        public Kasambahayform3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Kasambahayform4 KSB4 = new Kasambahayform4();
            KSB4.Show();
            this.Hide();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            kasambahayform2 ksb2 = new kasambahayform2();
            ksb2.Show();
            this.Hide();

        }
    }
}
