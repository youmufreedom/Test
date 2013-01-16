using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace project_ATM
{
    public partial class Transfer2 : Form
    {
        private string str="",str1 = "", str2 = "";
        public Transfer2()
        {
            InitializeComponent();
        }

        public Transfer2(string a,string b,string c)
        {
            InitializeComponent();
            str1 = a;
            str2 = b;
            str =c;

        }
        private void Transfer2_Load(object sender, EventArgs e)
        {
        
            label2.Text = str1;
            label4.Text = str2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm1 = new Transfer3(str1, str);
            frm1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
