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
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Text File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            sfd.Title = "Select a filename";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string promptValue = Prompt.ShowDialog("Test", "123");
            DialogResult dialog = MessageBox.Show("Do you want to save your file?", "Exit", MessageBoxButtons.OKCancel);
            if(dialog == DialogResult.OK)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.txt";
                sfd.Title = "Select a filename";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
            }

            //else if(dialog == DialogResult.Cancel)

            richTextBox1.Text = "";
            //System.Windows.Forms.MessageBox.Show("The ");
        }

       
    }
}
