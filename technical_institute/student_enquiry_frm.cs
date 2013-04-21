using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace technical_institute
{
    public partial class student_enquiry_frm : Form
    {
        technical_master master_obj;
        //SqlConnectionStringBuilder bldr;
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataReader reader;
        
        public student_enquiry_frm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            master_obj = new technical_master();
            master_obj.load_trade_name(trade_combo);
           

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            master_obj = new technical_master();
            master_obj.get_enquiry_id(enquiry_id_txt);
            student_name_txt.Enabled = true;
            student_name_txt.ReadOnly = false;
            address_txt.Enabled = true;
            address_txt.ReadOnly = false;
            contact_txt.Enabled = true;
            contact_txt.ReadOnly = false;
            trade_combo.Enabled = true;
            gender_combo.Enabled = true;
            education_txt.Enabled = true;
            education_txt.ReadOnly = false;
            enquiry_date_picker.Enabled = true;
            email_id_txt.Enabled = true;
            email_id_txt.ReadOnly = false;
            save_btn.Enabled = true;



        }


        private void button2_Click(object sender, EventArgs e)
        {
            master_obj.db_connect();
            master_obj.save_student_enquary(enquiry_id_txt,student_name_txt , address_txt, contact_txt, trade_combo, gender_combo, education_txt, enquiry_date_picker, email_id_txt);
        
        }

        private void trade_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
