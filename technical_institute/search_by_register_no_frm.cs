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
    public partial class search_by_register_no_frm : Form
    {
        public search_by_register_no_frm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
         
        }

        private void search_by_register_no_frm_Load(object sender, EventArgs e)
        {
            
           technical_master master_obj = new technical_master();
           master_obj.load_acedamic_year(comboBox2);

        }
    }
}
