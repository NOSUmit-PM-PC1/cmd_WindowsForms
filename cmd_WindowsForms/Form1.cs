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

    public partial class Form1 : Form
    {
        public int countSimbols = 100000;
        string paramsFromFile()
        {
            StreamReader sr = new StreamReader("params.txt");
            string s = sr.ReadLine();
            sr.Close();
            return "from FILE " + s;
         }
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(paramsFromFile());  
        }

        public Form1(string param)
        {
            InitializeComponent();
            listBox1.Items.Add("from New " + param);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Add("from FIELD " + countSimbols.ToString());
        }
    }
}
