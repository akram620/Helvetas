using HELVETAS.Dialogs.ElecricityJournalDialog;
using HELVETAS.lncludes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens.Journals
{
    public partial class ElectricityJournalForm : Form
    {
        public string NAME_ID;

        public ElectricityJournalForm(string name_id)
        {
            InitializeComponent();

            this.NAME_ID = name_id;
        }

        SQLConfiguration sqlConfiguration;
        AddEditElecricityDialog addEditDialog;

        Dictionary<string, string> dict = new Dictionary<string, string>();



        private void ElectricityJournalForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void ElectricityJournalForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            textBoxSearchName.Text = "";
            string sql = "SELECT j.id 'id', DATE_FORMAT(j.date, '%Y-%m-%d %h:%i') 'date', s.name_station 'station', d.name_district 'district', a.name_avp 'avp', j.indicator_1 'indicator_1', j.indicator_2 'indicator_2', " +
                            "CASE WHEN j.indicator_2 = 0 THEN '✎' else ROUND(j.indicator_2 - j.indicator_1 , 3) END AS 'different' " +
                            "FROM electricity_journal j, station s, district d, avp a " +
                            "where j.station_id = s.id and j.district_id = d.id and j.avp_id = a.id and name_id = '" + NAME_ID + "' " +
                            "order by j.date desc";
            
            sqlConfiguration.displayList(sql, dataGridView);
        }

        public void displaySearchBox()
        {
            string sql = "SELECT j.id 'id', DATE_FORMAT(j.date, '%Y-%m-%d %h:%i') 'date', s.name_station 'station', d.name_district 'district', a.name_avp 'avp', j.indicator_1 'indicator_1', j.indicator_2 'indicator_2', " +
                            "CASE WHEN j.indicator_2 = 0 THEN '✎' else ROUND(j.indicator_2 - j.indicator_1 , 3) END AS 'different' " +
                            "FROM electricity_journal j, station s, district d, avp a " +
                            "where j.station_id = s.id and j.district_id = d.id and j.avp_id = a.id " +
                            "and concat(j.id, DATE_FORMAT(j.date, '%Y-%m-%d %h:%i'), s.name_station, d.name_district, a.name_avp, j.indicator_1, j.indicator_2, j.indicator_2 - j.indicator_1) like '%" + textBoxSearchName.Text + "%' " +
                            "and name_id = '" + NAME_ID + "' " +
                            "order by j.date desc";

            sqlConfiguration.displayList(sql, dataGridView);
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            dict.Clear();
            addEditDialog = new AddEditElecricityDialog(this, AddEditElecricityDialog.MODE_ADD, dict);
            addEditDialog.ShowDialog();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dict["id"] = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            dict["indicator_1"] = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            dict["indicator_2"] = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
           
           
            addEditDialog = new AddEditElecricityDialog(this, AddEditElecricityDialog.MODE_EDIT, dict);
            addEditDialog.ShowDialog();
            

            
        }


        private void textBoxSearchName_TextChanged_1(object sender, EventArgs e)
        {
            displaySearchBox();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
