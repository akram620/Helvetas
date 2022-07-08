﻿using HELVETAS.ChildScreens;
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


namespace HELVETAS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            hideMenu();
        }

        SQLConfiguration sqlConfiguration;


        private void MainForm_Shown(object sender, EventArgs e)
        {
            /*int w = Screen.PrimaryScreen.Bounds.Width - 20;
            int h = Screen.PrimaryScreen.Bounds.Height - 20;

            this.Size = new Size(w, h);
            this.Location = new Point(10, 10);*/

            UserData.mainForm = this;

            setNameAndType();
        }

        public void setNameAndType()
        {
            name_user_txt.Text = UserData.name_user;
            type_user_txt.Text = UserData.type_user;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
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
            openChildForm(new UserListForm());
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        




        private void water_jouarnal_but_m_m_Click(object sender, EventArgs e)
        {

        }

        private void elect_journal_but_m_m_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void district_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new DistrictForm());
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn1_Click_1(object sender, EventArgs e)
        {
            sqlConfiguration.saveActionDate("2");
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}