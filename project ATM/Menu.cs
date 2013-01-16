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
    public partial class Menu : Form
    {
        private string str;
        private int a;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string ID,int i)
        {
            InitializeComponent();
            str = ID;
            a = i;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form frm3 = new Balance(str);
            this.Visible = false;
            frm3.Show(this);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm4 = new Withdrawal1(str);
            frm4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm5 = new Password1(str,a);
            frm5.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Login form = (Login)Owner;
            form.Visible = true;
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm6 = new Transfer1(str,a);
            frm6.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
