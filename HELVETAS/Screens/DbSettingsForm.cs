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
using HELVETAS.lncludes;
using HELVETAS.Screens;

namespace HELVETAS
{
    public partial class DbSettingsForm : Form
    {
        SQLConfiguration sqlConfiguration;

        SQLConfig mysql_sqting_database;

        CustomMessageBox customMessageBox;

        string path = @"setting\setting_db.txt";

        public DbSettingsForm()
        {
            InitializeComponent();
        }


        private void connect_but_Click(object sender, EventArgs e)
        {
            if (SQLConfiguration.stateConnection)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();

            }
        }


        private void DbSettingsForm_Load(object sender, EventArgs e)
        {
            customMessageBox = new CustomMessageBox();


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


        private void test_connect_btn_Click(object sender, EventArgs e)
        {
            SQLConfiguration.datasource = txt_server.Text;
            SQLConfiguration.database = txt_name_db.Text;
            SQLConfiguration.port = "3306";
            SQLConfiguration.username = txt_user.Text;
            SQLConfiguration.password = txt_password.Text;
            
            if (SQLConfiguration.getConnection())
            {
                customMessageBox.label_txt_info_txt = "Success";
                customMessageBox.img_info_img = Properties.Resources.info;
                customMessageBox.ShowDialog();
                save_btn.Enabled = true;
                connect_but.Enabled = true;
            }
            else
            {
                customMessageBox.label_txt_info_txt = "Failed test\nCheck the inserted data";
                customMessageBox.img_info_img = Properties.Resources.info_button;
                customMessageBox.ShowDialog();
            }
                
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter(path);

                file.WriteLine(txt_server.Text);
                file.WriteLine(txt_name_db.Text);
                file.WriteLine(txt_user.Text);
                file.WriteLine(txt_password.Text);


                customMessageBox.label_txt_info_txt = "Амалиёт анчом ёфт!";
                customMessageBox.img_info_img = Properties.Resources.info;
                customMessageBox.ShowDialog();
                file.Flush();
                file.Close();

            }
            catch (Exception ex)
            {
                CustomMessageBox new_msg = new CustomMessageBox();
                new_msg.label_txt_info_txt = "Шумо хатогие доред!\n" + @"\b Хатоги" + "\n" + ex.ToString();
                new_msg.img_info_img = Properties.Resources.info_button;
                new_msg.ShowDialog();

            }
        }

    
    }
}
