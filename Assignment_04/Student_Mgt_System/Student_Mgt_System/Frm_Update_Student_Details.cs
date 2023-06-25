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
    public partial class Frm_Update_Student_Details : Form
    {
        public Frm_Update_Student_Details()
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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "01-06-2007";
            cmb_Course.SelectedIndex = -1;
        }

        void Enable_Controls()
        {
            tb_Roll_No.Enabled = false;
            tb_Name.Enabled = true;
            dtp_DOB.Enabled = true;
            tb_Mobile_No.Enabled = true;
            cmb_Course.Enabled = true;
        }

        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            dtp_DOB.Enabled = false;
            tb_Mobile_No.Enabled = false;
            cmb_Course.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Student_Details where Roll_No = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Roll No", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("1st Enter Roll No.", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Student_Details Set Name = @Nm, DOB = @DOB, Mobile_No = @MobNo, Course = @Course where Roll_No = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }


    }

}
