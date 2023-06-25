namespace Student_Mgt_System
{
    partial class Frm_Course_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Course_List = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_Application_Management_DBDataSet1 = new Student_Mgt_System.Student_Application_Management_DBDataSet1();
            this.courseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_DetailsTableAdapter = new Student_Mgt_System.Student_Application_Management_DBDataSet1TableAdapters.Course_DetailsTableAdapter();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Application_Management_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Course_List
            // 
            this.lbl_Course_List.AutoSize = true;
            this.lbl_Course_List.Font = new System.Drawing.Font("Candara", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_List.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Course_List.Location = new System.Drawing.Point(162, 9);
            this.lbl_Course_List.Name = "lbl_Course_List";
            this.lbl_Course_List.Size = new System.Drawing.Size(244, 53);
            this.lbl_Course_List.TabIndex = 22;
            this.lbl_Course_List.Text = "Courses List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 243);
            this.dataGridView1.TabIndex = 23;
            // 
            // student_Application_Management_DBDataSet1
            // 
            this.student_Application_Management_DBDataSet1.DataSetName = "Student_Application_Management_DBDataSet1";
            this.student_Application_Management_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDetailsBindingSource
            // 
            this.courseDetailsBindingSource.DataMember = "Course_Details";
            this.courseDetailsBindingSource.DataSource = this.student_Application_Management_DBDataSet1;
            // 
            // course_DetailsTableAdapter
            // 
            this.course_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Course_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Course_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Course List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Application_Management_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Course_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Student_Application_Management_DBDataSet1 student_Application_Management_DBDataSet1;
        private System.Windows.Forms.BindingSource courseDetailsBindingSource;
        private Student_Application_Management_DBDataSet1TableAdapters.Course_DetailsTableAdapter course_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}