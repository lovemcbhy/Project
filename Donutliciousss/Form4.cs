using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donutliciousss
{
    public partial class Form4 : Form
    {
        public Form4()


        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        

        }
    }
}
