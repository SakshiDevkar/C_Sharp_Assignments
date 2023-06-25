using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Mgt_System
{
    public partial class Frm_View_Employee_List : Form
    {
        public Frm_View_Employee_List()
        {
            InitializeComponent();
        }

            SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Mgt_System_DB;Integrated Security=True;Pooling=False");

            private void Frm_View_Employee_List_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'employee_Mgt_System_DBDataSet.Employee_Details' table. You can move, or remove it, as needed.
                this.employee_DetailsTableAdapter.Fill(this.employee_Mgt_System_DBDataSet.Employee_Details);

                lbl_Uname.Text = Common_Content.Log_Uname;

            }

            private void btn_Log_Out_Click(object sender, EventArgs e)
            {
                DialogResult Res = (MessageBox.Show("LogOut", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Res == DialogResult.Yes)
                {
                    Frm_Login Obj = new Frm_Login();
                    Obj.Show();
                    this.Hide();
                }
            }

            private void btn_Add_New_Employee_Click(object sender, EventArgs e)
            {
                Frm_Add_New_Employee Obj = new Frm_Add_New_Employee();
                Obj.Show();
                this.Hide();
            }
    }
}
