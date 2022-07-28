using HELVETAS.ChildScreens.Journals;
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

namespace HELVETAS.Dialogs.ElecricityJournalDialog
{
    public partial class NameJournalsDialog : Form
    {

        SQLConfiguration sqlConfiguration;

        private readonly ChooseJournalsForm chooseJournalsForm;
        private string id;
        private string name;
        private string textInButton;

        public NameJournalsDialog(ChooseJournalsForm chooseJournalsForm, string id, string name, string textInButton)
        {
            InitializeComponent();

            this.chooseJournalsForm = chooseJournalsForm;
            this.id = id;
            this.name = name;
            this.textInButton = textInButton;
        }

        private void ConfirmPasswordAndEditJournalDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();

            heder_text.Text = textInButton;
            delete_btn.Text = textInButton;
            
            if (textInButton == "Иваз кардан" || textInButton == "Илова кардан")
            {
                password_txt.Visible = false;
                name_journal_txt.Visible = true;
                confirm_text.Text = "";
                delete_btn.BackColor = Color.RoyalBlue;
                cancel_btn.ForeColor = Color.Red;
                
                if(textInButton == "Иваз кардан")
                {
                    name_journal_txt.Text = name;
                }
            }
            else
            {
                password_txt.Visible = true;
                name_journal_txt.Visible = false;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void addElectricityJournal()
        {
            string sql = "insert into name_journals (name_journal, id_type) values ('" + name_journal_txt.Text + "', '" + chooseJournalsForm.id_type + "');";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                chooseJournalsForm.display();
                this.Close();
                MessageBox.Show("Журнал бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateElectricityJournal()
        {
            string sql = "update name_journals set name_journal = '" + name_journal_txt.Text + "' where id = '" + this.id + "'";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                chooseJournalsForm.display();
                this.Close();
                MessageBox.Show("Журнал бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteElectricityJournal()
        {
            string sql1 = "delete from electricity_journal where name_id = '" + this.id + "'";
            string sql2 = "delete from name_journals where id = '" + this.id + "'";

            int resultQuery1 = sqlConfiguration.sqlQuery(sql1);
            int resultQuery2 = sqlConfiguration.sqlQuery(sql2);
            
            if (resultQuery1 == 1 && resultQuery1 == 1)
            {
                chooseJournalsForm.display();
                this.Close();
                MessageBox.Show("Журнал бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми несткуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






        private bool isJournalExist()
        {
            string sql = "select * from name_journals where name_journal = '" + name_journal_txt.Text + "' and id_type = '" + chooseJournalsForm.id_type + "'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (textInButton == "Нест кардан")
            {
                if (password_txt.Text == StaticData.password_user)
                {
                    DialogResult dialogResult = MessageBox.Show("Хамаи маълумотхои журнал нест карда мешавад\nИмконияти баргардондани маълумотхо вучуд надорад\nШумо дар хакикат журналро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteElectricityJournal();
                    }
                    else
                    {
                        this.Close();
                    }
                    
                }
                else
                {
                    result_txt.Text = "Рамз нодуруст аст!";
                }
            }
            else
            {
                if (name_journal_txt.Text.Trim() == "")
                {
                    result_txt.Text = "Пур кардани сатр хатми аст!";
                }
                else
                {
                    if (isJournalExist())
                    {
                        result_txt.Text = "Чунин журнал дар система вучуд дорад!";
                    }
                    else
                    {
                        if (textInButton == "Иваз кардан")
                        {
                            updateElectricityJournal();
                        }
                        else
                        {
                            addElectricityJournal();
                        }
                    }
                }
            }

            
        }
    }
    
}
