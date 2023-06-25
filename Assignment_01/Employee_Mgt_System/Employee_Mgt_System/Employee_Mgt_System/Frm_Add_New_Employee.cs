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
    public partial class Frm_Add_New_Employee : Form
    {
        public Frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Mgt_System_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Emp_Id.Clear();
            tb_Emp_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "31-12-2009";
            cmb_Designation.SelectedIndex = -1;

            tb_Emp_Id.Focus();
        }

        private void Frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            tb_Emp_Id.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Emp_Id.Text != "" && tb_Emp_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values(@EId, @ENm, @MobNo, @DOB, @Des)";

                Cmd.Parameters.Add("EId", SqlDbType.Int).Value = tb_Emp_Id.Text;
                Cmd.Parameters.Add("ENm", SqlDbType.VarChar).Value = tb_Emp_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            Frm_View_Employee_List Obj = new Frm_View_Employee_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_Login Obj = new Frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
