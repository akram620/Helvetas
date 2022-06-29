using HELVETAS.forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELVETAS.lncludes
{
    class SQLConfiguration
    {

        public static String datasource { get; set; }
        public static String port { get; set; }
        public static String username { get; set; }
        public static String password { get; set; }
        public static String database { get; set; }
        public static bool stateConnection { get; set; }

        public static MySqlConnection connection;

        public  MySqlDataAdapter dataAdapter;
        public DataTable dataTable;

        public static bool getConnection()
        {
            string sql = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database + ";";

            connection = new MySqlConnection(sql);

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                stateConnection = true;
                connection.Close();
                return true;
            }
            catch(MySqlException exception)
            {
                stateConnection = false;
                return false;
                
            }
        }


        private static MySqlCommand cmd;

        public DataTable loginUser(string sql)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);
                
                return dataTable;

            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        
    }
}
