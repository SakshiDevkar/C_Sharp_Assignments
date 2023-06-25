namespace Employee_Mgt_System
{
    partial class Frm_View_Employee_List
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
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.lbl_View_Employee_List = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.employee_Mgt_System_DBDataSet = new Employee_Mgt_System.Employee_Mgt_System_DBDataSet();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Mgt_System.Employee_Mgt_System_DBDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(237, 416);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(217, 46);
            this.btn_Add_New_Employee.TabIndex = 1;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // lbl_View_Employee_List
            // 
            this.lbl_View_Employee_List.AutoSize = true;
            this.lbl_View_Employee_List.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Employee_List.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_View_Employee_List.Location = new System.Drawing.Point(151, 22);
            this.lbl_View_Employee_List.Name = "lbl_View_Employee_List";
            this.lbl_View_Employee_List.Size = new System.Drawing.Size(342, 38);
            this.lbl_View_Employee_List.TabIndex = 3;
            this.lbl_View_Employee_List.Text = "View Employee List";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeeDetailsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(45, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(600, 278);
            this.dataGridView.TabIndex = 5;
            // 
            // employee_Mgt_System_DBDataSet
            // 
            this.employee_Mgt_System_DBDataSet.DataSetName = "Employee_Mgt_System_DBDataSet";
            this.employee_Mgt_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Mgt_System_DBDataSet;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Log_Out.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(585, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(104, 35);
            this.btn_Log_Out.TabIndex = 10;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // Frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 491);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_View_Employee_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_Employee_List";
            this.Text = "View Employee List";
            this.Load += new System.EventHandler(this.Frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Label lbl_View_Employee_List;
        private System.Windows.Forms.DataGridView dataGridView;
        private Employee_Mgt_System_DBDataSet employee_Mgt_System_DBDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Mgt_System_DBDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}