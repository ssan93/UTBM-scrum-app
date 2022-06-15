
using MySql.Data.MySqlClient;
using System;

namespace pr74_scrum_app
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string password;
        private string email;
        private readonly Database db = new Database();
        public User(int id, string firstName, string lastName, string password, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
        }
        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }

        //methode to udpdate user informations
        public void Update()
        {
            MySqlDataReader na;
            try
            {
                string stringupdate = $"Update users set firstname='{firstName}' , lastname='{lastName}' where id={id} and email='{email}'";
                na = db.ExecutQuery(stringupdate);
                na.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
