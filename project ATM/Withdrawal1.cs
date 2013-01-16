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
    public partial class Withdrawal1 : Form
    {
        private string str;
        private int a;
        public Withdrawal1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = (int.Parse(str) - 200).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Withdrawal1(string ID)
        {
            InitializeComponent();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            for (int i = 0; i < usersList.Count; i++)
            {
                if (ID == (usersList[i].SelectSingleNode("ID").InnerText))
                {
                    str = usersList[i].SelectSingleNode("Balance").InnerText;
                    a = i;
                }
            }
        }

        private void Withdrawal1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            str=(int.Parse(str)-100).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = (int.Parse(str) - 500).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str = (int.Parse(str) - 1000).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str = (int.Parse(str) - 2000).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str = (int.Parse(str) - 5000).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Withdrawal2(str,a);
            frm.ShowDialog();
            this.Close();
        }
    }
}
