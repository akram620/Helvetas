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

namespace HELVETAS.dialogs
{
    public partial class ChangeAdminDialog : Form
    {


        private readonly UserListForm userListForm;

        public ChangeAdminDialog(UserListForm userList)
        {
            InitializeComponent();

            userListForm = userList;
        }

        SQLConfiguration sqlConfiguration;


        private void ChangeAdminDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }



        public void display()
        {
            string sql = "select id, name_user, surname_user, type_user from users";

            sqlConfiguration.displayList(sql, dataGridViewAdmin);
        }

        private void ChangeAdminDialog_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = 
                MessageBox.Show("Шумо дар хакикат " + dataGridViewAdmin.Rows[e.RowIndex].Cells[1].Value + " " + dataGridViewAdmin.Rows[e.RowIndex].Cells[2].Value + " - ро админ интихоб кардан мехохед?", 
                "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (dialogResult == DialogResult.Yes)
            {
                string id_selected = dataGridViewAdmin.Rows[e.RowIndex].Cells[0].Value.ToString();

                string sql1 = "update users set type_user = 'Коргар' where id = '" + UserData.id_user + "';";
                string sql2 = "update users set type_user = 'Админ' where id = '" + id_selected + "';";

                if (UserData.id_user != id_selected)
                {
                    if (sqlConfiguration.sqlQuery(sql1) == 1 && sqlConfiguration.sqlQuery(sql2) == 1)
                    {
                        userListForm.display();
                        this.Close();

                        MessageBox.Show("Админ бо муваффакият иваз карда шуд!");
                        UserData.type_user = "Коргар";
                        UserData.mainForm.setNameAndType();
                        sqlConfiguration.saveActionDate("6");

                    }
                    else
                    {
                        MessageBox.Show("Хангоми ивази админ хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    userListForm.display();
                    this.Close();

                    MessageBox.Show("Админ бо муваффакият иваз карда шуд!");
                    sqlConfiguration.saveActionDate("6");
                }
            }
        }


        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
