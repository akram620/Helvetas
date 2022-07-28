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

namespace HELVETAS.Dialogs.ElecricityJournalDialog
{
    public partial class ChooseDirectoryDialog : Form
    {


        private int CODE;
        private Label label_name;
        private Label label_id;


        SQLConfiguration sqlConfiguration;

        public ChooseDirectoryDialog(int code, Label label_id, Label label_name)
        {
            InitializeComponent();
            

            this.CODE = code;
            this.label_name = label_name;
            this.label_id = label_id;
        }

      
       

        

        private void ChooseDirectoryDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
 
        }

        private void ChooseDirectoryDialog_Shown(object sender, EventArgs e)
        {
            string sql = "";

            if (CODE == AddEditElecricityDialog.DISTRICT_CODE)
            {
                sql = "select id, name_district 'name', SUBSTR(name_district, 0, 0) 'child' from district";
            }
            else if (CODE == AddEditElecricityDialog.AVP_CODE)
            {
                sql = "select a.id 'id', a.name_AVP 'name', d.name_district 'child' from avp a, district d where a.district_id = d.id";
            }
            else if (CODE == AddEditElecricityDialog.STATION_CODE)
            {
                sql = "select s.id 'id', s.name_station 'name', d.name_district 'child' from station s, district d where s.district_id = d.id";
            }

            display(sql);
        }


        private void display(string sql)
        {
            sqlConfiguration.displayList(sql, dataGridView);
        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            

            this.label_name.Text = name;
            this.label_id.Text = id;

            this.Close();
        }
    }
}
