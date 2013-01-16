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
    public partial class Login : Form
    { 
         public Login()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            int a=0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            bool NoofYes = false;
            for (int i = 0; i < usersList.Count; i++)
            {
                if (textBox1.Text.Equals(usersList[i].SelectSingleNode("ID").InnerText) && textBox2.Text.Equals(usersList[i].SelectSingleNode("Password").InnerText))
                {
                    NoofYes = true;
                    str = usersList[i].SelectSingleNode("ID").InnerText;
                    a = i;
                    break;
                }
            }

            if (NoofYes == true)
            {
                Form frm2 = new Menu(str,a);
                this.Visible = false;
                //this.Hide();
                frm2.Show(this);
            }
            else
            {
                MessageBox.Show("ID or Password is worng");//转到错误页面
            }   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
