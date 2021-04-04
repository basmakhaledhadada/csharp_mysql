using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace csharp_mysql
{
    class connection
    {
            public MySqlConnection con;
            private string server;
            private string port;
            private string username;
            private string password;

        //Constructor
        public connection()
            {
                Initialize();
            OpenConnection();
            }

            //Initialize values
            private void Initialize()
            {
                server = "localhost";
                port = "3306";
                username = "root";
                password = "";
                string connectionString;
             
                connectionString = "datasource=" + server + ";" + "port=" +
                port + ";" + "username=" + username + ";" + "password=" + password + ";";
                con = new MySqlConnection(connectionString);
            }

            //open connection to database
            public bool OpenConnection()
            {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string query)
            {

            //open connection

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, con);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection

        }

            //Update statement
            public void Update()
            {
            }

            //Delete statement
            public void Delete()
            {
            }

        //Select statement
        // public List<string>[] Select()
        //{
        //}

        //Count statement
        //public int Count()
        //{
        //}


    }
}

