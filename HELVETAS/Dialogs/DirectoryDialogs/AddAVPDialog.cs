using HELVETAS.ChildScreens;
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

namespace HELVETAS.dialogs
{
    public partial class AddAVPDialog : Form
    {

        private readonly AVPForm avpForm;
        private string id;
        private string name_avp;
        private string name_district;


        public AddAVPDialog(AVPForm avpForm, string id, string name_avp, string name_district)
        {
            InitializeComponent();


            this.avpForm = avpForm;
            this.name_avp = name_avp;
            this.name_district = name_district;
            this.id = id;
        }

        SQLConfiguration sqlConfiguration;



        private void AddAVPDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();

            if (name_avp != "")
            {
                create_btn.Text = "Иваз кардан";
                header_text.Text = "Иваз кардан";
            }
        }

        private void AddAVPDialog_Shown(object sender, EventArgs e)
        {
            getDistrictsName();

            if (name_avp != "")
            {
                name_avp_txt.Text = name_avp;
                name_district_combo.Text = name_district;
            }
        }



        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private string findIdDistrictByName(string name)
        {
            string sql = "select * from district where name_district = '" + name + "'";
            DataTable data = sqlConfiguration.sqlSelectQuery(sql);

            if (data.Rows.Count == 1)
            {
                string id = data.Rows[0]["id"].ToString();
                string name_district = data.Rows[0]["name_district"].ToString();

                if (name == name_district)
                {
                    return id;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void getDistrictsName()
        {
            string sql = "select * from district";
            DataTable data = sqlConfiguration.sqlSelectQuery(sql);
            

            foreach (DataRow row in data.Rows)
            {
                name_district_combo.Items.Add(row["name_district"]);
            }
        }


        private bool isAVPExist(string name, string id_district_res)
        {
            string sql = "select id, lower(name_avp) name_avp, district_id from avp where name_avp = '" + name + "'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            bool res = false;

            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {

                foreach(DataRow row in dataTable.Rows)
                {
                    if (row["name_avp"].ToString() == name.ToLower() && row["district_id"].ToString() == id_district_res)
                    {
                        res = true;
                        return true;
                    }
                }
                return res;
                
            }

        }

        private void addAVP(string name_avp, string id_district)
        {
            string sql = "insert into avp (name_avp, district_id) values ('" + name_avp + "', '" + id_district + "');";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                avpForm.display();
                this.Close();
                MessageBox.Show("АВП бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакунии АВП!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chageAVP(string id, string name_avp, string id_district)
        {
            string sql = "update avp set name_avp = '" + name_avp + "', district_id = '" + id_district + "' where id = '" + id + "'";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                avpForm.display();
                this.Close();
                MessageBox.Show("АВП бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми ивазкунии АВП!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void create_btn_Click(object sender, EventArgs e)
        {
            string name_avp_res = name_avp_txt.Text;
            string name_dist_res = name_district_combo.Text;
            
            if (name_avp_res != "" && name_dist_res != "")
            {
                string id_district_res = findIdDistrictByName(name_dist_res);

                if (!isAVPExist(name_avp_res, id_district_res))
                {

                    if (id_district_res != null)
                    {
                        if (this.id != "")
                        {
                            chageAVP(this.id, name_avp_res, id_district_res);
                        }
                        else
                        {
                            addAVP(name_avp_res, id_district_res);
                        }
                    }
                    else
                    {
                        result_txt.Text = "Хатоги хангоми ёфтани id - и район!";
                    }

                }
                else
                {
                    result_txt.Text = "Чунин АВП дар система вучуд дорад!";
                }
            }
            else
            {
                result_txt.Text = "Пур кардани сатрхо хатми аст!";
            }
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void name_district_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_avp_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
