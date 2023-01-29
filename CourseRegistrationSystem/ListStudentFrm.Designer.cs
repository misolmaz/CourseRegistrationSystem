namespace CourseRegistrationSystem
{
    partial class ListStudentFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dgwList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search  Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 31);
            this.txtName.TabIndex = 19;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(799, 90);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(171, 74);
            this.btnList.TabIndex = 18;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgwList
            // 
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(12, 204);
            this.dgwList.Name = "dgwList";
            this.dgwList.RowTemplate.Height = 33;
            this.dgwList.Size = new System.Drawing.Size(958, 398);
            this.dgwList.TabIndex = 17;
            // 
            // ListStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dgwList);
            this.Name = "ListStudentFrm";
            this.Text = "ListStudentFrm";
            this.Load += new System.EventHandler(this.ListStudentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgwList;
    }
}