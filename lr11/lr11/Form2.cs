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

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                User user = new User(textBox1.Text, this.GetHashString(textBox2.Text), textBox5.Text,
                    textBox12.Text, textBox4.Text, textBox3.Text, textBox11.Text, textBox6.Text, textBox10.Text);
                db.Users.Add(user);
                db.SaveChanges();
                Form4 form4 = new Form4();
                form4.Login(user.Login, user.LastName, user.Name, user.Phone, user.Email, user.Birth,
                    user.Design, user.DateFirst);
                form4.Show();
                this.Close();
            }
        }
    }
}
