using HELVETAS.Data;
using HELVETAS.dialogs;
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

namespace HELVETAS.ChildScreens
{
    public partial class PumpForm : Form
    {
        public PumpForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        PumpDialog pumpDialog;

        private void PumpForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void PumpForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            string sql = "select t.id, t.name_pump name, d.name_district " +
                            "from pump_station t, district d " +
                            "where t.district_id = d.id";

            sqlConfiguration.displayList(sql, dataGridView);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            pumpDialog = new PumpDialog(this, "", "", "");
            pumpDialog.ShowDialog();
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

                        string sql = "delete from pump_station where id = '" + id + "'";

                        int res = sqlConfiguration.sqlQuery(sql);

                        if (res == 1)
                        {
                            display();
                            MessageBox.Show("Насос бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                    MessageBox.Show("Танхо админ ичозати ивази нест кардан дорад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (e.ColumnIndex == edit_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {
                    string id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string name_district = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    pumpDialog = new PumpDialog(this, id, name, name_district);
                    pumpDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            pumpDialog = new PumpDialog(this, "", "", "");
            pumpDialog.ShowDialog();
        }
    }
}
