using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr11
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Design { get; set; }
        public string Birth { get; set; }
        public string DateFirst { get; set; }


        public User()
        { }
        public User(string Login, string Password, string Email, string Phone, string Name, string LastNasme,  string Design, string Birth, string DateFirst)
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
            this.Birth = Birth;
            this.DateFirst = DateFirst;
            this.Design = Design;
            this.Name = Name;
            this.LastName = LastNasme;
            this.Phone = Phone;

        }

    }
}
