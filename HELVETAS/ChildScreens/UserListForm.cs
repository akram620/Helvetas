using Bunifu.UI.WinForms;
using HELVETAS.Data;
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


        private void create_user_btn_Click(object sender, EventArgs e)
        {
            addUser = new AddUser(this, "", "Сохтан", "");
            addUser.ShowDialog();
        }

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

                string id = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                string type_current_user = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();

                
                addUser = new AddUser(this, id, "Иваз кардан", type_current_user);
                addUser.ShowDialog();

            }

            if (e.ColumnIndex == delete_btn.Index)
            {
               

                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value + " " + dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);

                if (dialogResult == DialogResult.Yes)
                {
                    if (UserData.type_user == "Админ")
                    {
                        string type_current_user = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                        if (type_current_user == "Админ")
                        {
                            MessageBox.Show("Пеш аз нест кардани админ, админи нав интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string sql = "delete from users where id = '" + dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value + "'";

                            int res = sqlConfiguration.sqlQuery(sql);
                            if (res == 1)
                            {
                                MessageBox.Show("Коргар бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                                display();
                            }
                            else
                            {
                                MessageBox.Show("Хатоги хангоми нест кардани коргар!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Танхо админ коргарро нест карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }
    }
}
