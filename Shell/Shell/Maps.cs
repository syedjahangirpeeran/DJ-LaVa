using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

            string street = txt_street.Text;
            string city = txt_city.Text;
            string zip = txt_zip.Text;
            string state = txt_state.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");
                if (street != string.Empty)
                {
                    queryaddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryaddress.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryaddress.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("shutting down");
            this.Close();
        }
    }
   /* public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }*/
}
