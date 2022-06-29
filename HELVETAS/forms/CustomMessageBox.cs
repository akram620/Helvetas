using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELVETAS.forms
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public string label_txt_info_txt
        {
            get
            {
                return this.label_txt_info.Text;
            }
            set
            {
                this.label_txt_info.Text = value;
            }
        }

        public Image img_info_img
        {
            get
            {
                return this.img_info.Image;
            }
            set
            {
                this.img_info.Image = value;
            }
        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CustomMessageBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
