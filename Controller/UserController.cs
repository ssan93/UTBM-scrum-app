using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace pr74_scrum_app.Controller
{
    class UserController : Controller
    {
        string email;
        int id;
        public UserController(): base() {}
        public string GetUserEmail()//when user is login this methode return email
        {
            return email;
        }
        public int GetUserId()//when user is login this methode return id
        {  
            return id; 
        }
        //methode to sign in into the application
        public bool UserLogin(string pass, string email)
        {
            if (pass != string.Empty || email != string.Empty)//check if field are not empty
            {
                string sql = $"select * from users where email='{email}' and password='{EncryptPass(pass)}'";
                MySqlDataReader dr = Database.ExecutQuery(sql); //if match 
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.email = (string)dr["email"];
                        this.id = (int)dr["id"];
                    }
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MySqlDataReader data = Database.ExecutQuery("select * from users where email='" + email + "'");
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
                        MySqlDataReader resp = Database.ExecutQuery(sql);
                        resp.Close();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
