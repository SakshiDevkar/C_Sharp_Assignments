using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Mgt_System
{
    public partial class MDI_Student_App : Form
    {
        public MDI_Student_App()
        {
            InitializeComponent();
        }

        private void MDI_Student_App_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Shared_Class.UserName;
        }
       
        private void addStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Student_Information Obj = new Frm_Add_Student_Information();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();

        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Student_Details Obj = new Frm_Update_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void searchStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Search_Student_Details Obj = new Frm_Search_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void viewStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Student_Information Obj = new Frm_View_Student_Information();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                Frm_Login Obj = new Frm_Login();
                Obj.Show();
                this.Hide();
            }
        }
    }
}
