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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
            menu_deasing();
        }
        private void menu_deasing()
        {
            panel_menu_journal.Visible = false;
            panel_menu_referens.Visible = false;
            //
        }
        private void hide_menu_sub()
        {
            if (panel_menu_journal.Visible == true)
                panel_menu_journal.Visible = false;
            if (panel_menu_referens.Visible == true)
                panel_menu_referens.Visible = false;
        }
        private void show_menu_sub(Panel sub_menu)
        {
            if (sub_menu.Visible == false)
            {
                hide_menu_sub();
                sub_menu.Visible = true;
            }
            else
                sub_menu.Visible = false;
        }


        private void journals_but_m_m_Click(object sender, EventArgs e)
        {
            show_menu_sub(panel_menu_journal);
        }

        private void referens_but_m_m_Click(object sender, EventArgs e)
        {
            show_menu_sub(panel_menu_referens);
        }

        private void main_menu_Load(object sender, EventArgs e)
        {

        }
    }
}