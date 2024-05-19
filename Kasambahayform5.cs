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
    public partial class Kasambahayform5 : Form
    {
        public Kasambahayform5()
        {
            InitializeComponent();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Kasambahayform4 KSB4 = new Kasambahayform4();
            KSB4.Show();
            this.Hide();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            kasambahaypop_up KSBPOPUP = new kasambahaypop_up();
            KSBPOPUP.Show();
            this.Hide();
        }
    }
}
