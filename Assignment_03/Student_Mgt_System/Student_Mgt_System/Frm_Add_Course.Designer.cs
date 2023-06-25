namespace Student_Mgt_System
{
    partial class Frm_Add_Course
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
            this.lbl_Add_Course = new System.Windows.Forms.Label();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.tb_Course_Id = new System.Windows.Forms.TextBox();
            this.lbl_Course_Id = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_Course
            // 
            this.lbl_Add_Course.AutoSize = true;
            this.lbl_Add_Course.Font = new System.Drawing.Font("Candara", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Course.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Add_Course.Location = new System.Drawing.Point(160, 9);
            this.lbl_Add_Course.Name = "lbl_Add_Course";
            this.lbl_Add_Course.Size = new System.Drawing.Size(235, 53);
            this.lbl_Add_Course.TabIndex = 21;
            this.lbl_Add_Course.Text = "Add Course";
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(342, 215);
            this.tb_Course_Name.MaxLength = 50;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(201, 31);
            this.tb_Course_Name.TabIndex = 25;
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Course_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course_Name.Location = new System.Drawing.Point(76, 219);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(119, 24);
            this.lbl_Course_Name.TabIndex = 24;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // tb_Course_Id
            // 
            this.tb_Course_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Id.Location = new System.Drawing.Point(342, 127);
            this.tb_Course_Id.MaxLength = 100;
            this.tb_Course_Id.Name = "tb_Course_Id";
            this.tb_Course_Id.Size = new System.Drawing.Size(201, 31);
            this.tb_Course_Id.TabIndex = 23;
            // 
            // lbl_Course_Id
            // 
            this.lbl_Course_Id.AutoSize = true;
            this.lbl_Course_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Course_Id.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course_Id.Location = new System.Drawing.Point(76, 131);
            this.lbl_Course_Id.Name = "lbl_Course_Id";
            this.lbl_Course_Id.Size = new System.Drawing.Size(89, 24);
            this.lbl_Course_Id.TabIndex = 22;
            this.lbl_Course_Id.Text = "Course Id";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Tan;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Save.Location = new System.Drawing.Point(220, 296);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(93, 44);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // Frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 373);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.tb_Course_Id);
            this.Controls.Add(this.lbl_Course_Id);
            this.Controls.Add(this.lbl_Add_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_Course";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Course;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_Id;
        private System.Windows.Forms.Label lbl_Course_Id;
        private System.Windows.Forms.Button btn_Save;
    }
}