using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Bayaran_2._0.Model
{
    public class mysqlClass
    {

        private MySqlConnection connection = null;
        public string lastQuery { get; set; }
        public int lastInsertId = -1;
        public MySqlConnection getCN()
        {
            return this.connection;
        }
        
        public mysqlClass(string host, string username, string password, string db)
        {
            try
            {
                string qs = "Server=" + host + ";Database=" + db + ";Uid=" + username + ";Pwd=" + password;
                connection = new MySqlConnection(qs);
                AppCentre.Log("Created New DB Connection \n" + qs);
            }
            catch (Exception e) {
                AppCentre.Log("Unable to connect to database!\nError Message : " + e.Message);
            }
        }
        public mysqlClass(string host, string username, string password)
        {
            try
            {
                connection = new MySqlConnection("Server=" + host + ";Uid=" + username + ";Pwd=" + password);
            }
            catch (Exception e)
            {
                AppCentre.Log("Unable to connect to database!\nError Message : " + e.Message);
            }
        }
        private void openconnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }                                    
                AppCentre.Log("Connection Opened for #" + connection.ServerThread.ToString());
            }
            catch (Exception e)
            {                
                AppCentre.Log("Error opening connection " + e.Message);                
            }
        }
        private void closeconnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                AppCentre.Log("Connection Closed for #" + connection.ServerThread.ToString());
            }
            catch (Exception e)
            {                
                AppCentre.Log("Error closing connection! "+e.Message);                
            }
        }
        private string repairquery(string str)
        {
            return str.Replace('[','`').Replace(']','`');
        }
        public int setQuery(string q, out DataSet data)
        {
            q = repairquery(q);
            lastQuery = q;
            try
            {
                openconnection();

                MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                DataSet ds = new DataSet();
                AppCentre.Log("Executing Query : " + q);
                int filled = adapter.Fill(ds);
                AppCentre.Log("Query Executed returning " + filled.ToString() + " Row" + (filled > 1 ? "s" : ""));
                data = ds;
                return filled;

            }
            catch (Exception e)
            {
                MessageBox.Show("Mysql : Error Opening Connection. Exiting.. \n" + e.Message, "Database Error");
                Application.Exit();
            }
            finally
            {
                closeconnection();
            }
            data = null;
            return -1;
        }
        public ConnectionState forceOpenConnection()
        {
            connection.Open();
            return connection.State;
        }
        public ConnectionState forceCloseConnection()
        {
            connection.Close();
            return connection.State;
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public int batchQuery(string q)
        {
            q = repairquery(q);
            if (connection.State == ConnectionState.Closed) AppCentre.Log("Connection closed");
            lastQuery = q;
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = q;
                return cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {                
                AppCentre.Log("ERROR INITIALIZING CONNECTION. " + Environment.NewLine + e.Message);
                return -1;
            }
            finally
            {

            }            
        }

        public int setQuery(string q)
        {
            q = repairquery(q);
            lastQuery = q;
            try
            {
                openconnection();                
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = q;
                AppCentre.Log("Executing Query : " + q);
                var result = cmd.ExecuteNonQuery();
                AppCentre.Log("Query Executed Returning Result of : " + result.ToString());
                return result;

            }
            catch (Exception e)
            {
                AppCentre.Log("ERROR INITIALIZING CONNECTION. " + Environment.NewLine + e.Message);
                return -1;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }            
        }
    }
}
