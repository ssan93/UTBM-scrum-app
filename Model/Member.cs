using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class Member : IEquatable<Member>
    {
        private int id;
        private string role;
        private User user;

        public Member(int id, string role, User user)
        {
            this.id = id;   
            this.role = role;
            this.user = user;
        }
        public int Id { get { return id; }  set { id = value; }}
        public User User { get { return user; } set { user = value; }}
        public string Role { get { return role; } set { role = value; } }

        public bool Equals(Member other)
        {
            return id == other.id;
        }
    }
}
