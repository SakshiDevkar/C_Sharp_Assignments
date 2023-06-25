namespace Employee_Mgt_System
{
    partial class Frm_Add_New_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Add_Employee_Information = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Emp_Id = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.tb_Emp_Id = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Employee_List = new System.Windows.Forms.Button();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Add_Employee_Information
            // 
            this.lbl_Add_Employee_Information.AutoSize = true;
            this.lbl_Add_Employee_Information.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Employee_Information.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Add_Employee_Information.Location = new System.Drawing.Point(105, 31);
            this.lbl_Add_Employee_Information.Name = "lbl_Add_Employee_Information";
            this.lbl_Add_Employee_Information.Size = new System.Drawing.Size(458, 38);
            this.lbl_Add_Employee_Information.TabIndex = 0;
            this.lbl_Add_Employee_Information.Text = "Add Employee Information";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(95, 227);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(99, 24);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Emp_Id
            // 
            this.lbl_Emp_Id.AutoSize = true;
            this.lbl_Emp_Id.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Emp_Id.Location = new System.Drawing.Point(95, 112);
            this.lbl_Emp_Id.Name = "lbl_Emp_Id";
            this.lbl_Emp_Id.Size = new System.Drawing.Size(76, 24);
            this.lbl_Emp_Id.TabIndex = 0;
            this.lbl_Emp_Id.Text = "Emp Id";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_DOB.Location = new System.Drawing.Point(95, 287);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(53, 24);
            this.lbl_DOB.TabIndex = 0;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Designation.Location = new System.Drawing.Point(95, 351);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(110, 24);
            this.lbl_Designation.TabIndex = 0;
            this.lbl_Designation.Text = "Designation";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Emp_Name.Location = new System.Drawing.Point(95, 168);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(106, 24);
            this.lbl_Emp_Name.TabIndex = 0;
            this.lbl_Emp_Name.Text = "Emp Name";
            // 
            // tb_Emp_Id
            // 
            this.tb_Emp_Id.Enabled = false;
            this.tb_Emp_Id.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Id.Location = new System.Drawing.Point(435, 109);
            this.tb_Emp_Id.MaxLength = 100;
            this.tb_Emp_Id.Name = "tb_Emp_Id";
            this.tb_Emp_Id.Size = new System.Drawing.Size(180, 30);
            this.tb_Emp_Id.TabIndex = 1;
            this.tb_Emp_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Navy;
            this.btn_Save.Location = new System.Drawing.Point(269, 442);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 46);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(435, 165);
            this.tb_Emp_Name.MaxLength = 100;
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(180, 30);
            this.tb_Emp_Name.TabIndex = 2;
            this.tb_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(435, 224);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(180, 30);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Location = new System.Drawing.Point(28, 442);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(120, 46);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Employee_List
            // 
            this.btn_Employee_List.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Employee_List.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_List.ForeColor = System.Drawing.Color.Navy;
            this.btn_Employee_List.Location = new System.Drawing.Point(513, 442);
            this.btn_Employee_List.Name = "btn_Employee_List";
            this.btn_Employee_List.Size = new System.Drawing.Size(164, 46);
            this.btn_Employee_List.TabIndex = 8;
            this.btn_Employee_List.Text = "Employee List";
            this.btn_Employee_List.UseVisualStyleBackColor = false;
            this.btn_Employee_List.Click += new System.EventHandler(this.btn_Employee_List_Click);
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "tester",
            "Designer",
            "Developer",
            "Manager"});
            this.cmb_Designation.Location = new System.Drawing.Point(435, 348);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(180, 32);
            this.cmb_Designation.TabIndex = 5;
            this.cmb_Designation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(435, 282);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(180, 30);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Log_Out.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(606, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(104, 35);
            this.btn_Log_Out.TabIndex = 9;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Uname.Location = new System.Drawing.Point(9, 7);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(139, 24);
            this.lbl_Uname.TabIndex = 10;
            this.lbl_Uname.Text = "Logged In User";
            // 
            // Frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 519);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmb_Designation);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Employee_List);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Emp_Name);
            this.Controls.Add(this.tb_Emp_Id);
            this.Controls.Add(this.lbl_Designation);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Emp_Id);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Add_Employee_Information);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.Frm_Add_New_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Employee_Information;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Emp_Id;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.TextBox tb_Emp_Id;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Employee_List;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Uname;
    }
}