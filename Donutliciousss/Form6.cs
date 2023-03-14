using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donutliciousss
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            if (checkBox1.Checked)
            {
                f5.selected1 = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                f5.selected2 = checkBox1.Text;
            }
            if (checkBox3.Checked)
            {
                f5.selected3 = checkBox1.Text;
            }
            if (checkBox4.Checked)
            {
                f5.selected4 = checkBox1.Text;
            }
            f5.Show();
        }
    }
}
