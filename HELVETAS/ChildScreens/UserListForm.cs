using Bunifu.UI.WinForms;
using HELVETAS.Data;
using HELVETAS.dialogs;
using HELVETAS.lncludes;
using HELVETAS.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        AddUser addUser;

        ChangeAdminDialog changeAdminDialog;
        LoginUsersListDialog loginUsersListDialog;

        

        private void UserListForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }
        public void display()
        {
            string sql = "select id, name_user, surname_user, type_user from users";

            sqlConfiguration.displayList(sql, dataGridViewUsers);
        }
        

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit_btn.Index)
            {
                if (UserData.type_user == "Админ")
                {
                    string id = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string type_current_user = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();


                    addUser = new AddUser(this, id, "Иваз кардан", type_current_user);
                    addUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }

            if (e.ColumnIndex == delete_btn.Index)
            {
               if (UserData.type_user == "Админ")
                {
                    DialogResult dialogResult = MessageBox.Show("Хамаи амалхои коргар аз руйхат нест мешаванд.\nШумо дар хакикат " + dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value + " " + dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);


                    if (dialogResult == DialogResult.Yes)
                    {
                        string type_current_user = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                        if (type_current_user == "Админ")
                        {
                            MessageBox.Show("Пеш аз нест кардани админ, админро иваз кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string sqlDeleteTime = "delete from time_users where id_user = '" + dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value + "'";
                            string sqlDeleteUser = "delete from users where id = '" + dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value + "'";
                            

                            int res1 = sqlConfiguration.sqlQuery(sqlDeleteTime);
                            int res2 = sqlConfiguration.sqlQuery(sqlDeleteUser);
                            if (res1 == 1 && res2 == 1)
                            {
                                display();
                                MessageBox.Show("Коргар бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                sqlConfiguration.saveActionDate("4");

                            }
                            else
                            {
                                MessageBox.Show("Хатоги хангоми нест кардани коргар!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро нест карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
            }
        }
        

        private void login_list_users_Click_1(object sender, EventArgs e)
        {
            if (UserData.type_user == "Админ")
            {
                loginUsersListDialog = new LoginUsersListDialog();
                loginUsersListDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Танхо админ руйхатро дида метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void change_admin_btn_Click_1(object sender, EventArgs e)
        {
            if (UserData.type_user == "Админ")
            {
                changeAdminDialog = new ChangeAdminDialog(this);
                changeAdminDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Танхо админ коргар илова карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void create_user_btn_Click_1(object sender, EventArgs e)
        {
            if (UserData.type_user == "Админ")
            {
                addUser = new AddUser(this, "", "Сохтан", "");
                addUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Танхо админ коргар илова карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
