﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Assignment
{
    public partial class frm_Windows_Tools : Form
    {
        public frm_Windows_Tools()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void frm_Windows_Tools_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //Harry Form Department testing is Male Candidate ,Prefers shift timing Evening.
            string Result = "";
            bool Flag = false;

            if (tb_Employee_Name.Text != "  " )
            {
                Result = tb_Employee_Name.Text;

                if (cmb_Employee_Department.Text != "  " )
                {
                    Result += " From Department " + cmb_Employee_Department.Text + " is ";

                    if (rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + "  candidate, Prefers shift timing ";
                    }
                    else if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + "  candidate , Prefers shift timing ";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender Of Employee");
                        Flag = true;
                    }

                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + " . ";
                        ;
                    }
                    else if (rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + " . ";
                    }
                    else if (rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + " . ";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Time");
                        Flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee Dept");
                    Flag = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Name Of Employee");
                Flag = true;
            }

            if(Flag == false)
            {
                tb_Output.Text = Result;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            tb_Output.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
        }
    }
}
