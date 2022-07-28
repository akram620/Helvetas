using HELVETAS.Dialogs.Journals.WaterJournalDialogs;
using HELVETAS.lncludes;
using System;
using System.Data;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens.Journals.Water
{
    public partial class WaterAVPForm : Form
    {
        public string NAME_ID;

        public static int CAN_EDIT = 1;
        public static int CAN_NOT_EDIT = 0;


        DateTime dateTime = DateTime.UtcNow.Date;

        AddEditWaterAVPDialog addEditWaterAVPDialog;

        public WaterAVPForm(string NAME_ID)
        {
            InitializeComponent();

            this.NAME_ID = NAME_ID;
        }

        SQLConfiguration sqlConfiguration;

        private void WaterAVPForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void WaterAVPForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            textBoxSearchName.Text = "";

            string sql = "SELECT j.id 'id', DATE_FORMAT(j.date, '%Y-%m-%d %h:%i') 'date', s.name_station 'station', a.name_avp 'avp', j.indicator_1 'indicator_1', j.indicator_2 'indicator_2', j.indicator_3 'indicator_3', indicator_1 + indicator_2 + indicator_3 'total', j.average_indicator 'average_indicator' " +
                            "FROM water_avp_journal j, station s, district d, avp a " +
                            "where j.station_id = s.id and j.district_id = d.id and j.avp_id = a.id and name_id = '" + NAME_ID + "' " +
                            "order by j.date desc";

            sqlConfiguration.displayList(sql, dataGridView);
        }

        public void displaySearchBox()
        {
            string sql = "SELECT j.id 'id', DATE_FORMAT(j.date, '%Y-%m-%d %h:%i') 'date', s.name_station 'station', a.name_avp 'avp', j.indicator_1 'indicator_1', j.indicator_2 'indicator_2', j.indicator_3 'indicator_3', indicator_1 + indicator_2 + indicator_3 'total', j.average_indicator 'average_indicator' " +
                            "FROM water_avp_journal j, station s, district d, avp a " +
                            "where j.station_id = s.id and j.district_id = d.id and j.avp_id = a.id " +
                            "and concat(j.id, DATE_FORMAT(j.date, '%Y-%m-%d %h:%i'), s.name_station, d.name_district, a.name_avp, j.indicator_1, j.indicator_2, j.average_indicator) like '%" + textBoxSearchName.Text + "%' " +
                            "and name_id = '" + NAME_ID + "' " +
                            "order by j.date desc";

            sqlConfiguration.displayList(sql, dataGridView);
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            displaySearchBox();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            display();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            

            //if (isExistDataToday())
            //{
            //    MessageBox.Show("Дар як руз танхо як бор илова карда мешашад!");
            //}
            //else
            //{
                //object yesterdayIndicator3 = yesterdayDataIndicator3(dateTime.ToString("yyyy-MM-dd HH:mm"));
                addEditWaterAVPDialog = new AddEditWaterAVPDialog(this, "", "", AddEditWaterAVPDialog.MODE_ADD, CAN_EDIT);
                addEditWaterAVPDialog.ShowDialog();
            //}
        }

        public bool isExistDataToday()
        {
            string sql = "select date from water_avp_journal where date like '%" + dateTime.ToString("yyyy-MM-dd") + "%'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            int count = dataTable.Rows.Count;

            if (count == 0)
            {
                return false;
            }
            

            else
            {
                return true;
            }
        }

        


        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string datetime = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            DateTime select_date = DateTime.ParseExact(datetime, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime current_date = dateTime;

            string select_date_str = select_date.ToString("yyyy-MM-dd");
            string current_date_str = current_date.ToString("yyyy-MM-dd");

            select_date = DateTime.ParseExact(select_date_str, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            current_date = DateTime.ParseExact(current_date_str, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            if (select_date == current_date)
            {
                addEditWaterAVPDialog = new AddEditWaterAVPDialog(this, id, datetime, AddEditWaterAVPDialog.MODE_EDIT, CAN_EDIT);
            }
            else
            {
                addEditWaterAVPDialog = new AddEditWaterAVPDialog(this, id, datetime, AddEditWaterAVPDialog.MODE_EDIT, CAN_NOT_EDIT);
            }
            addEditWaterAVPDialog.ShowDialog();
        }
    }
}
