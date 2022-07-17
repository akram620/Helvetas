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
    public partial class KanalDialog : Form
    {

        private readonly KanalForm kanalForm;
        private string id;
        private string name_kanal;
        private string name_district;

        public KanalDialog(KanalForm kanalForm, string id, string name_kanal, string name_district)
        {
            InitializeComponent();

            this.kanalForm = kanalForm;
            this.name_kanal = name_kanal;
            this.name_district = name_district;
            this.id = id;
        }

        SQLConfiguration sqlConfiguration;

        private void KanalDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();

            if (name_kanal != "")
            {
                create_btn.Text = "Иваз кардан";
                header_text.Text = "Иваз кардан";
            }
        }

        private void KanalDialog_Shown(object sender, EventArgs e)
        {
            getDistrictsName();

            if (name_kanal != "")
            {
                name_kanal_txt.Text = name_kanal;
                name_district_combo.Text = name_district;
            }
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


        private bool isKanalExist(string name, string id_district_res)
        {
            string sql = "select id, lower(name_kanal) name_kanal, district_id from kanal where name_kanal = '" + name + "'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            bool res = false;

            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["name_kanal"].ToString() == name.ToLower() && row["district_id"].ToString() == id_district_res)
                    {
                        res = true;
                        return true;
                    }
                }
                return res;

            }

        }

        private void addKanal(string name_kanal, string id_district)
        {
            string sql = "insert into kanal (name_kanal, district_id) values ('" + name_kanal + "', '" + id_district + "');";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                kanalForm.display();
                this.Close();
                MessageBox.Show("Канал бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакунии канал!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void changeKanal(string id, string name_kanal, string id_district)
        {
            string sql = "update kanal set name_kanal = '" + name_kanal + "', district_id = '" + id_district + "' where id = '" + id + "'";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                kanalForm.display();
                this.Close();
                MessageBox.Show("Канал бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми ивазкунии канал!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void create_btn_Click(object sender, EventArgs e)
        {
            string name_kanal_res = name_kanal_txt.Text;
            string name_dist_res = name_district_combo.Text;

            if (name_kanal_res != "" && name_dist_res != "")
            {
                string id_district_res = findIdDistrictByName(name_dist_res);

                if (!isKanalExist(name_kanal_res, id_district_res))
                {

                    if (id_district_res != null)
                    {
                        if (this.id != "")
                        {
                            changeKanal(this.id, name_kanal_res, id_district_res);
                        }
                        else
                        {
                            addKanal(name_kanal_res, id_district_res);
                        }
                    }
                    else
                    {
                        result_txt.Text = "Хатоги хангоми ёфтани id - и район!";
                    }

                }
                else
                {
                    result_txt.Text = "Чунин калан дар система вучуд дорад!";
                }
            }
            else
            {
                result_txt.Text = "Пур кардани сатрхо хатми аст!";
            }
        }











        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
