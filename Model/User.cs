using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app
{
    public class User
    {
        private int    id;
        private string password;
        private string email;

        public int Id {get { return id; } set { id = value; } }
        public string Password {get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
