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
    public partial class search_enquery_detail : Form
    {

        public search_enquery_detail()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void student_info_detail_Load(object sender, EventArgs e)
        {
            //by_month_combo.Hide();

            by_date_picker.Enabled = false;
            by_year_combo.Enabled = false;
            by_month_combo.Enabled = false;
            by_month_year_combo.Enabled = false;
            technical_master master_obj = new technical_master();
            master_obj.load_trade_name(trade_combo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trade_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                technical_master master_obj = new technical_master();
                master_obj.load_acedamic_year(by_year_combo);
                by_year_combo.Enabled = true;
            }
            else
            {
                //by_year_combo.Items.Clear();
                by_year_combo.Items.Add("");
                by_year_combo.SelectedItem = "";
                by_year_combo.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                by_month_combo.Items.Add("1");
                by_month_combo.Items.Add("2");
                by_month_combo.Items.Add("3");
                by_month_combo.Items.Add("4");
                by_month_combo.Items.Add("5");
                for (int i = 1980; i <= 2100; i++)
                {
                    by_month_year_combo.Items.Add("" + i);
                }
                by_month_combo.Enabled = true;
                by_month_year_combo.Enabled = true;

            }
            else
            {
                by_month_combo.Items.Add("");
                by_month_combo.SelectedItem = "";
                by_month_year_combo.Items.Add("");
                by_month_year_combo.SelectedItem = "";
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
            string trade = trade_combo.Text;
            if (radioButton1.Checked == true)
            {
                string by_year = by_year_combo.Text;
                // Massge
            }
            //    else
            //        if (radioButton2.Checked == true)
            //        {
            //            string by_month = by_month_combo.Text;

            //        }
            //        else
            //            if (radioButton3.Checked == true)
            //            {
            //                string by_date = "by_date_picker.Value";
            //            }
            //}

        }
    }
}
