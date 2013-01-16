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
    public partial class Transfer4 : Form
    {
        public string str, str1, str2;
        public string a, b;
        public string x, y;
        public Transfer4()
        {
            InitializeComponent();
        }

        public Transfer4(string a, string b, string c)
        {
            InitializeComponent();
            str = a;
            str1 = b;
            str2 = c;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            bool NoofYes = false;
            bool Noof = false;
            for (int i = 0; i < usersList.Count; i++)
            {
                if (str == (usersList[i].SelectSingleNode("ID").InnerText))
                {
                    a = usersList[i].SelectSingleNode("Balance").InnerText;
                    b = (int.Parse(a) + int.Parse(str2)).ToString();
                    usersList[i].SelectSingleNode("Balance").InnerText = b;
                    NoofYes = true;
                    break;
                }  
            }

            for (int j = 0; j < usersList.Count; j++)
            {
                
                if (str1 == (usersList[j].SelectSingleNode("ID").InnerText))
                {
                    x = usersList[j].SelectSingleNode("Balance").InnerText;
                    y = (int.Parse(x) - int.Parse(str2)).ToString();
                    usersList[j].SelectSingleNode("Balance").InnerText = y;
                    Noof = true;
                    break;
                }
            }
           
            
            if (NoofYes == true&&Noof==true)
            {
                xmlDoc.Save("ATM.xml");
                Form frm = new Transfer5();
                frm.ShowDialog();
                this.Close();
                //Form frm2 = new Menu(str,a);

                //this.Hide();
                //frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong!");//转到错误页面
            }
        }


        private void Transfer4_Load(object sender, EventArgs e)
        {
            label2.Text = str;
            label4.Text = str2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(str + str1 + str2);
        }

       
    }
}
