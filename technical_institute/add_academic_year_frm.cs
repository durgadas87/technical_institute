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
    public partial class add_academic_year_frm : Form
    {
        technical_master master_obj;
        public add_academic_year_frm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void add_academic_year_frm_Load(object sender, EventArgs e)
        {
            start_year_combo.Enabled = false;
            end_year_combo.Enabled = false;
            academic_year_id.Enabled = false;
            academic_year_id.ReadOnly = true;
            master_obj = new technical_master();
            master_obj.load_academic_year(dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_year_combo.Enabled = true;
            //end_year_combo.Enabled = true;
            for (int i = 1980; i <= 2100; i++)
            {
                start_year_combo.Items.Add("" + i);
            }
            master_obj = new technical_master();
            master_obj.get_academic_year_id(academic_year_id);

        }

        private void start_year_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string get_year = start_year_combo.Text;
            if (get_year != "")
            {
                end_year_combo.Text = ""+(int.Parse(get_year)+1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            master_obj = new technical_master();
            master_obj.add_academic_year(start_year_combo, end_year_combo, dataGridView1,academic_year_id);
        }
    }
}
