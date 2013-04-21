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
    public partial class main_form : Form
    {
        private int childFormNumber = 0;

        public main_form()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addTradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      //  privaion_short_frm admission_form = new admission_short_frm();
           // stte void addStudentEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        
            //admissudent_registration_updated_frm admission_form = new student_registration_updated_frm();
            
        private void addStudentEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //abc admission = new abc(); 
        //    admission.Show();
        

        
        } 

        public void studentEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_enquiry_frm frm = new student_enquiry_frm();
            frm.MdiParent = this;
            frm.Show();

        }

        public void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receipt_frm frm = new receipt_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_frm obj = new login_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_user_frm obj = new create_user_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_by_name_frm obj = new search_by_name_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void byTradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_by_trade_frm obj = new search_by_trade_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void byCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_by_city_frm obj = new search_by_city_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void byRegisterNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_by_register_no_frm obj = new search_by_register_no_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
           

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup_db_frm obj = new backup_db_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restore_db_frm obj = new restore_db_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bonafideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_bonafide_frm obj = new print_bonafide_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void receiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            receipt_frm obj = new receipt_frm();
            obj.MdiParent = this;
            obj.Show();

        }

        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_certificate_frm obj = new print_certificate_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void generalRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_general_register_frm obj = new print_general_register_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void marksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_marksheet_frm obj = new print_marksheet_frm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentInfoDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_enquiry_detail_frm frm = new search_enquiry_detail_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addNewSessionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_academic_year_frm frm = new add_academic_year_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_Password ch = new change_Password();
            ch.MdiParent=this;
            ch.Show();

        }

        private void receiptToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            receipt_frm frm = new receipt_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void studentEnquiryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void createUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            create_user_frm frm = new create_user_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void studentInfoDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void addNewSessionInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void userLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login_frm frm = new login_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            change_Password frm = new change_Password();
            frm.MdiParent = this;
            frm.Show();
        }

        private void byNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search_by_name_frm frm = new search_by_name_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void byCityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search_by_city_frm frm = new search_by_city_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void byRegisterNumberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search_by_register_no_frm frm = new search_by_register_no_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void byTradeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search_by_trade_frm frm = new search_by_trade_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void receiptToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            receipt_frm frm = new receipt_frm(); 
            frm.MdiParent = this;
            frm.Show();
        }

        private void bonafideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            print_bonafide_frm frm = new print_bonafide_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void marksheetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            print_marksheet_frm frm = new print_marksheet_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void certificateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            print_certificate_frm frm = new print_certificate_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void generalRegisterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            print_general_register_frm frm = new print_general_register_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void backupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            backup_db_frm frm = new backup_db_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void restoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            restore_db_frm frm = new restore_db_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchEnquiryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_enquiry_detail_frm frm = new search_enquiry_detail_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addNewTradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_trade_form trade_obj = new add_trade_form();
            trade_obj.MdiParent = this;
            trade_obj.Show();
        }

        private void addStudentEnquiryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_enquiry_frm frm = new student_enquiry_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_registration_updated_frm frm = new student_registration_updated_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addNewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_academic_year_frm frm = new add_academic_year_frm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void searchStudentEnquiryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_enquiry_detail_frm frm = new search_enquiry_detail_frm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
