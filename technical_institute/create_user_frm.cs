using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace technical_institute
{
    public partial class create_user_frm : Form
    {
        public create_user_frm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            technical_master master_obj = new technical_master();
            master_obj.db_connect();
            master_obj.create_user(user_name_txt,password_txt,conf_password_txt,sec_ques_combo,sec_ans_txt,contact_txt);

        }
    }
}
