using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BL
{
    public class User
    {
        protected string name;
        protected string email;
        protected string password;
        protected string role;
        public User(string name, string email, string password, string role)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public string Name { get { return name; } set { this.name = value; } }
        public string Email { get { return email; } set { this.email = value; } }
        public string Password { get { return password; } set { this.password = value; } }
        public string Role { get { return role; } set { this.role = value; } }
    }
}
