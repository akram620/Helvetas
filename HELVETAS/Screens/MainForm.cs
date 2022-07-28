using HELVETAS.ChildScreens;
using HELVETAS.ChildScreens.Journals;
using HELVETAS.ChildScreens.Journals.Water;
using HELVETAS.Data;
using HELVETAS.lncludes;
using System;
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
            StaticData.mainForm = this;

            setNameAndType();
        }

        public void setNameAndType()
        {
            name_user_txt.Text = StaticData.name_user;
            type_user_txt.Text = StaticData.type_user;
        }

        
        private void hideMenu()
        {
            panel_menu_journal.Visible = false;
            panel_menu_reference.Visible = false;
        }


        Form activeForm;
        public void openChildForm(Form childForm)
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

        }
        

        private void users_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new UserListForm());
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        




        private void water_journal_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new TypeWaterJournal());
        }

        private void elecricity_journal_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new ChooseJournalsForm(ChooseJournalsForm.ID_ELECRICITY_1));
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void district_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new DistrictForm());
        }

        private void avp_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new AVPForm());
        }

        private void kanal_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new KanalForm());
        }

        private void pump_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new PumpForm());
        }

        

        private void bunifuButton13_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn1_Click_1(object sender, EventArgs e)
        {
            //sqlConfiguration.saveActionDate("2");
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void station_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new StationForm());
        }

        private void dekhkan_btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new FarmForm());
        }
    }
}