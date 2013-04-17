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
    public partial class admission_short_frm : Form
    {
        SqlConnectionStringBuilder strb;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public admission_short_frm()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                strb = new SqlConnectionStringBuilder();
                strb.DataSource = "SHYAM-PC\\SQLEXPRESS";
                strb.InitialCatalog = "grk_db";
                strb.UserID = "sa";
                strb.Password = "12345";
                con = new SqlConnection(strb.ConnectionString);
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select academic_year from academic_year_tbl";
                reader = cmd.ExecuteReader();
             

                sub_caste_txt.Enabled = false;
                serial_txt.Enabled = false;
                register_txt.Enabled = false;
                this.fname_txt.Enabled = false;
                selfname_txt.Enabled = false;
                lname_txt.Enabled = false;
                address_txt.Enabled = false;
                taluka_txt.Enabled = false;
                district_txt.Enabled = false;
                state_txt.Enabled = false;
                pin_code_txt.Enabled = false;
                contact_txt.Enabled = false;
                gender_combo.Enabled = false;
                birthdate_picker.Enabled = false;
//                standard_combo.Enabled = false;
                current_year_combo.Enabled = false;
                admitdate_picker.Enabled = false;
                religon_combo.Enabled = false;
                cast_txt.Enabled = false;
                category_combo.Enabled = false;
                age_txt.Enabled = false;
                textBox3.Enabled = false;
                strb = new SqlConnectionStringBuilder();
                strb.DataSource = "SHYAM-PC\\SQLEXPRESS";
                strb.InitialCatalog = "grk_db";
                strb.UserID = "sa";
                strb.Password = "12345";
                con = new SqlConnection(strb.ConnectionString);
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select academic_year from academic_year_tbl";
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    current_year_combo.Items.Add("" + reader[0].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error.Message);
            }
            finally
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        int previous_mks_var;
        
        private void button2_Click(object sender, EventArgs e)
        {
        }
        public void clear_data()
        {
            register_txt.Text = "";
            selfname_txt.Text = "";
            fname_txt.Text = "";
            lname_txt.Text = "";
            address_txt.Text = "";
            taluka_txt.Text = "";
            district_txt.Text = "";
            state_txt.Text = "";
            pin_code_txt.Text = "";
            contact_txt.Text = "";
            gender_combo.Text = " ";
            birthdate_picker.Text = "" + DateTime.Today;
            age_txt.Text = "";

            current_year_combo.Text = " ";
            admitdate_picker.Text = "" + DateTime.Today;
           
            gender_combo.Text = " ";
            current_year_combo.Text = " ";
            religon_combo.Text = " ";
            cast_txt.Text = " ";
            sub_caste_txt.Text = " ";
            category_combo.Text = " ";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
      
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox9_Enter(object sender, EventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void groupBox8_Enter(object sender, EventArgs e)
        {
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox7_Enter(object sender, EventArgs e)
        {
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void label18_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void yes_radion_btn_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void no_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pin_code_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && Convert.ToInt32(e.KeyChar) != 8)
            {
                MessageBox.Show("Enter Numeric Only");
                e.Handled = true;
            }
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        public string previous_std_var { get; set; }

        public string previous_academic_year_var { get; set; }

        private void premarks_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdate_picker_Leave(object sender, EventArgs e)
        {
            int current_year = DateTime.Now.Year;
            int birth_year = birthdate_picker.Value.Year;
            int age = current_year - birth_year;
            age_txt.Text = "" + age;
        }

        private void register_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (register_txt.Text != "")
                {
                    strb = new SqlConnectionStringBuilder();
                    strb.DataSource = "SHYAM-PC\\SQLEXPRESS";
                    strb.InitialCatalog = "grk_db";
                    strb.UserID = "sa";
                    strb.Password = "12345";
                    con = new SqlConnection(strb.ConnectionString);
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select register_no from student_tbl where register_no=" + register_txt.Text;
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                       
                        MessageBox.Show("Register number already exist. Please input another number");
                        register_txt.Text = "";
                        register_txt.Focus();
                    }
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void standard_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear_data();
            tabControl1.SelectedIndex = 1;
            age_txt.Enabled = true;
            sub_caste_txt.Enabled = true;
            register_txt.Enabled = true;
            this.fname_txt.Enabled = true;
            selfname_txt.Enabled = true;
            lname_txt.Enabled = true;
            address_txt.Enabled = true;
            taluka_txt.Enabled = true;
            district_txt.Enabled = true;
            state_txt.Enabled = true;
            pin_code_txt.Enabled = true;
            contact_txt.Enabled = true;
            gender_combo.Enabled = true;
            birthdate_picker.Enabled = true;
            //standard_combo.Enabled = true;
            current_year_combo.Enabled = true;
            admitdate_picker.Enabled = true;
            religon_combo.Enabled = true;
            cast_txt.Enabled = true;
            category_combo.Enabled = true;
            textBox3.Enabled = true;
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Title = "Please select image file";
                pictureBox1.ImageLocation = dialog.FileName;
            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
