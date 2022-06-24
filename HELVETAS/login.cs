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

namespace HELVETAS
{
    public partial class login : Form
    {
        SQLConfig mysql_sqting_database;
        public login()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.settings_leave;
            //pictureBox4.Width = pictureBox4.Width - 5;
            //pictureBox4.Height = pictureBox4.Height - 5;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox4.Width = pictureBox4.Width + 5;
            //pictureBox4.Height = pictureBox4.Height + 5;
            pictureBox4.Image = Properties.Resources.setting_hover;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            settibg_db seting_db = new settibg_db();
            seting_db.ShowDialog();
        }
        string path = @"setting\setting_db.txt";
        private void login_Load(object sender, EventArgs e)
        {
            List<string> setting_db = new List<string>();
            string line;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                setting_db.Add(line);
            }
            sr.Close();
           string txt_server = setting_db[0];
            string txt_name_db = setting_db[1];
            string txt_user = setting_db[2];
            string txt_password = setting_db[3];
             mysql_sqting_database = new SQLConfig();
            mysql_sqting_database.connect(txt_server, txt_name_db, txt_user, txt_password);
            try
            {
                //mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
                if (mysql_sqting_database.is_connection)
                {
                    //msg new_msg = new msg();
                    //new_msg.label_txt_info_txt = "Шумо бо базаи малумот пайваст шудед!";
                    //new_msg.img_info_img = Properties.Resources.info__1_;
                    //new_msg.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {
               
                msg new_msg = new msg();
                new_msg.label_txt_info_txt = "Шумо бо базаи малумот пайваст нашудед!\n" + @"\b Хатоги" + "\n" + ex.ToString();
                new_msg.img_info_img = Properties.Resources.info_button;
                new_msg.ShowDialog();
                settibg_db seting_db = new settibg_db();
                seting_db.ShowDialog();

            }

        }
        string sql;
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            mysql_sqting_database = new SQLConfig();
            sql = " SELECT* FROM users WHERE login_user = '" + login_txt.Text + "' and password_user = sha1('" + password_txt.Text + "')";
            mysql_sqting_database.singleResult(sql);
            if (mysql_sqting_database.dt.Rows.Count > 0)
            {
                MessageBox.Show(mysql_sqting_database.dt.Rows.ToString());
                //main_menu m_n = new main_menu();
                //m_n.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist! Please contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
