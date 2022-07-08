using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using HELVETAS.Data;
using HELVETAS.forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELVETAS.lncludes
{
    class SQLConfiguration
    {

        public static String datasource { get; set; }
        public static String port { get; set; }
        public static String username { get; set; }
        public static String password { get; set; }
        public static String database { get; set; }

        public static MySqlConnection connection;

        public  MySqlDataAdapter dataAdapter;
        public DataTable dataTable;
        private MySqlCommand cmd;

        public static bool getConnection()
        {
            string sql = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database + ";";

            try
            {
                connection = new MySqlConnection(sql);
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        
        

        public DataTable sqlSelectQuery(string sql)
        {
            openConnection();

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
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }

        public int sqlQuery(string sql)
        {

            try
            {
                openConnection();

                cmd = new MySqlCommand();
                
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                return 1;
                
            }

            catch (Exception ex)
            {
                return 500;
            }

            finally
            {
                closeConnection();
                cmd = null;
            }
        }

        public void displayList(string sql, DataGridView dataGridView)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;
                
                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
                
            }

            catch (Exception ex)
            {

            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }



        public int saveActionDate(string id_action)
        {
            string sql = "insert into time_users (id_user, date, time, action_user) values('" + UserData.id_user + "', curdate(), curtime(), '" + id_action + "');";
            try 
            {
                openConnection();

                cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = sql;


                return cmd.ExecuteNonQuery();
                

            }

            catch (Exception ex)
            {
                return -1;
            }

            finally
            {
                closeConnection();
                cmd = null;
            }
        }
    }
}
