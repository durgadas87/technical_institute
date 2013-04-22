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
    public partial class search_by_name_frm : Form
    {
        technical_master master_obj;
        public search_by_name_frm()
        {
            InitializeComponent();
        }

        private void search_by_name_frm_Load(object sender, EventArgs e)
        {
            master_obj = new technical_master();
            master_obj.load_acedamic_year(year_combo);
            master_obj.load_trade_name(trade_name_combo);
            for (int i = 1980; i <= 2100; i++)
            {
                year_combo.Items.Add("" + i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            master_obj = new technical_master();
            master_obj.search_by_student_name_function(student_first_name_txt, student_last_name_txt, trade_name_combo, year_combo,dataGridView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
