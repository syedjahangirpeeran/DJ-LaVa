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

    public partial class MediaPlayer : Form
    {
        string[] fi, pt;
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = filedialog.FileName;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pt[listBox1.SelectedIndex];
        }

        private void addToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Multiselect = true;
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                fi = filedialog.SafeFileNames;
                pt = filedialog.FileNames;
                for (int i = 0; i < fi.Length; i++)
                {
                    listBox1.Items.Add(fi[i]);
                }
            }
        }
    }
}
