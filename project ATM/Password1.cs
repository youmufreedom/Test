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
    public partial class Password1 : Form
    {
        private string str;
        private int a;
        public Password1()
        {
            InitializeComponent();
        }

         public Password1(string ID,int i)
        {
            InitializeComponent();
            str = ID;
            a = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            if (textBox1.Text == usersList[a].SelectSingleNode("Password").InnerText)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    usersList[a].SelectSingleNode("Password").InnerText = textBox2.Text;
                    xmlDoc.Save("ATM.xml");
                    Form frm = new Password2();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The password is not the same!Please enter again.");
                }   
            }
            else
            {
                MessageBox.Show("The password is wrong,please try again!");
            }
        }

        private void Password1_Load(object sender, EventArgs e)
        {

        }
    }
}
