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
    public partial class kasambahaypop_up : Form
    {
        public kasambahaypop_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xMAIN addnew = new xMAIN();
            addnew.Show();
        }
    }
}
