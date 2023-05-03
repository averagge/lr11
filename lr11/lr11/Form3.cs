using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr11
{
    public partial class Form3 : Form
    {
        public Form1 form1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("aleksejporfirev15@mail.ru", "Nikita");
            MailAddress to = new MailAddress(textBox1.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Пароль для входа в аккаунт";
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (textBox1.Text == user.Email)
                    {
                        m.Body = "<h1>Пароль: " + user.Password + "</h1>";
                    }
                }
            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("aleksejporfirev15@mail.ru", "sfpTejiGf56XESWqtKKc");
            smtp.EnableSsl = true;
            smtp.Send(m);
            form1.Visible = true;
            this.Close();
        }
    }
}
