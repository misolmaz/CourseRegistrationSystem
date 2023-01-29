namespace CourseRegistrationSystem
{
    partial class CRSMainFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.courseDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creteClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseDefinationToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // courseDefinationToolStripMenuItem
            // 
            this.courseDefinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutoursToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.courseDefinationToolStripMenuItem.Name = "courseDefinationToolStripMenuItem";
            this.courseDefinationToolStripMenuItem.Size = new System.Drawing.Size(220, 38);
            this.courseDefinationToolStripMenuItem.Text = "Course Defination";
            // 
            // tutoursToolStripMenuItem
            // 
            this.tutoursToolStripMenuItem.Name = "tutoursToolStripMenuItem";
            this.tutoursToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.tutoursToolStripMenuItem.Text = "Tutours";
            this.tutoursToolStripMenuItem.Click += new System.EventHandler(this.tutoursToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.courseToolStripMenuItem.Text = "Courses";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creteClassToolStripMenuItem,
            this.studentRegistrationToolStripMenuItem});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // creteClassToolStripMenuItem
            // 
            this.creteClassToolStripMenuItem.Name = "creteClassToolStripMenuItem";
            this.creteClassToolStripMenuItem.Size = new System.Drawing.Size(330, 38);
            this.creteClassToolStripMenuItem.Text = "Create Class";
            this.creteClassToolStripMenuItem.Click += new System.EventHandler(this.creteClassToolStripMenuItem_Click);
            // 
            // studentRegistrationToolStripMenuItem
            // 
            this.studentRegistrationToolStripMenuItem.Name = "studentRegistrationToolStripMenuItem";
            this.studentRegistrationToolStripMenuItem.Size = new System.Drawing.Size(330, 38);
            this.studentRegistrationToolStripMenuItem.Text = "Student Registration";
            this.studentRegistrationToolStripMenuItem.Click += new System.EventHandler(this.studentRegistrationToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentsToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(129, 38);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addPaymentsToolStripMenuItem
            // 
            this.addPaymentsToolStripMenuItem.Name = "addPaymentsToolStripMenuItem";
            this.addPaymentsToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.addPaymentsToolStripMenuItem.Text = "Add Payments";
            this.addPaymentsToolStripMenuItem.Click += new System.EventHandler(this.addPaymentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentListToolStripMenuItem,
            this.courseListToolStripMenuItem,
            this.studentsToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(107, 38);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // paymentListToolStripMenuItem
            // 
            this.paymentListToolStripMenuItem.Name = "paymentListToolStripMenuItem";
            this.paymentListToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.paymentListToolStripMenuItem.Text = "Payments";
            this.paymentListToolStripMenuItem.Click += new System.EventHandler(this.paymentListToolStripMenuItem_Click);
            // 
            // courseListToolStripMenuItem
            // 
            this.courseListToolStripMenuItem.Name = "courseListToolStripMenuItem";
            this.courseListToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.courseListToolStripMenuItem.Text = "Classes";
            this.courseListToolStripMenuItem.Click += new System.EventHandler(this.courseListToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem1
            // 
            this.studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            this.studentsToolStripMenuItem1.Size = new System.Drawing.Size(268, 38);
            this.studentsToolStripMenuItem1.Text = "Students";
            this.studentsToolStripMenuItem1.Click += new System.EventHandler(this.studentsToolStripMenuItem1_Click);
            // 
            // CRSMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 869);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CRSMainFrm";
            this.Text = "Course Registration System ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem courseDefinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creteClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem1;
    }
}

