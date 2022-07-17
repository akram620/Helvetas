using HELVETAS.Data;
using HELVETAS.dialogs;
using HELVETAS.lncludes;
using System;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        StationDialog stationDialog;

        private void StationForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void StationForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            string sql = "select t.id, t.name_station name, d.name_district " +
                            "from station t, district d " +
                            "where t.district_id = d.id";

            sqlConfiguration.displayList(sql, dataGridView);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == delete_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {

                    DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataGridView.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);


                    if (dialogResult == DialogResult.Yes)
                    {
                        string id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                        string sql = "delete from station where id = '" + id + "'";

                        int res = sqlConfiguration.sqlQuery(sql);

                        if (res == 1)
                        {
                            display();
                            MessageBox.Show("Амалиёт бо муваффакият анчом ёфт!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            //sqlConfiguration.saveActionDate("4");

                        }
                        else
                        {
                            MessageBox.Show("Хатоги хангоми нест кардан!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Танхо админ ичозати нест кардан дорад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (e.ColumnIndex == edit_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {
                    string id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string name_district = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    stationDialog = new StationDialog(this, id, name, name_district);
                    stationDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ ичозати иваз кардан дорад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            stationDialog = new StationDialog(this, "", "", "");
            stationDialog.ShowDialog();
        }
    }
}
