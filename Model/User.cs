
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
        public void UpdateInfos()
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
        /* This methide reate a projet, fiell table project and table member
         * the person whom create the projet is automatically the owner and the project stage archived is 0 for no
        */
        public void CreateProjet(string name)
        {
            MySqlDataReader na,data;
            int idpro=0;
            try
            {
                string insertProjet = $"insert into project(name,archived,created_dt) values('{name}',{0},CURRENT_DATE) ; SELECT LAST_INSERT_ID() as id";
                data=db.ExecutQuery(insertProjet);
                if (data.Read())
                {
                    idpro = data.GetInt32(0); // get projet id
                    data.Close();
                }
                if (idpro != 0)
                {
                    string insertMernber = $"insert into member(role,project_id,user_id) values('srummaster',{idpro},{id})";
                    na = db.ExecutQuery(insertMernber);
                    na.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Votre projet na pas été crée correctement : " + e.Message);
            }
        }
        public void UpdateProjetName(string name)
        {

        }
    }
}
