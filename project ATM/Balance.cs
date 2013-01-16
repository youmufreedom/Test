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
    public partial class Balance : Form
    {
        private string str;
        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            label1.Text = "Your balance is " + str + ".";
        }
        public Balance(string ID)
        {
            InitializeComponent();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            for (int i = 0; i < usersList.Count; i++)
            {
                if(ID==(usersList[i].SelectSingleNode("ID").InnerText))
                {
                    str = usersList[i].SelectSingleNode("Balance").InnerText;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = (Menu)Owner;
            form.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
