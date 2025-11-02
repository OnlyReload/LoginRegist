using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegist
{
    internal class DataHandler
    {

        string connectionString;
        SqlConnection connection;
        SqlCommand cmd;

        /// <summary>
        /// Constructor
        /// </summary>

        public DataHandler()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\LoginRegist\LoginRegist\Database1.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            cmd = new SqlCommand();
        }
        /// <summary>
        /// hard code parameters
        /// </summary>

        public void AddUser()
        {
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO users VALUES ('testuser', 'password')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void AddUser2(string username, string password)
        {
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO users VALUES (@username, @password)";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}
