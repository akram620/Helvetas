using HELVETAS.ChildScreens.Journals.Water;
using HELVETAS.Dialogs.ElecricityJournalDialog;
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

namespace HELVETAS.Dialogs.Journals.WaterJournalDialogs
{
    public partial class AddEditWaterAVPDialog : Form
    {

        // for its child(directory)
        public static int DISTRICT_CODE = 1;
        public static int AVP_CODE = 2;
        public static int STATION_CODE = 3;

        // for result in dilogs
        public string DISTRICT_ID = "";
        public string AVP_ID = "";
        public string STATION_ID = "";



        // took in parent
        public static int MODE_ADD = 100;
        public static int MODE_EDIT = 101;
        public int MODE = 100;

        double yesterdayIndicator3Result = 0;


        ChooseDirectoryDialog chooseDirectoryDialog;
        SQLConfiguration sqlConfiguration;


        DateTime dateTime = DateTime.UtcNow.Date;

        WaterAVPForm waterAVPForm;
        string id_record;
        string datetime_record;
        int can_edit;


        double average_indicator;

        public AddEditWaterAVPDialog(WaterAVPForm waterAVPForm, string id, string datetime, int mode, int can_edit)
        {
            InitializeComponent();

            this.waterAVPForm = waterAVPForm;
            this.id_record = id;
            this.datetime_record = datetime;
            this.MODE = mode;
            this.can_edit = can_edit;
        }



        private void AddEditWaterAVPDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void AddEditWaterAVPDialog_Shown(object sender, EventArgs e)
        {
            if (MODE == MODE_ADD)
            {
                setCorrectDate();
                yesterdayIndicator3Result = yesterdayDataIndicator3(getDateInMonthCalendar());
            }
            else if (MODE == MODE_EDIT)
            {
                header_text.Text = "Иваз кардан";
                add_btn.Text = "Иваз кардан";
                comleteFields();
            }

            if (can_edit == WaterAVPForm.CAN_NOT_EDIT)
            {
                correctDate.Checked = true;
                add_btn.Enabled = false;
                add_btn.BackColor = Color.Gray;
            }
            else if (can_edit == WaterAVPForm.CAN_EDIT)
            {
                correctDate.Checked = false;
                add_btn.Enabled = false;
                add_btn.BackColor = Color.Gray;
            }

            if (can_edit == WaterAVPForm.CAN_EDIT)
            {
                yesterdayIndicator3Result = yesterdayDataIndicator3(datetime_record);
                calculateTotal();
            }
        }



        private void comleteFields()
        {
            string sql = "select j.district_id, d.name_district, j.avp_id, a.name_avp, j.station_id, s.name_station, j.indicator_1, j.indicator_2, indicator_3, j.average_indicator " +
                         "from water_avp_journal j, district d, avp a, station s " +
                         "where j.district_id = d.id and j.avp_id = a.id and j.station_id = s.id and j.id = '" + this.id_record + "'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            
            id_district_txt.Text = dataTable.Rows[0]["district_id"].ToString();
            id_avp_txt.Text = dataTable.Rows[0]["avp_id"].ToString();
            id_station_txt.Text = dataTable.Rows[0]["station_id"].ToString();
            
            name_district_txt.Text = dataTable.Rows[0]["name_district"].ToString();
            name_avp_txt_.Text = dataTable.Rows[0]["name_avp"].ToString();
            name_station_txt.Text = dataTable.Rows[0]["name_station"].ToString();
            
            indicator_1_txt.Text = dataTable.Rows[0]["indicator_1"].ToString() + "0";
            indicator_2_txt.Text = dataTable.Rows[0]["indicator_2"].ToString() + "0";
            indicator_3_txt.Text = dataTable.Rows[0]["indicator_3"].ToString() + "0";

            string average_res_str = dataTable.Rows[0]["average_indicator"].ToString();

            average_txt.Text = average_res_str;

            // date
            DateTime datetime_record_date = DateTime.ParseExact(datetime_record, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            monthCalendar.SetDate(datetime_record_date);

            monthCalendar.Enabled = false;

            
            if (can_edit == WaterAVPForm.CAN_NOT_EDIT)
            {
                disableFields();
            }
        }

        private void disableFields()
        {
            monthCalendar.Enabled = false;
            district_combo.Enabled = false;
            avp_combo.Enabled = false;
            station_combo.Enabled = false;
            indicator_1_txt.Enabled = false;
            indicator_2_txt.Enabled = false;
            indicator_3_txt.Enabled = false;
            add_btn.Enabled = false;
            correctDate.Enabled = false;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(MODE == MODE_ADD)
            {
                if (isLastDateCorect())
                {
                    yesterdayIndicator3Result = yesterdayDataIndicator3(getDateInMonthCalendar());
                    calculateTotal();
                }
            }
        }


        private void setCorrectDate()
        {
            string sql = "SELECT DATE_FORMAT(date, '%Y-%m-%d %h:%i') 'date' FROM water_avp_journal order by date desc";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);


            if (dataTable.Rows.Count > 0)
            {
                // last date
                string last_date_str = dataTable.Rows[0]["date"].ToString();
                DateTime last_date = DateTime.ParseExact(last_date_str, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                last_date = last_date.AddDays(1);

                // set date
                monthCalendar.SetDate(last_date);
            }
        }

        private bool isLastDateCorect()
        {
            string sql = "SELECT DATE_FORMAT(date, '%Y-%m-%d %h:%i') 'date' FROM water_avp_journal order by date desc";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                // last date
                string last_date_str = dataTable.Rows[0]["date"].ToString();
                DateTime last_date = DateTime.ParseExact(last_date_str, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                last_date_str = last_date.ToString("yyyy-MM-dd");
                last_date = DateTime.ParseExact(last_date_str, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                // selected date
                DateTime selected_date = DateTime.ParseExact(getDateInMonthCalendar(), "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                selected_date = DateTime.ParseExact(selected_date.ToString("yyyy-MM-dd"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                // curent date
                string curent_date_str = dateTime.ToString("yyyy-MM-dd");
                DateTime curent_date = DateTime.ParseExact(curent_date_str, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                if (selected_date > curent_date)
                {
                    monthCalendar.SetDate(last_date.AddDays(1));
                    MessageBox.Show("selected date > today");
                    return false;
                }
                if (selected_date == last_date)
                {
                    monthCalendar.SetDate(last_date.AddDays(1));
                    MessageBox.Show("selected date is exist");
                    return false;
                }
                if (last_date.AddDays(1) < selected_date)
                {
                    MessageBox.Show("add the " + last_date.AddDays(1).ToString("yyyy-MM-dd"));
                    monthCalendar.SetDate(last_date.AddDays(1));
                    return false;
                }
                if (selected_date < last_date)
                {
                    monthCalendar.SetDate(last_date.AddDays(1));
                    MessageBox.Show("selected date is exist");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        
        
        private double yesterdayDataIndicator3(string datetime)
        {
            try
            {
                DateTime yesterdayDate = DateTime.ParseExact(datetime, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                yesterdayDate = yesterdayDate.AddDays(-1);
                string sql = "select indicator_3 from water_avp_journal where date like '%" + yesterdayDate.ToString("yyyy-MM-dd") + "%'";

                DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
                int count = dataTable.Rows.Count;

                if (count == 0)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(dataTable.Rows[0]["indicator_3"]);
                }
            }
            catch
            {
                MessageBox.Show("Error while formatting date!");
                return 0;
            }
        }



        private void calculateTotal()
        {
            double i_1 = 0;
            double i_2 = 0;
            double i_3 = 0;
            if (indicator_1_txt.Text == "")
            {
                indicator_1_txt.Text = "0";
            }
            if (indicator_2_txt.Text == "")
            {
                indicator_2_txt.Text = "0";
            }
            if (indicator_3_txt.Text == "")
            {
                indicator_3_txt.Text = "0";
            }
            double.TryParse(indicator_1_txt.Text, out i_1);
            double.TryParse(indicator_2_txt.Text, out i_2);
            double.TryParse(indicator_3_txt.Text, out i_3);
            total_indicator_txt.Text = (i_1 + i_2 + i_3).ToString();
            average_indicator = (i_1 + i_2 + i_3 + yesterdayIndicator3Result) / 4;
            average_txt.Text = average_indicator.ToString();
        }

        

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (MODE == MODE_ADD)
            {
                if (isLastDateCorect())
                {
                    addToJournal();
                }
                else
                {
                    res_label.Text = "Таърихи рузро дуруст интихоб намоед!";
                }
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

            string id_district = id_district_txt.Text;
            string id_avp = id_avp_txt.Text;
            string id_station = id_station_txt.Text;


            string indicator_1_res = indicator_1_txt.Text.Trim();
            string indicator_2_res = indicator_2_txt.Text.Trim();
            string indicator_3_res = indicator_3_txt.Text.Trim();

            string resDate = getDateInMonthCalendar();

            if (district_res == "" || avp_res == "" || station_res == "")
            {
                res_label.Text = "Сатрхо дуруст пур намоед!";
            }
            else
            {
                if (indicator_1_res == "")
                {
                    indicator_1_res = "0";
                }
                if (indicator_2_res == "")
                {
                    indicator_2_res = "0";
                }
                if (indicator_3_res == "")
                {
                    indicator_3_res = "0";
                }

                string sql = "insert into water_avp_journal (name_id, date, station_id, district_id, avp_id, indicator_1, indicator_2, indicator_3, average_indicator) values ('" + waterAVPForm.NAME_ID + "', '" + resDate + "', '" + id_station + "', '" + id_district + "', '" + id_avp + "', '" + indicator_1_res + "', '" + indicator_2_res + "', '" + indicator_3_res + "', '" + average_indicator + "');";

                if (sqlConfiguration.sqlQuery(sql) == 1)
                {
                    waterAVPForm.display();
                    sqlConfiguration.saveActionDate("8");
                    MessageBox.Show("Маълумотхо бо муваффакият илова карда шуданд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Хатоги хангоми иловакуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }

        private void editJournal()
        {
            string district_res = name_district_txt.Text.Trim();
            string avp_res = name_avp_txt_.Text.Trim();
            string station_res = name_station_txt.Text.Trim();

            string id_district = id_district_txt.Text;
            string id_avp = id_avp_txt.Text;
            string id_station = id_station_txt.Text;

            string indicator_1_res = indicator_1_txt.Text.Trim();
            string indicator_2_res = indicator_2_txt.Text.Trim();
            string indicator_3_res = indicator_3_txt.Text.Trim();

            if (district_res == "" || avp_res == "" || station_res == "")
            {
                res_label.Text = "Сатрхо дуруст пур намоед!";
            }
            else
            {

                if (indicator_1_res == "")
                {
                    indicator_1_res = "0";
                }
                if (indicator_2_res == "")
                {
                    indicator_2_res = "0";
                }
                if (indicator_3_res == "")
                {
                    indicator_3_res = "0";
                }

                string sql = "update water_avp_journal set station_id = '" + id_station + "', district_id = '" + id_district + "', avp_id = '" + id_avp + "', indicator_1 = '" + indicator_1_res + "', indicator_2 = '" + indicator_2_res + "', indicator_3 = '" + indicator_3_res + "', average_indicator = '" + average_indicator + "' where id = '" + id_record + "';";

                if (sqlConfiguration.sqlQuery(sql) == 1)
                {
                    waterAVPForm.display();
                    sqlConfiguration.saveActionDate("9");
                    MessageBox.Show("Маълумот бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Хатоги хангоми ивазкуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }


            }
        }



        private string getDateInMonthCalendar()
        {
            string year = monthCalendar.SelectionRange.Start.Year.ToString();
            string month = monthCalendar.SelectionRange.Start.Month.ToString();
            string day = monthCalendar.SelectionRange.Start.Day.ToString();

            if (month.Length == 1)
            {
                month = "0" + month;
            }
            if (day.Length == 1)
            {
                day = "0" + day;
            }

            string time = DateTime.Now.ToString("HH:mm");

            return year + "-" + month + "-" + day + " " + time;
        }






























        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void indicator_1_txt_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void indicator_2_txt_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void indicator_3_txt_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void correctDate_CheckedChanged(object sender, EventArgs e)
        {
            add_btn.Enabled = correctDate.Checked;

            if (correctDate.Checked)
            {
                add_btn.BackColor = Color.RoyalBlue;
            }
            else
            {
                add_btn.BackColor = Color.Gray;
            }

        }
        
    }
} 