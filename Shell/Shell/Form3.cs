using System;
using System.IO;
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
    public partial class Form3 : Form
    {
        public static class Globals
        {
            public static String curdir = "";
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                String curcmd = "";
                curcmd = textBox1.Text;
                textBox1.Text = "";
                exec_cmd(curcmd);
            }
        }
        private void exec_cmd(String cmd)
        {
            String[] fcmd = cmd.Split(' ');
            if (fcmd[0] == "echo")
            {
                int x = 0;
                String outl = "";
                outl = "DJ-LaVa" + Globals.curdir + ">";
                foreach (String pcmd in fcmd)
                {
                    if (x != 0)
                    {
                        outl = outl + " " + pcmd;
                    }
                    x = 100000;
                }
                label1.Text = outl;
            }
            else if (fcmd[0] == "FileManager")
            {
                FileManager newf = new FileManager();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "MediaPlayer")
            {
                MediaPlayer newf = new MediaPlayer();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "Notepad")
            {
                Notepad newf = new Notepad();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "Calculator")
            {
                Calculator newf = new Calculator();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }

            else if (fcmd[0] == "Browser")
            {
                Browser newf = new Browser();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "Maps")
            {
                Maps newf = new Maps();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            /* else if (fcmd[0] == "CpuMonitor")
             {
                 Form12 newf = new Form12();
                 newf.MdiParent = this.ParentForm;
                 newf.Show();
             }
             else if (fcmd[0] == "Calendar")
             {
                 Form13 newf = new Form13();
                 newf.MdiParent = this.ParentForm;
                 newf.Show();
             }
             else if (fcmd[0] == "cp")//Not working
             {
                 String at = Application.StartupPath + Globals.curdir;
                 System.Diagnostics.Process process = new System.Diagnostics.Process();
                 process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                 process.StartInfo.FileName = "cmd.exe";
                 process.StartInfo.Arguments = "/C copy \"" + at + "\\" + fcmd[1] + "\" \"" + at + "\\" + fcmd[2] + "\"";
                 process.Start();
                 label1.Text = "/C copy " + at + "\\" + fcmd[1] + '\n' + at + "\\" + fcmd[2];
             }*/
            else if (fcmd[0] == "mkdir")
            {
                String at = Application.StartupPath + Globals.curdir;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C mkdir \"" + at + "\\" + fcmd[1] + "\"";
                String outl = "DJ-LaVa" + Globals.curdir + ">";
                outl = outl + "Created directory. ";
                label1.Text = outl;
                process.Start();
            }
            else if (fcmd[0] == "touch")
            {
                String at = Application.StartupPath + Globals.curdir;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C echo.> \"" + at + "\\" + fcmd[1] + "\"";
                process.Start();
                String outl = "DJ-LaVa" + Globals.curdir + ">";
                outl = outl + "Created file.";
                label1.Text = outl;
            }
            else if (fcmd[0] == "ls")
            {
                String[] dir = Directory.GetDirectories(Application.StartupPath + Globals.curdir);
                String outl = "DJ-LaVa" + Globals.curdir + ">";
                outl = outl + '\n';
                foreach (String word in dir)
                {
                    int m = word.Length - 1;
                    while (m >= 0 && word[m] != '\\')
                    {
                        m--;
                    }
                    String nw = word.Substring(m + 1);
                    outl = outl + nw;
                    outl = outl + '\n';
                }
                String[] dir2 = Directory.GetFiles(Application.StartupPath + Globals.curdir);
                foreach (String word in dir2)
                {
                    int m = word.Length - 1;
                    while (m >= 0 && word[m] != '\\')
                    {
                        m--;
                    }
                    String nw = word.Substring(m + 1);
                    outl = outl + nw;
                    outl = outl + '\n';
                }
                label1.Text = outl;
            }
            else if (fcmd[0] == "cd")
            {
                if (fcmd[1] == "..")
                {
                    String outl = "";
                    String temp = "";
                    temp = Globals.curdir;
                    int x = temp.Length;
                    x = x - 2;
                    while (x >= 0 && temp[x] != '\\')
                    {
                        x--;
                    }
                    if (x >= 0)
                    {
                        Globals.curdir = temp.Substring(0, x);
                        outl = "DJ-LaVa" + Globals.curdir + ">";
                        label1.Text = outl;
                    }
                }
                else
                {
                    int x = 0;
                    int f = 0;
                    String outl = "DJ-LaVa";
                    foreach (String pcmd in fcmd)
                    {
                        String[] dir = Directory.GetDirectories(Application.StartupPath + Globals.curdir);
                        foreach (String word in dir)
                        {
                            int m = word.Length - 1;
                            while (m >= 0 && word[m] != '\\')
                            {
                                m--;
                            }
                            String nw = word.Substring(m + 1);
                            if (pcmd == nw)
                            {
                                if (x != 0)
                                {
                                    Globals.curdir = Globals.curdir + "\\" + pcmd;
                                    f = 1;
                                }
                            }
                        }
                        x = 1;
                    }
                    if (f != 1)
                    {
                        outl = "DJ-LaVa" + Globals.curdir + ">";
                        outl = outl + " " + "The specified directory doesn't exist!";
                        label1.Text = outl;
                    }
                    else
                    {
                        outl = "DJ-LaVa" + Globals.curdir + ">";
                        outl = outl + " " + "(Y)";
                        label1.Text = outl;
                    }
                }
            }
            else
            {
                String outl;
                outl = "DJ-LaVa" + Globals.curdir + ">";
                outl = outl + " " + "Invalid Command";
                label1.Text = outl;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
