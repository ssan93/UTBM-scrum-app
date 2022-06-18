using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace pr74_scrum_app
{
    class UserController
    {
        private readonly Database db = new Database();
        private User user;
        //methode to sign in into the application
        public bool UserLogin(string pass, string email)
        {
            if (pass != string.Empty || email != string.Empty)//check if field are not empty
            {
                string sql = $"select * from users where email='{email}' and password='{EncryptPass(pass)}'";
                MySqlDataReader dr = db.ExecutQuery(sql); //if match 
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.user = new User((int)dr["id"], (string)dr["firstname"], (string)dr["lastname"], (string)dr["password"], (string)dr["email"]);
                    }
                    dr.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Methode to create a new user 
        public bool UserRegistration(string firstname, string lastname, string email, string pass, string confirmpass)
        {
            if (pass != string.Empty || email != string.Empty || firstname != string.Empty || lastname != string.Empty)
            {
                if (pass == confirmpass)//check confimation pass
                {
                    MySqlDataReader data = db.ExecutQuery("select * from users where email='" + email + "'");
                    if (data!=null && data.HasRows)//check if email exist
                    {
                        data.Close();
                        MessageBox.Show("Email Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (!Regex.IsMatch(email.Trim(), @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))// check if email is in right format
                    {
                        MessageBox.Show("Email address not valide ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        data.Close();
                        string sql = $"insert into users(lastname,firstname,email,password) values('{lastname}','{firstname}','{email}','{EncryptPass(pass)}')";
                        db.ExecutQuery(sql);
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
           }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string EncryptPass(string Pass)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("Iamtheencryptionkey"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(Pass);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        private string DecryptPass(string pass)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("Iamtheencryptionkey"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] data = Convert.FromBase64String(pass);
                        Console.WriteLine(data);
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(result);
                    }
                }

            }
        }
        public User User{ get { return user; } set { user = value; } }

        //methode to udpdate user informations
        public void UpdateInfos(string firstname, string lastname, string email,int id)
        {
            MySqlDataReader na;
            try
            {
                string stringupdate = $"Update users set firstname='{firstname}' , lastname='{lastname}' where id={id} and email='{email}'";
                na = db.ExecutQuery(stringupdate);
                na.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /* This methide reate a projet, fiell table project and table member
         * the person whom create the projet is automatically the owner and the project stage archived is 0 for no
        */
        public void CreateProjet(string name, string description, int id)
        {
            MySqlDataReader na, data;
            int idpro = 0;
            try
            {
                string insertProjet = $"insert into project(name,description,archived,created_dt) values('{name}','{description}',{0},CURRENT_DATE) ; SELECT LAST_INSERT_ID() as id";
                data = db.ExecutQuery(insertProjet);
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
