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
    public partial class KanalForm : Form
    {
        public KanalForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        KanalDialog kanalDialog;


        private void KanalForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void KanalForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridViewKanal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == delete_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {

                    DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataGridViewKanal.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);


                    if (dialogResult == DialogResult.Yes)
                    {
                        string id = dataGridViewKanal.Rows[e.RowIndex].Cells[2].Value.ToString();

                        string sql = "delete from kanal where id = '" + id + "'";

                        int res = sqlConfiguration.sqlQuery(sql);

                        if (res == 1)
                        {
                            display();
                            MessageBox.Show("АВП бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            //sqlConfiguration.saveActionDate("4");

                        }
                        else
                        {
                            MessageBox.Show("Хатоги хангоми нест кардани район!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string id = dataGridViewKanal.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string name_avp = dataGridViewKanal.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string name_district = dataGridViewKanal.Rows[e.RowIndex].Cells[4].Value.ToString();

                    kanalDialog = new KanalDialog(this, id, name_avp, name_district);
                    kanalDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void display()
        {
            string sql = "select k.id, k.name_kanal, d.name_district " +
                            "from kanal k, district d " +
                            "where k.district_id = d.id";
            sqlConfiguration.displayList(sql, dataGridViewKanal);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            kanalDialog = new KanalDialog(this, "", "", "");
            kanalDialog.ShowDialog();
        }
    }
}
