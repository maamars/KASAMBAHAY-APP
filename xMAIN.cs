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
    public partial class xMAIN : Form
    {
        public xMAIN()
        {
            InitializeComponent();
        }

        private void xMAIN_Load(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            Dashboard dsh = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dsh.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(dsh);
            dsh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            Dashboard dsh = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dsh.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(dsh);
            dsh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            KasambahayRecords kbr = new KasambahayRecords() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            kbr.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(kbr);
            kbr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            EmployersRecords kbr = new EmployersRecords() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            kbr.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(kbr);
            kbr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            monthlyreport kbr = new monthlyreport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            kbr.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(kbr);
            kbr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            Dashboard kbr = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            kbr.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(kbr);
            kbr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            this.Refresh();
            Calendar kbr = new Calendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            kbr.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(kbr);
            kbr.Show();
        }
    }
}
