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
    public partial class add_trade_form : Form
    {
        technical_master master_obj;
        public add_trade_form()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            master_obj = new technical_master();
            master_obj.save_trade_details(trade_id_txt,trade_name_txt,trade_duration_txt,trade_fees_txt);
        }

        private void add_trade_form_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trade_name_txt.Enabled = true;
            trade_name_txt.ReadOnly = false;
            trade_duration_txt.Enabled = true;
            trade_duration_txt.ReadOnly = false;
            trade_fees_txt.Enabled = true;
            trade_fees_txt.ReadOnly = false;
            master_obj = new technical_master();
            master_obj.get_serial(trade_id_txt);
        }
    }
}
