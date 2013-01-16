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
    public partial class Withdrawal2 : Form
    {
        string str;
        int a;
        public Withdrawal2()
        {
            InitializeComponent();
        }
        public Withdrawal2(string ID, int i)
        {
            InitializeComponent();
            str = ID;
            a = i;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            str = (int.Parse(str) - int.Parse(textBox1.Text)).ToString();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ATM.xml");
            XmlNodeList usersList = xmlDoc.SelectNodes("/Table/User");
            usersList[a].SelectSingleNode("Balance").InnerText = str;
            xmlDoc.Save("ATM.xml");
            Form frm = new Withdrawal3();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Withdrawal2_Load(object sender, EventArgs e)
        {

        }
    }
}
