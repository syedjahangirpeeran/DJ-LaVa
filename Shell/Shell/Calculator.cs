using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text ) * -1) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox2.Text = textBox2.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
                textBox2.Text = textBox2.Text + ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox2.Text = textBox2.Text + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox2.Text = textBox2.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox2.Text = textBox2.Text + 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = textBox2.Text + "+";
            count = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox2.Text = textBox2.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox2.Text = textBox2.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox2.Text = textBox2.Text + 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                textBox2.Text = textBox2.Text + "-";
                count = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox2.Text = textBox2.Text + 7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox2.Text = textBox2.Text + 8;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox2.Text = textBox2.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = textBox2.Text + "*";
            count = 3;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && textBox1.TextLength > 0)
            {
                num1 = 0; textBox1.Clear();
            }
            else if (num1 > 0 && textBox1.TextLength > 0)
            {
                textBox1.Clear();
                
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            count = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            textBox1.Text = textBox1.Text.Remove(c - 1);
            count = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = textBox2.Text + "/";
            count = 4;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = textBox2.Text + "%";
            count = 5;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = textBox2.Text + "sqrt.";
            count = 6;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = textBox2.Text + "^2";
            count = 7;

        }

        

        private void button24_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

            count = 8;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = Convert.ToSingle(Math.Sqrt(num1));
                    textBox1.Text = ans.ToString();
                    break;
                case 7:
                    ans = num1 * num1;
                    textBox1.Text = ans.ToString();
                    break;
                case 8:
                    ans = 1/num1 ;
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
