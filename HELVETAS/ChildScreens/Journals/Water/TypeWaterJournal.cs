using HELVETAS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELVETAS.ChildScreens.Journals.Water
{
    public partial class TypeWaterJournal : Form
    {
        public TypeWaterJournal()
        {
            InitializeComponent();
        }

        private void type_avp_btn_Click(object sender, EventArgs e)
        {
            StaticData.mainForm.openChildForm(new ChooseJournalsForm(ChooseJournalsForm.ID_WATER_AVP));
        }

        private void type_station_btn_Click(object sender, EventArgs e)
        {
            StaticData.mainForm.openChildForm(new ChooseJournalsForm(ChooseJournalsForm.ID_WATER_STATION));
        }

        private void type_counter_btn_Click(object sender, EventArgs e)
        {
            StaticData.mainForm.openChildForm(new ChooseJournalsForm(ChooseJournalsForm.ID_WATER_COUNTAER));
        }
    }
}
