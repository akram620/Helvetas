using HELVETAS.ChildScreens.Journals;
using HELVETAS.lncludes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HELVETAS.Dialogs.ElecricityJournalDialog
{
    public partial class AddEditElecricityDialog : Form
    {

        // for its child(directory)
        public static int DISTRICT_CODE = 1;
        public static int AVP_CODE = 2;
        public static int STATION_CODE = 3;

        // for result in dilogs
        public static string DISTRICT_ID = "";
        public static string AVP_ID = "";
        public static string STATION_ID = "";



        // took in parent
        public static int MODE_ADD = 100;
        public static int MODE_EDIT = 101;
        public static int MODE = 100;

        private Dictionary<string, string> dict;
        


        private readonly ElectricityJournalForm electricityJournalForm;

        public AddEditElecricityDialog(ElectricityJournalForm electricityJournalForm, int mode, Dictionary<string, string> dict)
        {
            InitializeComponent();
            this.electricityJournalForm = electricityJournalForm;

            MODE = mode;
            this.dict = dict;
        }

        ChooseDirectoryDialog chooseDirectoryDialog;
        SQLConfiguration sqlConfiguration;

        private void AddEditDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void AddEditDialog_Shown(object sender, EventArgs e)
        {
            
            if (MODE == MODE_EDIT)
            {
                comleteFields();
                header_text.Text = "Иваз кардан";
                add_btn.Text = "Иваз кардан";
            }
        }



        private void comleteFields()
        {

            string sql = "select j.district_id, d.name_district, j.avp_id, a.name_avp, j.station_id, s.name_station " +
                         "from electricity_journal j, district d, avp a, station s " +
                         "where j.district_id = d.id and j.avp_id = a.id and j.station_id = s.id and j.id = '" + dict["id"] + "'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);


            id_district_txt.Text = dataTable.Rows[0]["district_id"].ToString();
            id_avp_txt.Text = dataTable.Rows[0]["avp_id"].ToString();
            id_station_txt.Text = dataTable.Rows[0]["station_id"].ToString();


            name_district_txt.Text = dataTable.Rows[0]["name_district"].ToString();
            name_avp_txt_.Text = dataTable.Rows[0]["name_avp"].ToString();
            name_station_txt.Text = dataTable.Rows[0]["name_station"].ToString();
            

            indicator_1_txt.Text = dict["indicator_1"] + "0";
            if (dict["indicator_2"] != "0")
            {
                indicator_2_txt.Text = dict["indicator_2"] + "0";
            }
            
            
        }




        private void add_btn_Click(object sender, EventArgs e)
        {
            if (MODE == MODE_ADD)
            {
                addToJournal();
            }
            else if (MODE == MODE_EDIT)
            {
                editJournal();
            }
        }


        private void addToJournal()
        {
            string district_res = name_district_txt.Text.Trim();
            string avp_res = name_avp_txt_.Text.Trim();
            string station_res = name_station_txt.Text.Trim();
            string indicator_1_res = indicator_1_txt.Text.Trim();
            string indicator_2_res = indicator_2_txt.Text.Trim();

            if (district_res == "" || avp_res == "" || station_res == "" || indicator_1_res == "")
            {
                res_label.Text = "Сатрхо дуруст пур намоед!";
            }
            else
            {
                if (indicator_2_res == "")
                {
                    indicator_2_res = "0";

                    string sql = "insert into electricity_journal (name_id, date, station_id, district_id, avp_id, indicator_1, indicator_2) values('" + electricityJournalForm.NAME_ID + "', sysdate(), '" + id_station_txt.Text + "', '" + id_district_txt.Text + "', '" + id_avp_txt.Text + "', '" + indicator_1_res + "', '" + indicator_2_res + "');";

                    if (sqlConfiguration.sqlQuery(sql) == 1)
                    {
                        electricityJournalForm.display();
                        sqlConfiguration.saveActionDate("7");
                        MessageBox.Show("Маълумот бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми иловакуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    if (Convert.ToDouble(indicator_2_res) >= Convert.ToDouble(indicator_1_res))
                    {
                        string sql = "insert into electricity_journal (name_id, date, station_id, district_id, avp_id, indicator_1, indicator_2) values('" + electricityJournalForm.NAME_ID + "', sysdate(), '" + id_station_txt.Text + "', '" + id_district_txt.Text + "', '" + id_avp_txt.Text + "', '" + indicator_1_res + "', '" + indicator_2_res + "');";

                        if (sqlConfiguration.sqlQuery(sql) == 1)
                        {
                            electricityJournalForm.display();
                            sqlConfiguration.saveActionDate("7");
                            MessageBox.Show("Маълумот бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Хатоги хангоми иловакуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else
                    {
                        res_label.Text = "Нишондихандаи дуюм бояд баробар ё калон аз нишондихандаи якум бошад!";
                    }
                }

            }
        }

        private void editJournal()
        {
            string district_res = name_district_txt.Text.Trim();
            string avp_res = name_avp_txt_.Text.Trim();
            string station_res = name_station_txt.Text.Trim();
            string indicator_1_res = indicator_1_txt.Text.Trim();
            string indicator_2_res = indicator_2_txt.Text.Trim();
            
            if (district_res == "" || avp_res == "" || station_res == "" || indicator_1_res == "")
            {
                res_label.Text = "Сатрхо дуруст пур намоед!";
            }
            else
            {
                if (indicator_2_res == "")
                {
                    indicator_2_res = "0";

                    string sql = "update electricity_journal set station_id = '" + id_station_txt.Text + "', district_id = '" + id_district_txt.Text + "', avp_id = '" + id_avp_txt.Text + "', indicator_1 = '" + indicator_1_res + "', indicator_2 = '" + indicator_2_res + "' where id = '" + dict["id"] + "';";

                    if (sqlConfiguration.sqlQuery(sql) == 1)
                    {
                        electricityJournalForm.display();
                        sqlConfiguration.saveActionDate("10");
                        MessageBox.Show("Маълумот бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми ивазкуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    if (Convert.ToDouble(indicator_2_res) >= Convert.ToDouble(indicator_1_res))
                    {
                        string sql = "update electricity_journal set station_id = '" + id_station_txt.Text + "', district_id = '" + id_district_txt.Text + "', avp_id = '" + id_avp_txt.Text + "', indicator_1 = '" + indicator_1_res + "', indicator_2 = '" + indicator_2_res + "' where id = '" + dict["id"] + "';";

                        if (sqlConfiguration.sqlQuery(sql) == 1)
                        {
                            electricityJournalForm.display();
                            sqlConfiguration.saveActionDate("10");
                            MessageBox.Show("Маълумот бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Хатоги хангоми ивазкуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else
                    {
                        res_label.Text = "Нишондихандаи дуюм бояд баробар ё калон аз нишондихандаи якум бошад!";
                    }
                }
            }



            




        }



        private void district_combo_Click(object sender, EventArgs e)
        {
            chooseDirectoryDialog = new ChooseDirectoryDialog(DISTRICT_CODE, id_district_txt, name_district_txt);
            chooseDirectoryDialog.ShowDialog();
        }

        private void avp_combo_Click(object sender, EventArgs e)
        {
            chooseDirectoryDialog = new ChooseDirectoryDialog(AVP_CODE, id_avp_txt, name_avp_txt_);
            chooseDirectoryDialog.ShowDialog();
        }

        private void station_combo_Click(object sender, EventArgs e)
        {
            chooseDirectoryDialog = new ChooseDirectoryDialog(STATION_CODE, id_station_txt, name_station_txt);
            chooseDirectoryDialog.ShowDialog();
        }




        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void indicator_1_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void indicator_2_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
