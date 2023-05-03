using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr11
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                User user = new User(textBox1.Text, form1.GetHashString(textBox2.Text), textBox5.Text,
                    textBox12.Text, textBox4.Text, textBox3.Text, textBox11.Text, textBox6.Text, textBox10.Text);
                db.Users.Add(user);
                db.SaveChanges();
                Form4 form4 = new Form4();
                form4.Login(user.Login, user.LastName, user.Name, user.Phone, user.Email, user.Birth,
                    user.Design, user.DateFirst);
                form4.Show();
                form4.form1 = this.form1;
                this.Close();
            }
        }
    }
}
