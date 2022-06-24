using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using HELVETAS.forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELVETAS
{
    public partial class settibg_db : Form
    {
        SQLConfig mysql_sqting_database;
        public settibg_db()
        {
            InitializeComponent();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            mysql_sqting_database = new SQLConfig();
            mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
            try
            {
                //mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
                if (mysql_sqting_database.is_connection)
                {
                    msg new_msg = new msg();
                    new_msg.label_txt_info_txt = "Шумо бо базаи малумот пайваст шудед!";
                    new_msg.img_info_img = Properties.Resources.info__1_;
                    new_msg.ShowDialog();
                    save_but.Enabled = true;
                    test_connect_but.Enabled = false;
                    connect_but.Enabled = false;
                    disconnect_but.Enabled = true;
                    txt_server.Enabled = false;
                    txt_name_db.Enabled = false;
                    txt_user.Enabled = false;
                    txt_password.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                msg new_msg = new msg();
                new_msg.label_txt_info_txt = "Шумо бо базаи малумот пайваст нашудед!\n"+@"\b Хатоги"+ "\n" + ex.ToString();
                new_msg.img_info_img = Properties.Resources.info_button;
                new_msg.ShowDialog();

            }

        }
        string path = @"setting\setting_db.txt";
        private void settibg_db_Load(object sender, EventArgs e)
        {
            List<string> setting_db = new List<string>(); 
            string line;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                setting_db.Add(line);
            }
            txt_server.Text = setting_db[0];
            txt_name_db.Text = setting_db[1];
            txt_user.Text= setting_db[2];
            txt_password.Text = setting_db[3];
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(txt_server.Text);
            file.WriteLine(txt_name_db.Text);
            file.WriteLine(txt_user.Text);
            file.WriteLine(txt_password.Text);
            msg new_msg = new msg();
            new_msg.label_txt_info_txt = "Амалиёт анчом ёфт!";
            new_msg.img_info_img = Properties.Resources.info__1_;
            new_msg.ShowDialog();
            file.Flush();
            file.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            mysql_sqting_database = new SQLConfig();
            mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
            try
            {
                //mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
                if (mysql_sqting_database.is_connection_test)
                {
                    msg new_msg = new msg();
                    new_msg.label_txt_info_txt = "Тафтиш бо мувафакатият анчом ёфт!";
                    new_msg.img_info_img = Properties.Resources.info__1_;
                    new_msg.ShowDialog();
                    connect_but.Enabled = true;
                    test_connect_but.Enabled=false;
                    //txt_server.Enabled = false;
                    //txt_name_db.Enabled = false;
                    //txt_user.Enabled = false;
                    //txt_password.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                msg new_msg = new msg();
                new_msg.label_txt_info_txt = "Тафтиш бе мувафакатият анчом ёфт!\n" + @"\b Хатоги" + "\n" + ex.ToString();
                new_msg.img_info_img = Properties.Resources.info_button;
                new_msg.ShowDialog();

            }
        }

        private void disconnect_but_Click(object sender, EventArgs e)
        {
            mysql_sqting_database = new SQLConfig();
            mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
            try
            {
                //mysql_sqting_database.connect(txt_server.Text, txt_name_db.Text, txt_user.Text, txt_password.Text);
                if (mysql_sqting_database.is_connection_test)
                {
                    msg new_msg = new msg();
                    new_msg.label_txt_info_txt = "Баззаи малмот кат карда шуд!";
                    new_msg.img_info_img = Properties.Resources.info__1_;
                    new_msg.ShowDialog();
                    connect_but.Enabled = false;
                    test_connect_but.Enabled = true;
                    disconnect_but.Enabled = false;
                    save_but.Enabled = false;
                    txt_server.Enabled = true;
                    txt_name_db.Enabled = true;
                    txt_user.Enabled = true;
                    txt_password.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                msg new_msg = new msg();
                new_msg.label_txt_info_txt = "Шумо хатогие доред!\n" + @"\b Хатоги" + "\n" + ex.ToString();
                new_msg.img_info_img = Properties.Resources.info_button;
                new_msg.ShowDialog();

            }
        }
    }
}
