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
    public partial class FarmDialog : Form
    {

        private readonly FarmForm farmForm;
        private string id;
        private string name_paren;
        private string name_district;

        public FarmDialog (FarmForm farmForm, string id, string name_paren, string name_district)
        {
            InitializeComponent();

            this.farmForm = farmForm;
            this.name_paren = name_paren;
            this.name_district = name_district;
            this.id = id;
        }

        SQLConfiguration sqlConfiguration;

        private void FarmDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();

            if (name_paren != "")
            {
                create_btn.Text = "Иваз кардан";
                header_text.Text = "Иваз кардан";
            }
        }

        private void FarmDialog_Shown(object sender, EventArgs e)
        {
            getDistrictsName();

            if (name_paren != "")
            {
                name_txt.Text = name_paren;
                name_district_combo.Text = name_district;
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

        private bool isItemExist(string name, string id_district_res)
        {
            string sql = "select id, lower(name_farm) name, district_id from dekhkan_farms where name_farm = '" + name + "'";
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
                    if (row["name"].ToString() == name.ToLower() && row["district_id"].ToString() == id_district_res)
                    {
                        res = true;
                        return true;
                    }
                }
                return res;

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


        private void addItem(string name, string id_district)
        {
            string sql = "insert into dekhkan_farms (name_farm, district_id) values ('" + name + "', '" + id_district + "');";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                farmForm.display();
                this.Close();
                MessageBox.Show("Бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void changeItem(string id, string name, string id_district)
        {
            string sql = "update dekhkan_farms set name_farm = '" + name + "', district_id = '" + id_district + "' where id = '" + id + "'";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                farmForm.display();
                this.Close();
                MessageBox.Show("Бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми ивазкуни!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void create_btn_Click(object sender, EventArgs e)
        {
            string name_res = name_txt.Text;
            string name_dist_res = name_district_combo.Text;

            if (name_res != "" && name_dist_res != "")
            {
                string id_district_res = findIdDistrictByName(name_dist_res);

                if (!isItemExist(name_res, id_district_res))
                {

                    if (id_district_res != null)
                    {
                        if (this.id != "")
                        {
                            changeItem(this.id, name_res, id_district_res);
                        }
                        else
                        {
                            addItem(name_res, id_district_res);
                        }
                    }
                    else
                    {
                        result_txt.Text = "Хатоги хангоми ёфтани id - и район!";
                    }

                }
                else
                {
                    result_txt.Text = "Чунин маълумотхо дар система вучуд дорад!";
                }
            }
            else
            {
                result_txt.Text = "Пур кардани сатрхо хатми аст!";
            }
        }
    }
}
