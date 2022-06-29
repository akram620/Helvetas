using HELVETAS.ChildScreens;
using HELVETAS.Data;
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


namespace HELVETAS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            hideMenu();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }




        private void hideMenu()
        {
            panel_menu_journal.Visible = false;
            panel_menu_reference.Visible = false;
        }


        Form activeForm;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_child_all.Controls.Add(childForm);
            this.panel_child_all.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void showMenu(Panel sub_menu)
        {
            if (sub_menu.Visible == false)
            {
                hideMenu();
                sub_menu.Visible = true;
            }
            else
                sub_menu.Visible = false;
        }

        private void referenсу_btn_menu_Click(object sender, EventArgs e)
        {
            showMenu(panel_menu_reference);
        }

        private void journals_btn_menu_Click(object sender, EventArgs e)
        {
            showMenu(panel_menu_journal);
        }

        private void home_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new MainFormMenu());
        }
        

        private void users_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new AddUser());
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            name_type_user_txt.Text = UserData.name_user;
        }
    }
}