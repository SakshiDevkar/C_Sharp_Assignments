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
    public partial class Frm_View_Student_Information : Form
    {
        public Frm_View_Student_Information()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Application_Management_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con_Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con_Close();
            }
        }

        private void Frm_View_Student_Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Application_Management_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Application_Management_DBDataSet.Student_Details);

        }
    }
}
