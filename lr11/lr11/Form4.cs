using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr11
{
    public partial class Form4 : Form
    {
        public Form1 form1;
        public void Login(string login, string lastname, string name, string phone, string email, 
            string birth, string disign, string datefirst)
        {
            label1.Text = login;
            label2.Text = lastname;
            label3.Text = name;
            label4.Text = phone;
            label5.Text = email;
            label6.Text = birth;
            label7.Text = disign;
            label8.Text = datefirst;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Visible = true;
            this.Close();
        }
    }
}
