using HELVETAS.Data;
using HELVETAS.dialogs;
using HELVETAS.lncludes;
using System;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens
{
    public partial class DistrictForm : Form
    {
        public DistrictForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        AddDistrictDialog addDistrictDialog;

        private void DistrictForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void DistrictForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            string sql = "select * from district";
            sqlConfiguration.displayList(sql, dataGridViewDistrict);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addDistrictDialog = new AddDistrictDialog(this, "", "");
            addDistrictDialog.ShowDialog();
        }

        private void dataGridViewDistrict_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == delete_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {

                    DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataGridViewDistrict.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);


                    if (dialogResult == DialogResult.Yes)
                    {
                        string id = dataGridViewDistrict.Rows[e.RowIndex].Cells[2].Value.ToString();

                        string sql = "delete from district where id = '" + id + "'";

                        int res = sqlConfiguration.sqlQuery(sql);

                        if (res == 1)
                        {
                            display();
                            MessageBox.Show("Район бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            sqlConfiguration.saveActionDate("4");

                        }
                        else
                        {
                            MessageBox.Show("Хатоги хангоми нест кардани район!\nРайон дар система истифода шудааст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                   
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (e.ColumnIndex == edit_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {
                    string id = dataGridViewDistrict.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string name = dataGridViewDistrict.Rows[e.RowIndex].Cells[3].Value.ToString();

                    addDistrictDialog = new AddDistrictDialog(this, id, name);
                    addDistrictDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
