using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Donutliciousss
{
    public partial class Form5 : Form
    {
        public string selected1 { get; set; }
        public string selected2 { get; set; }
        public string selected3 { get; set; }
        public string selected4 { get; set; }
        public string selected5 { get; set; }
        public string selected6 { get; set; }
        public string selected7 { get; set; }
        public string selected8 { get; set; }
        public string selected9 { get; set; }
        public string selected10 { get; set; }
        public string selected11 { get; set; }
        public string selected12 { get; set; }
        public string selected16 { get; set; }
        public string selected17 { get; set; }
        public string selected18 { get; set; }
        public string selected19 { get; set; }
        public string selected20 { get; set; }
        public string selected21 { get; set; }
        public string selected22 { get; set; }
        public string selected23 { get; set; }
        public string selected24 { get; set; }
        public string selected25 { get; set; }
        public string selected26 { get; set; }


        public Form5()  
       
        {
            InitializeComponent();
            
        }

        private void DONUTLICIOUS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn1_Click(object sender, EventArgs e)
        {


            if (selected1 != null)
            {
                Order.Items.Add(selected1);
            }
            if (selected2 != null)
            {
                Order.Items.Add(selected2);
            }
            if (selected3 != null)
            {
                Order.Items.Add(selected3);
            }
            if (selected4 != null)
            {
                Order.Items.Add(selected4);
            }
            if (selected5 != null)
            {
                Order.Items.Add(selected5);
            }
            if (selected6 != null)
            {
                Order.Items.Add(selected6);
            }
            if (selected7 != null)
            {
                Order.Items.Add(selected7);
            }
            if (selected8 != null)
            {
                Order.Items.Add(selected8);
            }
            if (selected9 != null)
            {
                Order.Items.Add(selected9);
            }
            if (selected10 != null)
            {
                Order.Items.Add(selected10);
            }
            if (selected11 != null)
            {
                Order.Items.Add(selected11);
            }
            if (selected12 != null)
            {
                Order.Items.Add(selected12);
            }
            if (selected16 != null)
            {
                Order.Items.Add(selected16);
            }
            if (selected17 != null)
            {
                Order.Items.Add(selected17);
            }
            if (selected18 != null)
            {
                Order.Items.Add(selected18);
            }
            if (selected19 != null)
            {
                Order.Items.Add(selected19);
            }
            if (selected20 != null)
            {
                Order.Items.Add(selected20);
            }
            if (selected21 != null)
            {
                Order.Items.Add(selected21);
            }
            if (selected22 != null)
            {
                Order.Items.Add(selected22);
            }
            if (selected23 != null)
            {
                Order.Items.Add(selected23);
            }
            if (selected24 != null)
            {
                Order.Items.Add(selected24);
            }
            if (selected25 != null)
            {
                Order.Items.Add(selected25);
            }
            if (selected26 != null)
            {
                Order.Items.Add(selected26);
            }


        }
        private void Form5_Load(object sender, EventArgs e)
        {
          
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (selected24 != null)
            {
                Order.Items.Add(selected24);
                Form3 f3 = new Form3();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            if (selected25 != null)
            {
                Order.Items.Add(selected25);
                Form3 f3 = new Form3();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            if (selected26 != null)
            {
                Order.Items.Add(selected26);
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
                this.Close();
            }

        

        }
    }
}
        
