using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    class Database
    {
        readonly string connectionString = ConfigurationManager.AppSettings["connectionString"]; //get database infos from app.config
        static MySqlConnection con;
        static MySqlTransaction transaction;
        private bool transactionOwner;
        MySqlDataReader reader;
        MySqlCommand cmd;
        //connection to database
        public void Connect()
        {
            if(con == null)
            {
                con = new MySqlConnection(connectionString);
                con.Open();
                Console.WriteLine($"MySQL version : {con.ServerVersion}");
            }
        }

        //run a request
        public MySqlDataReader ExecutQuery(string query)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                return reader; //return request result
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return reader; //retrun null
            }
        }

        public void Begin()
        {
            if (transaction == null) { 
                transaction = con.BeginTransaction();
                transactionOwner = true;
            }
        }

        public void Commit()
        {
            if(transaction != null && transactionOwner)
            {
                transaction.Commit();
                transaction = null;
            }
            transactionOwner = false;
        }

        public void Rollback()
        {
            if(transaction != null)
            {
                transaction.Rollback();
                transaction = null;
            }
            transactionOwner = false;
        }

        //close databse connection
        public void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
}
