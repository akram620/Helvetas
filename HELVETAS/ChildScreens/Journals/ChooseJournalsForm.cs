using HELVETAS.ChildScreens.Journals.Water;
using HELVETAS.Data;
using HELVETAS.Dialogs.ElecricityJournalDialog;
using HELVETAS.lncludes;
using System;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens.Journals
{
    public partial class ChooseJournalsForm : Form
    {

        // ID TYPES
        public static int ID_ELECRICITY_1 = 1;
        public static int ID_WATER_AVP = 2;
        public static int ID_WATER_STATION = 3;
        public static int ID_WATER_COUNTAER = 4;


        public int id_type;

        public ChooseJournalsForm(int id_type)
        {
            InitializeComponent();

            this.id_type = id_type;
        }

        SQLConfiguration sqlConfiguration;
        NameJournalsDialog electricityJournalDialog;

        // journals
        ElectricityJournalForm electricityJournalForm;
        WaterAVPForm waterAVPForm;
        WaterStationForm waterStationForm;
        WaterCounterForm waterCounterForm;

        private void ChooseElectricityJournalForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void ChooseElectricityJournalForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            string sql = "select id, name_journal from name_journals where id_type = '" + id_type + "'";
            sqlConfiguration.displayList(sql, dataGridView);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_journal = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (id_type == ID_ELECRICITY_1)
            {
                electricityJournalForm = new ElectricityJournalForm(id_journal);
                StaticData.mainForm.openChildForm(electricityJournalForm);

            }
            else if (id_type == ID_WATER_AVP)
            {
                waterAVPForm = new WaterAVPForm(id_journal);
                StaticData.mainForm.openChildForm(waterAVPForm);
            }
            else if (id_type == ID_WATER_STATION)
            {
                waterStationForm = new WaterStationForm();
                StaticData.mainForm.openChildForm(waterStationForm);
            }
            else if (id_type == ID_WATER_COUNTAER)
            {
                waterCounterForm = new WaterCounterForm();
                StaticData.mainForm.openChildForm(waterCounterForm);
            }
            

            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (e.ColumnIndex == delete_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {
                    electricityJournalDialog = new NameJournalsDialog(this, id, "", "Нест кардан");
                    electricityJournalDialog.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Танхо админ ичозати нест кардани журналро дорад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (e.ColumnIndex == edit_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {

                    electricityJournalDialog = new NameJournalsDialog(this, id, name, "Иваз кардан");
                    electricityJournalDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ ичозати иваз кардани журналро дорад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            electricityJournalDialog = new NameJournalsDialog(this, "", "", "Илова кардан");
            electricityJournalDialog.ShowDialog();
        }
    }
}
