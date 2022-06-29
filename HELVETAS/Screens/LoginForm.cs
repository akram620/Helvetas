using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HELVETAS.forms;
using System.Windows.Forms;
using System.IO;
using HELVETAS.lncludes;
using HELVETAS.Data;

namespace HELVETAS
{
    public partial class LoginForm : Form
    {

        public static string name;


        SQLConfiguration sqlConfiguration;

        DbSettingsForm dbSettingsForm;

        CustomMessageBox customMessageBox;
        SQLConfig sqcon = new SQLConfig();

        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            dbSettingsForm = new DbSettingsForm();
            customMessageBox = new CustomMessageBox();

            sqlConfiguration = new SQLConfiguration();

            
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

            if (SQLConfiguration.getConnection())
            {
                customMessageBox.label_txt_info_txt = "Connection success";
                customMessageBox.img_info_img = Properties.Resources.info;
                // customMessageBox.ShowDialog();
            }
            else
            {
                customMessageBox.label_txt_info_txt = "Connection failed";
                customMessageBox.img_info_img = Properties.Resources.info_button;
                customMessageBox.ShowDialog();
                dbSettingsForm.ShowDialog();
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
            dbSettingsForm.ShowDialog();
        }


        string path = @"setting\setting_db.txt";



        private void login_btn_Click(object sender, EventArgs e)
        {
            String sql = "select * from users where login_user = '" + login_txt.Text + "' and password_user = '" + password_txt.Text + "'";

            MainForm mainForm = new MainForm();

            DataTable dataTable = sqlConfiguration.loginUser(sql);

            if (dataTable == null)
            {
                customMessageBox.label_txt_info_txt = "Хатоги дар ким кучо хаст, ки кофта ёбед!!!";
                customMessageBox.img_info_img = Properties.Resources.info_button;
                customMessageBox.ShowDialog();
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    name = dataTable.Rows[0]["name_user"].ToString();
                    string type = dataTable.Rows[0]["type_user"].ToString();

                    UserData.name_user = name;


                    //UserData.setInfo(name, type);

                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    customMessageBox.label_txt_info_txt = "Логин ё парол нодуруст аст ё ин ки чунин истифодабаранда вучуд надорад!";
                    customMessageBox.img_info_img = Properties.Resources.info;
                    customMessageBox.ShowDialog();
                }
            }
        }
    }
}
