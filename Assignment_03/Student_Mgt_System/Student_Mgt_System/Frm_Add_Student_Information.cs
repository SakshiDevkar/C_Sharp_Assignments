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
    public partial class Frm_Add_Student_Information : Form
    {
        public Frm_Add_Student_Information()
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

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                /// Max Roll_No

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Roll_No) from Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

                // Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "01-06-2007";
            cmb_Course.SelectedIndex = -1;
        }

        private void Frm_Add_Student_Information_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details Values(@RNo, @Nm, @MobNo, @DOB, @Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

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
