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
    public partial class AddDistrictDialog : Form
    {

        private readonly DistrictForm districtForm;
        private string id;
        private string name;

        public AddDistrictDialog(DistrictForm districtForm, string id, string name)
        {
            InitializeComponent();

            this.districtForm = districtForm;
            this.id = id;
            this.name = name;
        }

        SQLConfiguration sqlConfiguration;

        private void AddDistrictDialog_Load(object sender, EventArgs e)
        {
            sqlConfiguration = new SQLConfiguration();
            result_txt.Text = "";

            if (id != "")
            {
                districr_name_txt.Text = name;
                create_btn.Text = "Иваз кардани район";
                heder_text.Text = "Иваз кардан";
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


        private bool isDistrictExist(string name)
        {
            string sql = "select * from district where name_district = '" + name + "'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void addDistrict(string name)
        {
            string sql = "insert into helvetas_ob.district (name_district) values ('" + name + "');";

            int res = sqlConfiguration.sqlQuery(sql);

            if(res == 1)
            {
                districtForm.display();
                this.Close();
                MessageBox.Show("Район бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакунии район!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chageDistrict(string name)
        {
            string sql = "update helvetas_ob.district set name_district = '" + name + "' where id = '" + id + "'";

            int res = sqlConfiguration.sqlQuery(sql);

            if (res == 1)
            {
                districtForm.display();
                this.Close();
                MessageBox.Show("Район бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Хатоги хангоми иловакунии район!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void create_btn_Click(object sender, EventArgs e)
        {
            string name = districr_name_txt.Text;

            if (name.Trim() != "")
            {
                if (isDistrictExist(name))
                {
                    result_txt.Text = "Чунин район дар ситема вучуд дорад!";
                }
                else
                {
                    if (id == "")
                    {
                        addDistrict(name);
                    }
                    else
                    {
                        chageDistrict(name);
                    }
                }
            }
            else
            {
                result_txt.Text = "Номи районро ворид кунед!";
            }
        }


    }
}
