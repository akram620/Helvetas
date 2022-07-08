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
    public partial class LoginUsersListDialog : Form
    {
        public LoginUsersListDialog()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        bool usePic = false;

        private void close__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginUsersListDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void display(int withDate)
        {
            string date = datePicker.Value.Year + "-" + datePicker.Value.Month + "-" + datePicker.Value.Day;

            string sqlWithoutDate = "select t.id, u.name_user, u.surname_user, u.type_user, a.action, DATE_FORMAT(t.date, '%Y-%m-%d') date, t.time " +
                            "from helvetas_ob.users u, helvetas_ob.time_users t, helvetas_ob.actions a " +
                            "where u.id = t.id_user and t.action_user = a.id and concat(u.name_user, ' ', u.surname_user, ' ', a.action, ' ', t.date, ' ', t.time) like '%" + textBoxSearchName.Text + "%' " +
                            "order by t.date desc, t.time desc";


            string sqlWithDate = "select t.id, u.name_user, u.surname_user, u.type_user, a.action, DATE_FORMAT(t.date, '%Y-%m-%d') date, t.time " +
                            "from helvetas_ob.users u, helvetas_ob.time_users t, helvetas_ob.actions a " +
                            "where u.id = t.id_user and t.action_user = a.id and concat(u.name_user, ' ', u.surname_user, ' ', a.action, ' ', t.date, ' ', t.time) like '%" + textBoxSearchName.Text + "%' and t.date = '" + date + "'" +
                            "order by t.date desc, t.time desc";
            
           

            if (withDate == 1)
            {
                if (usePic)
                {
                    sqlConfiguration.displayList(sqlWithDate, dataGridViewUsers);
                }
                else
                {
                    sqlConfiguration.displayList(sqlWithoutDate, dataGridViewUsers);
                }
            }
            else
            {
                sqlConfiguration.displayList(sqlWithoutDate, dataGridViewUsers);
            }
        }

        private void LoginUsersListDialog_Shown(object sender, EventArgs e)
        {
            datePicker.Enabled = false;
            display(0);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            display(1);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            display(1);
        }

        private void useCalendar_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            usePic = e.Checked;
            datePicker.Enabled = e.Checked;
            display(1);
        }
        

        private void all_list_btn_Click_1(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";
            usePic = false;
            display(1);
        }
    }
}
