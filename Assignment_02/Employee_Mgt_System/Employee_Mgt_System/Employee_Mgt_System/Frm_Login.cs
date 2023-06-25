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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
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

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Login_Details Where Username = @Unm And Password = @Pwd";

            Cmd.Parameters.Add("Unm",SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Content.Log_Uname = "Welcome "+ tb_Username.Text;

                Frm_Add_New_Employee obj = new Frm_Add_New_Employee();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incorrect Username Or Password !!!";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();

            Con_Close();
        }


    }
}
