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
    public partial class AVPForm : Form
    {
        public AVPForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;

        AddAVPDialog addAVPDialog;


        private void AVPForm_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
        }

        private void AVPForm_Shown(object sender, EventArgs e)
        {
            display();
        }





        public void display()
        {
            string sql = "select a.id, a.name_AVP, d.name_district " +
                            "from avp a, district d " +
                            "where a.district_id = d.id";
            sqlConfiguration.displayList(sql, dataGridViewAVP);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addAVPDialog = new AddAVPDialog(this, "", "", "");
            addAVPDialog.ShowDialog();
        }

        private void dataGridViewAVP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == delete_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {

                    DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataGridViewAVP.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);


                    if (dialogResult == DialogResult.Yes)
                    {
                        string id = dataGridViewAVP.Rows[e.RowIndex].Cells[2].Value.ToString();

                        string sql = "delete from avp where id = '" + id + "'";

                        int res = sqlConfiguration.sqlQuery(sql);

                        if (res == 1)
                        {
                            display();
                            MessageBox.Show("АВП бо муваффакият нест карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                            //sqlConfiguration.saveActionDate("4");

                        }
                        else
                        {
                            MessageBox.Show("Хатоги хангоми нест кардани АВП!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string id = dataGridViewAVP.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string name_avp = dataGridViewAVP.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string name_district = dataGridViewAVP.Rows[e.RowIndex].Cells[4].Value.ToString();

                    addAVPDialog = new AddAVPDialog(this, id, name_avp, name_district);
                    addAVPDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
