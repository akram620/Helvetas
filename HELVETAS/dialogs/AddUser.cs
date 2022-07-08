using HELVETAS.ChildScreens;
using HELVETAS.Data;
using HELVETAS.lncludes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELVETAS.Screens
{
    public partial class AddUser : Form
    {

        private readonly UserListForm userListForm;
        private string id_user;
        private string text_button;
        private string type_current_user;

        public AddUser(UserListForm userList, string id, string text_button, string type_current_user)
        {
            InitializeComponent();

            userListForm = userList;

            this.id_user = id;
            this.text_button = text_button;
            this.type_current_user = type_current_user;

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void AddUser_Shown(object sender, EventArgs e)
        {
            if (this.id_user != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_user);
                create_user_btn.Text = "Иваз кардан";
                heder_text.Text = "Иваз кардан";
            }
        }




        private SQLConfiguration sqlConfiguration;

        private void setTextToTextBoxs(string id)
        {
            string sql = "select * from users where id = '" + id + "'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    name_user.Text = dataTable.Rows[0]["name_user"].ToString();
                    surname_user.Text = dataTable.Rows[0]["surname_user"].ToString();
                    login_user.Text = dataTable.Rows[0]["login_user"].ToString();
                    password_user.Text = dataTable.Rows[0]["password_user"].ToString();
                    confirm_password_txt.Text = dataTable.Rows[0]["password_user"].ToString();
                    type_user.Text = dataTable.Rows[0]["type_user"].ToString();
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        
        
        

        private void updateUser(string id)
        {
            string name_user_text = name_user.Text;
            string surname_user_text = surname_user.Text;
            string login_user_text = login_user.Text;
            string password_user_text = password_user.Text;
            string confirm_password_user_text = confirm_password_txt.Text;
            string type_user_text = type_user.Text;

            string sql_user_check = "select * from users where login_user = '" + login_user_text + "'";

            string sql_update_user = "update users set " +
                "name_user = '" + name_user_text + "', " +
                "surname_user = '" + surname_user_text + "', " +
                "login_user = '" + login_user_text + "', " +
                "password_user = '" + password_user_text + "', " +
                "type_user = '" + type_user_text + "' " + 
                " where id = '" + id + "'";



            if (UserData.type_user == "Админ")
            {
                if (name_user_text.Trim() != "" &&
                    surname_user_text.Trim() != "" &&
                    login_user_text.Trim() != "" &&
                    password_user_text.Trim() != "" &&
                    confirm_password_user_text.Trim() != "" &&
                    type_user_text.Trim() != "")
                {
                    if (password_user_text == confirm_password_user_text)
                    {
                        if (type_user_text == "Админ" && this.type_current_user == "Админ")
                        {
                            DataTable result_login = sqlConfiguration.sqlSelectQuery(sql_user_check);

                            int count = result_login.Rows.Count;

                            if (count == 0)
                            {
                                int result = sqlConfiguration.sqlQuery(sql_update_user);
                                
                                if (result == 500)
                                {
                                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    sqlConfiguration.saveActionDate("5");
                                    this.Close();
                                    userListForm.display();
                                    MessageBox.Show("Маълумотхои коргар бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                            else
                            {
                                string id_result = result_login.Rows[0]["id"].ToString();

                                if (id_result == id)
                                {
                                    int result = sqlConfiguration.sqlQuery(sql_update_user);
                                    if (result == 500)
                                    {
                                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        sqlConfiguration.saveActionDate("5");
                                        this.Close();
                                        userListForm.display();
                                        MessageBox.Show("Маълумотхои коргар бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    }
                                }
                                else
                                {
                                    message_txt.Text = "Чунин логин дар система сабт шудааст. Логини дигар интихоб кунед!";
                                }
                            }
                        }
                        else if (type_user_text == "Коргар" && this.type_current_user == "Админ")
                        {
                            message_txt.Text = "Пеш аз админро коргар кардан, админи нав интихоб кунед!";
                        }
                        else if (type_user_text == "Админ" && this.type_current_user == "Коргар")
                        {
                            message_txt.Text = "Дар система танхо як админ буда метавонад!";
                        }
                        else
                        {
                            DataTable result_login = sqlConfiguration.sqlSelectQuery(sql_user_check);
                            
                            int count = result_login.Rows.Count;

                            if (count == 0)
                            {
                                int result = sqlConfiguration.sqlQuery(sql_update_user);
                                if (result == 500)
                                {
                                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    sqlConfiguration.saveActionDate("5");
                                    this.Close();
                                    userListForm.display();
                                    MessageBox.Show("Маълумотхои коргар бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                            else
                            {
                                string id_result = result_login.Rows[0]["id"].ToString();

                                if (id_result == id)
                                {
                                    int result = sqlConfiguration.sqlQuery(sql_update_user);
                                    if (result == 500)
                                    {
                                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        sqlConfiguration.saveActionDate("5");
                                        this.Close();
                                        userListForm.display();
                                        MessageBox.Show("Маълумотхои коргар бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    }
                                }
                                else
                                {
                                    message_txt.Text = "Чунин логин дар система сабт шудааст. Логини дигар интихоб кунед!";
                                }
                            }
                        }
                    }
                    else
                    {
                        message_txt.Text = "Рамзхо ба хам мувофик нестанд!";
                    }
                }
                else
                {
                    message_txt.Text = "Пур кардани хамаи сатрхо хатми аст!";
                    //MessageBox.Show("Пур кардани хамаи сатрхо хатми аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                message_txt.Text = "Танхо админ ичозати иваз кардан дорад!";
                MessageBox.Show("Танхо админ коргар илова карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }


        private void addUser()
        {
            string name_user_text = name_user.Text;
            string surname_user_text = surname_user.Text;
            string login_user_text = login_user.Text;
            string password_user_text = password_user.Text;
            string confirm_password_user_text = confirm_password_txt.Text;
            string type_user_text = type_user.Text;

            string sql_user_check = "select * from users where login_user = '" + login_user_text + "'";

            string sql_add_user = "insert into users (name_user, surname_user, login_user, password_user, type_user) values('" +
                name_user_text + "', '" +
                surname_user_text + "', '" +
                login_user_text + "', '" +
                password_user_text + "', '" +
                type_user_text + "');";



            if (UserData.type_user == "Админ")
            {
                if (name_user_text.Trim() != "" &&
                    surname_user_text.Trim() != "" &&
                    login_user_text.Trim() != "" &&
                    password_user_text.Trim() != "" &&
                    confirm_password_user_text.Trim() != "" &&
                    type_user_text.Trim() != "")
                {
                    if (password_user_text == confirm_password_user_text)
                    {
                        if (type_user_text != "Админ")
                        {
                            if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count == 0)
                            {
                                int result = sqlConfiguration.sqlQuery(sql_add_user);
                                if (result == 500)
                                {
                                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    this.Close();
                                    userListForm.display();
                                    MessageBox.Show("Коргар бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    sqlConfiguration.saveActionDate("3");
                                }
                            }
                            else
                            {
                                message_txt.Text = "Чунин логин дар система вучуд дорад! Логини дигар интихоб кунед!";
                                //MessageBox.Show("Чунин логин дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else
                        {
                            message_txt.Text = "Дар система танхо як админ буда метавонад!";
                            //MessageBox.Show("Дар система танхо як админ буда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        message_txt.Text = "Рамзхо ба хам мувофик нестанд!";
                        //MessageBox.Show("Рамзхо ба хам мувофик нестанд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    message_txt.Text = "Пур кардани хамаи сатрхо хатми аст!";
                    //MessageBox.Show("Пур кардани хамаи сатрхо хатми аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                message_txt.Text = "Танхо админ коргар илова карда метавонад!";
                //MessageBox.Show("Танхо админ коргар илова карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }


        private void close__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_user_btn_Click(object sender, EventArgs e)
        {
            if (this.id_user == "" && this.text_button == "Сохтан")
            {
                addUser();
            }
            else
            {
                updateUser(this.id_user);
            }
        }
    }
}

