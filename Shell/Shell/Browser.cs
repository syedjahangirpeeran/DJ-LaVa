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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string urlstring = textBox1.Text;
            if(urlstring.Contains("http://") || urlstring.Contains("https://"))
            {
                browser.Url = new Uri(textBox1.Text);
            }
            else
            {
                browser.Url = new Uri("http://"+urlstring);
                textBox1.Text = "http://" + urlstring;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //refresh
            browser.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //goback
            browser.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //goforward
            browser.GoForward();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
