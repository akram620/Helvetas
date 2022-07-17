using HELVETAS.Data;
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

namespace HELVETAS.ChildScreens.Journals
{
    public partial class ChooseElectricityJournalForm : Form
    {
        public ChooseElectricityJournalForm()
        {
            InitializeComponent();
        }

        SQLConfiguration sqlConfiguration;
        ElectricityJournalDialog electricityJournalDialog;

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
            string sql = "select * from name_electricity_journal";
            sqlConfiguration.displayList(sql, dataGridView);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(dataGridView.Rows[e.RowIndex].Cells[3].Value + "", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (e.ColumnIndex == delete_btn.Index)
            {
                if (StaticData.type_user == "Админ")
                {
                    electricityJournalDialog = new ElectricityJournalDialog(this, id, "", "Нест кардан");
                    electricityJournalDialog.ShowDialog();

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

                    electricityJournalDialog = new ElectricityJournalDialog(this, id, name, "Иваз кардан");
                    electricityJournalDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Танхо админ коргарро иваз карда метавонад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            electricityJournalDialog = new ElectricityJournalDialog(this, "", "", "Илова кардан");
            electricityJournalDialog.ShowDialog();
        }
    }
}
