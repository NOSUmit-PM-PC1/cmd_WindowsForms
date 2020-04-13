using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmd_WindowsForms
{
  
    public partial class Form2 : Form
    {
        Form1 f;
        string readFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }
        public Form2(string[] pars)
        {
            InitializeComponent();
            f = new Form1();
            f.Show();
            try
            {
                //MessageBox.Show(pars[0]);
                textBox1.Text = readFromFile(pars[0]);
            }
            catch
            {
               // MessageBox.Show("Нет параметров");
            }
        }

        private void menuPassByFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("params.txt");
            sw.WriteLine(textBox1.Text.Length);
            sw.Close(); 
        }

        private void menuPassByNew_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1(textBox1.Text.Length.ToString());
            //f.Show();
        }

        private void menuPassByFild_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            f.countSimbols = textBox1.Text.Length;
            //f.Show();
        }
    }
}
