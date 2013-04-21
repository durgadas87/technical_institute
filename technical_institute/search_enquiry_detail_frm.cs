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
    public partial class search_enquiry_detail_frm : Form
    {
        technical_master master_obj;
        public search_enquiry_detail_frm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_enquiry_detail_frm_Load(object sender, EventArgs e)
        {
            master_obj = new technical_master();
            master_obj.load_trade_name(trade_combo);
            by_date_picker.Enabled = false;
            by_month_combo.Enabled = false;
            by_month_year_combo.Enabled = false;
            by_year_combo.Enabled = false;
            for (int i = 1980; i <= 2100; i++)
            {
                by_month_year_combo.Items.Add("" + i);

            }
            for (int i = 1; i <= 12; i++)
            {
                by_month_combo.Items.Add("" + i);
            }
            for (int i = 1980; i <= 2100; i++)
            {
                by_year_combo.Items.Add("" + i);

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
            
                by_year_combo.Enabled = true;
            }
            else
            {
                by_year_combo.Items.Add("");
                by_year_combo.SelectedItem = "";
                by_year_combo.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                by_month_combo.Enabled = true;
                by_month_year_combo.Enabled = true;
            }
            else
            {
                by_month_combo.Items.Add("");
                by_month_combo.SelectedItem = "";
                by_month_year_combo.Items.Add("");
                by_month_year_combo.SelectedItem = "";
                by_month_year_combo.Enabled = false;
                by_month_combo.Enabled = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                by_date_picker.Enabled = true;
            }
            else
            {
                by_date_picker.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            master_obj.search_student_enquiry(trade_combo,by_year_combo,by_month_combo,by_month_year_combo,by_date_picker,radioButton1,radioButton2,radioButton3,dataGridView1);
        }
    }
}
