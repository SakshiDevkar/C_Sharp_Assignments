using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Assignment
{
    public partial class Use_CheckBox_CheckListBox : Form
    {
        public Use_CheckBox_CheckListBox()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, LFlag = true;

            if (tb_Employee_Name.Text != "")
            {
                Result += tb_Employee_Name.Text + " is From Department ";
                lbl_Name_Err.Visible = false;
            }
            else
            {
                lbl_Name_Err.Text = "Enter Employee Name";
                lbl_Name_Err.Visible = true;
                Flag = false;
            }

            if (cmb_Employee_Department.Text != "")
            {
                 Result += cmb_Employee_Department.Text;
                 lbl_Dept_Err.Visible = false;
            }
            else
            {
                lbl_Dept_Err.Text = "Select Dept";
                lbl_Dept_Err.Visible = true;
                Flag = false;
            }

            if (rb_Male.Checked == true)
            {
                Result += ", is " + rb_Male.Text + " And He Knows ";
                lbl_Gender_Err.Visible = false;
            }
            else if (rb_Female.Checked == true)
            {
                Result += ", is " + rb_Female.Text + "And She Knows ";
                lbl_Gender_Err.Visible = false;
            }
            else
            {
                lbl_Gender_Err.Text = "Select Gender";
                lbl_Gender_Err.Visible = true;
                Flag = false;
            }

            if (cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + ", ";
                lbl_Lang_Err.Visible = false;
                LFlag = false;
            }
            if (cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + ", ";
                lbl_Lang_Err.Visible = false;
                LFlag = false;
            }
            if (cb_English.Checked == true)
            {
                Result += cb_English.Text + ", ";
                lbl_Lang_Err.Visible = false;
                LFlag = false;
            }
            if (cb_French.Checked == true)
            {
                Result += cb_French.Text + ", ";
                lbl_Lang_Err.Visible = false;
                LFlag = false;
            }
            if(LFlag == true)
            {
                lbl_Lang_Err.Text = "Select Lang";
                lbl_Lang_Err.Visible = true;
                Flag = false;
            }

            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Hobby_Err.Visible = false;
                Result += " And Has Hobbies as ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + " ,";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;
                        }
                        Cnt--;
                    }
                }
            }
            else
            {
                lbl_Hobby_Err.Visible = true;
                Flag = false;
            }

            if (Flag == false)
            {
                lbl_Result_Text.Visible = false;
            }
            else
            {
                lbl_Result_Text.Text = Result;
                lbl_Result_Text.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

            lbl_Result_Text.Visible = false;
        }

    } 
}