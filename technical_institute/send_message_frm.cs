using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmsClient;
using System.Net.Mail;
namespace technical_institute
{
    public partial class send_message_frm : Form
    {
        public send_message_frm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //SendSms sms = new SendSms();
               
                //string status = sms.send("9975211338","3127", "9975211338", "hi");
                //if (status == "1")
                //{
                //    MessageBox.Show("Message Send...");
                //}
                //else if (status == "2")
                //{
                //    MessageBox.Show("No internet connnection available..");
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Login name and password.");
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        
    }
}
