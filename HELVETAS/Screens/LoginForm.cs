using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using HELVETAS.lncludes;
using HELVETAS.Data;

namespace HELVETAS
{
    public partial class LoginForm : Form
    {

        SQLConfiguration sqlConfiguration;

        DbSettingsForm dbSettingsForm;
        

        public LoginForm()
        {
            InitializeComponent();
            sqlConfiguration = new SQLConfiguration();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            List<string> setting_db = new List<string>();
            string line;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                setting_db.Add(line);
            }
            sr.Close();

            SQLConfiguration.datasource = setting_db[0];
            SQLConfiguration.database = setting_db[1];
            SQLConfiguration.username = setting_db[2];
            SQLConfiguration.password = setting_db[3];
            SQLConfiguration.port = "3306";

            if (!SQLConfiguration.getConnection())
            {
                MessageBox.Show("Хатоги хангоми ба база пайваст шудан!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }





        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.settings_leave;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.setting_hover;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dbSettingsForm = new DbSettingsForm();
            dbSettingsForm.ShowDialog();
        }


        string path = @"setting\setting_db.txt";



        private void login_btn_Click(object sender, EventArgs e)
        {
            string sql = "select * from users where login_user = '" + login_txt.Text + "' and password_user = '" + password_txt.Text + "'";

            MainForm mainForm = new MainForm();

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                MessageBox.Show("Хангоми пайвастшави ба база мушкили ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    StaticData.id_user = dataTable.Rows[0]["id"].ToString();
                    StaticData.name_user = dataTable.Rows[0]["name_user"].ToString();
                    StaticData.type_user = dataTable.Rows[0]["type_user"].ToString();
                    StaticData.password_user = dataTable.Rows[0]["password_user"].ToString();

                    // saveDate();

                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Логин ё парол нодуруст аст ё ин ки чунин истифодабаранда вучуд надорад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            
        }

        private void saveDate()
        {
            string sql = "insert into time_users (id_user, date, time, action_user) values('" + StaticData.id_user + "', curdate(), curtime(), '1');";
            sqlConfiguration.sqlQuery(sql);
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {

            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
