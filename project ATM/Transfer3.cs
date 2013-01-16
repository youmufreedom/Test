using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_ATM
{
    public partial class Transfer3 : Form
    {
        public string str, str1,str2;
        public Transfer3()
        {
            InitializeComponent();
        }
        public Transfer3(string a, string b)
        {
            InitializeComponent();
            str = a;
            str1 = b;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str2 = textBox1.Text;
            Form frm = new Transfer4(str, str1,str2);
            frm.ShowDialog();
            this.Close();
        }

        private void Transfer3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
