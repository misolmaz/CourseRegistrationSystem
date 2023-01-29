namespace CourseRegistrationSystem
{
    partial class StudentRegFrm
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
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.ItemHeight = 25;
            this.lstStudent.Location = new System.Drawing.Point(49, 172);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(327, 504);
            this.lstStudent.TabIndex = 0;
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(49, 96);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(322, 33);
            this.cmbCourses.TabIndex = 1;
            this.cmbCourses.SelectedIndexChanged += new System.EventHandler(this.cmbCourses_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(463, 172);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(211, 78);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dgwList
            // 
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(403, 308);
            this.dgwList.Name = "dgwList";
            this.dgwList.RowTemplate.Height = 33;
            this.dgwList.Size = new System.Drawing.Size(685, 368);
            this.dgwList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class";
            // 
            // StudentRegFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwList);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.lstStudent);
            this.Name = "StudentRegFrm";
            this.Text = "StudentRegFrm";
            this.Load += new System.EventHandler(this.StudentRegFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudent;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.Label label1;
    }
}