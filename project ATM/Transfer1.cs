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
    public partial class Transfer1 : Form
    {
        private int a,x;
        private string str="",str1 = "", str2 = "";
        public Transfer1()
        {
            InitializeComponent();
        }
        public Transfer1(string ID,int i)
        {
            InitializeComponent();
            str = ID;
            a = i;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            bool z = false;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            for (int i = 0; i < usersList.Count; i++)
            {
                if (textBox1.Text.Equals(usersList[i].SelectSingleNode("ID").InnerText))
                {
                    x = i;
                    z = true;
                }
            }
            if (z == true)
            {
                str1 = usersList[x].SelectSingleNode("ID").InnerText;
                str2 = usersList[x].SelectSingleNode("Name").InnerText;

                Form frm2 = new Transfer2(str1, str2, str);
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The account is not exist!");
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transfer1_Load(object sender, EventArgs e)
        {

        }

    }
}
