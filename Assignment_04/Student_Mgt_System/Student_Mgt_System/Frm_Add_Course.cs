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
    public partial class Frm_Add_Course : Form
    {
        public Frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Application_Management_DB;Integrated Security=True;Pooling=False");

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

        private void Only_Numberic(object sender, KeyPressEventArgs e)
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
            tb_Course_Id.Clear();
            tb_Course_Name.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Course_Id.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Course_Details Values(@CId,@CNm)";

                Cmd.Parameters.Add("CId", SqlDbType.Int).Value = tb_Course_Id.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = tb_Course_Name.Text;
         
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }
    }
}
