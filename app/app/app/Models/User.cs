using System;
using System.Collections.Generic;
using System.Text;

namespace app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckLoginInfo()
        {
            if (this.Username.Equals("demo") && this.Password.Equals("password"))
                return true;
            else
                return false;
        }

    }
}
