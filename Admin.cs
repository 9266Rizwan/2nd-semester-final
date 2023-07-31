using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BL
{
    public class Admin : User
    {
        public Admin(string name, string email, string password, string role) : base(name, email, password, role) { }
    }
}
