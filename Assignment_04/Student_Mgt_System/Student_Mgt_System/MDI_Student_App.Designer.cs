namespace Student_Mgt_System
{
    partial class MDI_Student_App
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumFrom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentInformationToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem,
            this.searchStudentDetailsToolStripMenuItem,
            this.viewStudentInformationToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentInformationToolStripMenuItem
            // 
            this.addStudentInformationToolStripMenuItem.Name = "addStudentInformationToolStripMenuItem";
            this.addStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.addStudentInformationToolStripMenuItem.Text = "Add Student Information";
            this.addStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.addStudentInformationToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // searchStudentDetailsToolStripMenuItem
            // 
            this.searchStudentDetailsToolStripMenuItem.Name = "searchStudentDetailsToolStripMenuItem";
            this.searchStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.searchStudentDetailsToolStripMenuItem.Text = "Search Student Details";
            this.searchStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentDetailsToolStripMenuItem_Click);
            // 
            // viewStudentInformationToolStripMenuItem
            // 
            this.viewStudentInformationToolStripMenuItem.Name = "viewStudentInformationToolStripMenuItem";
            this.viewStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.viewStudentInformationToolStripMenuItem.Text = "View Student Information";
            this.viewStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInformationToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.addCourseListToolStripMenuItem});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // addCourseListToolStripMenuItem
            // 
            this.addCourseListToolStripMenuItem.Name = "addCourseListToolStripMenuItem";
            this.addCourseListToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.addCourseListToolStripMenuItem.Text = "Add Course List";
            this.addCourseListToolStripMenuItem.Click += new System.EventHandler(this.addCourseListToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.maximumFrom2ToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // maximumFrom2ToolStripMenuItem
            // 
            this.maximumFrom2ToolStripMenuItem.Name = "maximumFrom2ToolStripMenuItem";
            this.maximumFrom2ToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.maximumFrom2ToolStripMenuItem.Text = "Maximum From 2";
            this.maximumFrom2ToolStripMenuItem.Click += new System.EventHandler(this.maximumFrom2ToolStripMenuItem_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Uname.Location = new System.Drawing.Point(585, 3);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(83, 23);
            this.lbl_Uname.TabIndex = 4;
            this.lbl_Uname.Text = "Username";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(757, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(127, 31);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // MDI_Student_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 567);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Student_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI_Student_App";
            this.Load += new System.EventHandler(this.MDI_Student_App_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumFrom2ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}



