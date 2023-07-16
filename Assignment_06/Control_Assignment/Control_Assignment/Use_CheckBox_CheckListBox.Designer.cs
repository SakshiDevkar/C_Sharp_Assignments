namespace Control_Assignment
{
    partial class Use_CheckBox_CheckListBox
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
            this.lbl_Employee_General_Details = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cmb_Employee_Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.gb_Known_Languages = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Known_Languages = new System.Windows.Forms.Label();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Name_Err = new System.Windows.Forms.Label();
            this.lbl_Dept_Err = new System.Windows.Forms.Label();
            this.lbl_Gender_Err = new System.Windows.Forms.Label();
            this.lbl_Lang_Err = new System.Windows.Forms.Label();
            this.lbl_Hobby_Err = new System.Windows.Forms.Label();
            this.pnl_Output = new System.Windows.Forms.Panel();
            this.lbl_Result_Text = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Languages.SuspendLayout();
            this.pnl_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_General_Details
            // 
            this.lbl_Employee_General_Details.AutoSize = true;
            this.lbl_Employee_General_Details.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_Employee_General_Details.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_General_Details.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Employee_General_Details.Location = new System.Drawing.Point(278, 9);
            this.lbl_Employee_General_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_General_Details.Name = "lbl_Employee_General_Details";
            this.lbl_Employee_General_Details.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_Employee_General_Details.Size = new System.Drawing.Size(433, 58);
            this.lbl_Employee_General_Details.TabIndex = 1;
            this.lbl_Employee_General_Details.Text = "Employee General Details";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Submit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Submit.Location = new System.Drawing.Point(626, 371);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(109, 44);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Reset.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Reset.Location = new System.Drawing.Point(192, 371);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(109, 44);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cmb_Employee_Department
            // 
            this.cmb_Employee_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Department.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Department.FormattingEnabled = true;
            this.cmb_Employee_Department.Items.AddRange(new object[] {
            "R&D",
            "HRD",
            "Testing",
            "Management"});
            this.cmb_Employee_Department.Location = new System.Drawing.Point(277, 178);
            this.cmb_Employee_Department.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Employee_Department.Name = "cmb_Employee_Department";
            this.cmb_Employee_Department.Size = new System.Drawing.Size(277, 26);
            this.cmb_Employee_Department.TabIndex = 12;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(277, 241);
            this.gb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Size = new System.Drawing.Size(277, 53);
            this.gb_Gender.TabIndex = 13;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(184, 33);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(71, 20);
            this.rb_Female.TabIndex = 0;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(8, 26);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(56, 20);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(277, 102);
            this.tb_Employee_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(277, 26);
            this.tb_Employee_Name.TabIndex = 8;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Gender.Location = new System.Drawing.Point(25, 262);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(80, 25);
            this.lbl_Gender.TabIndex = 7;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(25, 176);
            this.lbl_Employee_Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(222, 25);
            this.lbl_Employee_Department.TabIndex = 10;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(25, 100);
            this.lbl_Employee_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(165, 25);
            this.lbl_Employee_Name.TabIndex = 9;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Output.Location = new System.Drawing.Point(25, 468);
            this.lbl_Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(78, 25);
            this.lbl_Output.TabIndex = 16;
            this.lbl_Output.Text = "Output";
            // 
            // gb_Known_Languages
            // 
            this.gb_Known_Languages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gb_Known_Languages.Controls.Add(this.cb_French);
            this.gb_Known_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Known_Languages.Controls.Add(this.cb_English);
            this.gb_Known_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Known_Languages.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Known_Languages.Location = new System.Drawing.Point(826, 100);
            this.gb_Known_Languages.Name = "gb_Known_Languages";
            this.gb_Known_Languages.Size = new System.Drawing.Size(178, 75);
            this.gb_Known_Languages.TabIndex = 19;
            this.gb_Known_Languages.TabStop = false;
            this.gb_Known_Languages.Text = "Known Languages";
            // 
            // cb_French
            // 
            this.cb_French.AccessibleDescription = "";
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(101, 55);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(77, 22);
            this.cb_French.TabIndex = 0;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(101, 19);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(65, 22);
            this.cb_Hindi.TabIndex = 0;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(6, 55);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(78, 22);
            this.cb_English.TabIndex = 0;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(6, 19);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(84, 22);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Hobbies.Location = new System.Drawing.Point(631, 274);
            this.lbl_Hobbies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(89, 25);
            this.lbl_Hobbies.TabIndex = 20;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // lbl_Known_Languages
            // 
            this.lbl_Known_Languages.AutoSize = true;
            this.lbl_Known_Languages.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Languages.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Known_Languages.Location = new System.Drawing.Point(621, 115);
            this.lbl_Known_Languages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Known_Languages.Name = "lbl_Known_Languages";
            this.lbl_Known_Languages.Size = new System.Drawing.Size(182, 25);
            this.lbl_Known_Languages.TabIndex = 21;
            this.lbl_Known_Languages.Text = "Known Languages";
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clb_Hobbies.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Tracking",
            "Gaming",
            "Cooking",
            "Reading"});
            this.clb_Hobbies.Location = new System.Drawing.Point(826, 238);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(178, 130);
            this.clb_Hobbies.TabIndex = 22;
            // 
            // lbl_Name_Err
            // 
            this.lbl_Name_Err.AutoSize = true;
            this.lbl_Name_Err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Name_Err.Location = new System.Drawing.Point(491, 142);
            this.lbl_Name_Err.Name = "lbl_Name_Err";
            this.lbl_Name_Err.Size = new System.Drawing.Size(51, 13);
            this.lbl_Name_Err.TabIndex = 23;
            this.lbl_Name_Err.Text = "Name Err";
            this.lbl_Name_Err.Visible = false;
            // 
            // lbl_Dept_Err
            // 
            this.lbl_Dept_Err.AutoSize = true;
            this.lbl_Dept_Err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Dept_Err.Location = new System.Drawing.Point(496, 208);
            this.lbl_Dept_Err.Name = "lbl_Dept_Err";
            this.lbl_Dept_Err.Size = new System.Drawing.Size(46, 13);
            this.lbl_Dept_Err.TabIndex = 24;
            this.lbl_Dept_Err.Text = "Dept Err";
            this.lbl_Dept_Err.Visible = false;
            // 
            // lbl_Gender_Err
            // 
            this.lbl_Gender_Err.AutoSize = true;
            this.lbl_Gender_Err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Gender_Err.Location = new System.Drawing.Point(484, 308);
            this.lbl_Gender_Err.Name = "lbl_Gender_Err";
            this.lbl_Gender_Err.Size = new System.Drawing.Size(58, 13);
            this.lbl_Gender_Err.TabIndex = 25;
            this.lbl_Gender_Err.Text = "Gender Err";
            this.lbl_Gender_Err.Visible = false;
            // 
            // lbl_Lang_Err
            // 
            this.lbl_Lang_Err.AutoSize = true;
            this.lbl_Lang_Err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Lang_Err.Location = new System.Drawing.Point(957, 180);
            this.lbl_Lang_Err.Name = "lbl_Lang_Err";
            this.lbl_Lang_Err.Size = new System.Drawing.Size(47, 13);
            this.lbl_Lang_Err.TabIndex = 26;
            this.lbl_Lang_Err.Text = "Lang Err";
            this.lbl_Lang_Err.Visible = false;
            // 
            // lbl_Hobby_Err
            // 
            this.lbl_Hobby_Err.AutoSize = true;
            this.lbl_Hobby_Err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Hobby_Err.Location = new System.Drawing.Point(950, 371);
            this.lbl_Hobby_Err.Name = "lbl_Hobby_Err";
            this.lbl_Hobby_Err.Size = new System.Drawing.Size(54, 13);
            this.lbl_Hobby_Err.TabIndex = 27;
            this.lbl_Hobby_Err.Text = "Hobby Err";
            this.lbl_Hobby_Err.Visible = false;
            // 
            // pnl_Output
            // 
            this.pnl_Output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Output.Controls.Add(this.lbl_Result_Text);
            this.pnl_Output.Location = new System.Drawing.Point(135, 468);
            this.pnl_Output.Name = "pnl_Output";
            this.pnl_Output.Size = new System.Drawing.Size(881, 34);
            this.pnl_Output.TabIndex = 28;
            // 
            // lbl_Result_Text
            // 
            this.lbl_Result_Text.AutoSize = true;
            this.lbl_Result_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_Text.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Result_Text.Location = new System.Drawing.Point(12, 9);
            this.lbl_Result_Text.Name = "lbl_Result_Text";
            this.lbl_Result_Text.Size = new System.Drawing.Size(234, 16);
            this.lbl_Result_Text.TabIndex = 0;
            this.lbl_Result_Text.Text = "Output Of Submit Button Appears Here";
            // 
            // Use_CheckBox_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 514);
            this.Controls.Add(this.pnl_Output);
            this.Controls.Add(this.lbl_Hobby_Err);
            this.Controls.Add(this.lbl_Lang_Err);
            this.Controls.Add(this.lbl_Gender_Err);
            this.Controls.Add(this.lbl_Dept_Err);
            this.Controls.Add(this.lbl_Name_Err);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.lbl_Known_Languages);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.gb_Known_Languages);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cmb_Employee_Department);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Employee_General_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Use_CheckBox_CheckListBox";
            this.Text = "Use CheckBox CheckListBox";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Languages.ResumeLayout(false);
            this.gb_Known_Languages.PerformLayout();
            this.pnl_Output.ResumeLayout(false);
            this.pnl_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_General_Details;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmb_Employee_Department;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.GroupBox gb_Known_Languages;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.Label lbl_Known_Languages;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Label lbl_Name_Err;
        private System.Windows.Forms.Label lbl_Dept_Err;
        private System.Windows.Forms.Label lbl_Gender_Err;
        private System.Windows.Forms.Label lbl_Lang_Err;
        private System.Windows.Forms.Label lbl_Hobby_Err;
        private System.Windows.Forms.Panel pnl_Output;
        private System.Windows.Forms.Label lbl_Result_Text;
    }
}