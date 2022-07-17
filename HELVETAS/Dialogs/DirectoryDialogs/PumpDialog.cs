using HELVETAS.ChildScreens;
using HELVETAS.lncludes;
using System;
using System.Data;
using System.Windows.Forms;

namespace HELVETAS.dialogs
{
    public partial class PumpDialog : Form
    {

        private readonly PumpForm pumpForm;
        private string id;
        private string name_paren;
        private string name_district;

        public PumpDialog(PumpForm pumpForm, string id, string name_paren, string name_district)
        {
            InitializeComponent();

            this.pumpForm = pumpForm;
            this.name_paren = name_paren;
            this.name_district = name_district;
            this.id = id;
        }

        SQLConfiguration sqlConfiguration;

        private void PumpDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();

            if (name_paren != "")
            {
                create_btn.Text = "Иваз кардан";
                header_text.Text = "Иваз кардан";
            }
        }

        private void PumpDialog_Shown(object sender, EventArgs e)
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

        private bool isPumpExist(string name, string id_district_res)
        {
            string sql = "select id, lower(name_pump) name, district_id from pump_station where name_pump = '" + name + "'";
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


        private void addPump(string name, string id_district)
        {
            string sql = "insert into pump_station (name_pump, district_id) values ('" + name + "', '" + id_district + "');";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                pumpForm.display();
                this.Close();
                MessageBox.Show("Насос бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакунии насос!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void changePump(string id, string name, string id_district)
        {
            string sql = "update pump_station set name_pump = '" + name + "', district_id = '" + id_district + "' where id = '" + id + "'";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                pumpForm.display();
                this.Close();
                MessageBox.Show("Насос бо муваффакият иваз карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми ивазкунии насос!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            string name_res = name_txt.Text;
            string name_dist_res = name_district_combo.Text;

            if (name_res != "" && name_dist_res != "")
            {
                string id_district_res = findIdDistrictByName(name_dist_res);

                if (!isPumpExist(name_res, id_district_res))
                {

                    if (id_district_res != null)
                    {
                        if (this.id != "")
                        {
                            changePump(this.id, name_res, id_district_res);
                        }
                        else
                        {
                            addPump(name_res, id_district_res);
                        }
                    }
                    else
                    {
                        result_txt.Text = "Хатоги хангоми ёфтани id - и район!";
                    }

                }
                else
                {
                    result_txt.Text = "Чунин насос дар система вучуд дорад!";
                }
            }
            else
            {
                result_txt.Text = "Пур кардани сатрхо хатми аст!";
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
    }
}
