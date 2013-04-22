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
    public partial class student_registration_updated_frm : Form
    {
        public student_registration_updated_frm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            technical_master obj = new technical_master();
            obj.db_connect();
            //obj.student_personal_info(serial_txt, dateTimePicker1, register_txt, previous_regis_txt, selfname_txt,fname_txt,
            //    father_occupation_combo,lname_txt,ffullname_txt,mother_name_txt,dateTimePicker2,age_txt,gender_combo,
            //    marital_combo,religon_combo,category_combo,cast_txt,sub_caste_txt,aadhar_txt,contact_txt,alternate_txt,email_txt);
        }

        private void student_registration_updated_frm_Load(object sender, EventArgs e)
        {
            //button3.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            technical_master obj = new technical_master();
            obj.db_connect();
            obj.save_student_register_info(serial_txt,register_txt,selfname_txt,fname_txt,lname_txt,ffullname_txt,mother_name_txt,birth_date_picker,age_txt,gender_combo,category_combo,religon_combo,cast_txt,sub_caste_txt,marital_combo,admission_date_picker,father_occupation_combo,aadhar_txt,contact_txt,alternate_txt,email_txt);
        }


        private void button4_Click(object sender, EventArgs e)
        {
           technical_master master_obj = new technical_master();
            master_obj.get_student_id(serial_txt);
            master_obj.get_previous_register_no(previous_regis_txt);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            age_txt.Text = ""+( DateTime.Now.Year - birth_date_picker.Value.Date.Year);
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void register_txt_Layout(object sender, LayoutEventArgs e)
        {

        }
        private void register_txt_Leave(object sender, EventArgs e)
        {
            
            
        }

       
        
    }
}
