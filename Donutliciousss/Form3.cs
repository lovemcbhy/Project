using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donutliciousss
{
    public partial class Form3 : Form
    {
        int number;
        public Form3()
        {
            InitializeComponent();
          
        }
       
    
        private void button4_Click(object sender, EventArgs e)
        {

            if (number ==12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox1.Text = number.ToString();
            }

            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (number==0)
            {
                number = 1;
            }
            number --;
            textBox1.Text = number.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox2.Text = number.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox2.Text = number.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox3.Text = number.ToString();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(number == 0)
            {
                number = 1;
            }
            number--;
            textBox3.Text = number.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox4.Text = number.ToString();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox4.Text = number.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox5.Text = number.ToString();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox5.Text = number.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox6.Text = number.ToString();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox6.Text = number.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox7.Text = number.ToString();
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox7.Text = number.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox8.Text = number.ToString();
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox8.Text = number.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox9.Text = number.ToString();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox10.Text = number.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox9.Text = number.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox10.Text = number.ToString();
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox11.Text = number.ToString();
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox11.Text = number.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (number == 12)
            {
                number = 0;
                MessageBox.Show("This is only the AVAILABLE pieces");
            }
            else
            {
                number++;
                textBox12.Text = number.ToString();
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = 1;
            }
            number--;
            textBox12.Text = number.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            this.Hide();
          
            if (checkBox1.Checked)
            {
                f5.selected1 = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                f5.selected2 = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                f5.selected3 = checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                f5.selected4 = checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                f5.selected5 = checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                f5.selected6 = checkBox6.Text;
            }
            if (checkBox7.Checked)
            {
                f5.selected7 = checkBox7.Text;
            }
            if (checkBox8.Checked)
            {
                f5.selected8 = checkBox8.Text;
            }
            if (checkBox9.Checked)
            {
                f5.selected9 = checkBox9.Text;
            }
            if (checkBox10.Checked)
            {
                f5.selected10 = checkBox10.Text;
            }
            if (checkBox11.Checked)
            {
                f5.selected11 = checkBox11.Text;
            }
            if (checkBox12.Checked)
            {
                f5.selected12 = checkBox12.Text;
            }
            if (checkBox16.Checked)
            {
                f5.selected16 = checkBox16.Text;
            }
            if (checkBox17.Checked)
            {
                f5.selected17 = checkBox17.Text;
            }
            if (checkBox18.Checked)
            {
                f5.selected18 = checkBox18.Text;
            }
            if (checkBox19.Checked)
            {
                f5.selected19 = checkBox19.Text;
            }
            if (checkBox20.Checked)
            {
                f5.selected20 = checkBox20.Text;
            }
            if (checkBox21.Checked)
            {
                f5.selected20 = checkBox20.Text;
            }
            if (checkBox21.Checked)
            {
                f5.selected21 = checkBox21.Text;
            }
            if (checkBox22.Checked)
            {
                f5.selected22 = checkBox22.Text;
            }
            if (checkBox23.Checked)
            {
                f5.selected23= checkBox23.Text;
            }
            if (radioButton1.Checked)
            {
                f5.selected24 = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                f5.selected25 = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                f5.selected26 = radioButton3.Text;
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
                this.Close();
            }
            f5.ShowDialog();
            this.Close();


        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
