using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace technical_institute
{
    class technical_master
    {
        SqlConnectionStringBuilder builder;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public void db_connect()
        {
            try
            {
                builder = new SqlConnectionStringBuilder();
                builder.DataSource = "SHYAM-PC\\SQLEXPRESS";
                builder.InitialCatalog = "technical_institute";
                builder.UserID = "sa";
                builder.Password = "12345";
                con = new SqlConnection(builder.ConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void get_serial(TextBox txt_obj)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select max(trade_id) from trade_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                    string trade_id_var = reader[0].ToString();
                    if (trade_id_var != "")
                        {
                            txt_obj.Text = "" + (Int64.Parse(trade_id_var) + 1);
                        }
                    else
                        {
                            txt_obj.Text = "1";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void save_trade_details(TextBox trade_id_txt,TextBox trade_name_txt,TextBox trade_duration_txt,TextBox trade_fees_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into trade_tbl(trade_id,trade_name) values("+trade_id_txt.Text+",'"+trade_name_txt.Text+"')";
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {

                    cmd.Dispose();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into trade_info_tbl(trade_id,trade_duration,trade_fees) values("+trade_id_txt.Text+",'"+trade_duration_txt.Text+"','"+trade_fees_txt.Text+"')";
                    int j = cmd.ExecuteNonQuery();
                    if (j == 1)
                    {
                        MessageBox.Show("Trade Information Saved...");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void load_trade_name(ComboBox trade_name_combo)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select trade_name from trade_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        trade_name_combo.Items.Add("" + reader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void save_student_enquiry_details(TextBox enquiry_id_txt,TextBox student_name_txt,TextBox address_txt,TextBox contact_txt,ComboBox trade_combo,ComboBox gender_combo,TextBox education_txt,DateTimePicker enquiry_date_picker,TextBox email_id_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into student_enquiry_tbl() values()";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void get_enquiry_id(TextBox enquiry_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select max(enquiry_id) from student_enquiry_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string enquiry_id_var = reader[0].ToString();
                        if (enquiry_id_var != "")
                        {
                            enquiry_txt.Text = "" + (Int64.Parse(enquiry_id_var) + 1);
                        }
                        else
                        {
                            enquiry_txt.Text = "1";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
