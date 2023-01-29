using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    public partial class CRSMainFrm : Form
    {
        public CRSMainFrm()
        {
            InitializeComponent();
        }

        private void tutoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TutoursFrm tutoursFrm = new TutoursFrm();
            tutoursFrm.Name = "tutoursFrm";
            tutoursFrm.Text = "Tutours";
            if (Application.OpenForms["tutoursFrm"] == null)
            {

                tutoursFrm.Show();
                tutoursFrm.MdiParent = this;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesFrm coursesFrm = new CoursesFrm();
            coursesFrm.Name = "coursesFrm";
            coursesFrm.Text = "Courses";
            if (Application.OpenForms["tutoursFrm"] == null)
            {

                coursesFrm.Show();
                coursesFrm.MdiParent = this;
            }
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentFrm studentFrm = new StudentFrm();
            studentFrm.Name = "studentFrm";
            studentFrm.Text = "Students";
            if (Application.OpenForms["studentFrm"] == null)
            {

                studentFrm.Show();
                studentFrm.MdiParent = this;
            }
        }

        private void creteClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateClassFrm createClassFrm = new CreateClassFrm();
            createClassFrm.Name = "createClassFrm";
            createClassFrm.Text = "Create Class";
            if (Application.OpenForms["createClassFrm"] == null)
            {

                createClassFrm.Show();
                createClassFrm.MdiParent = this;
            }
        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRegFrm studentRegFrm = new StudentRegFrm();
            studentRegFrm.Name = "studentRegFrm";
            studentRegFrm.Text = "Student Registration";
            if (Application.OpenForms["studentRegFrm"] == null)
            {

                studentRegFrm.Show();
                studentRegFrm.MdiParent = this;
            }
        }

        private void addPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPAymentFrm addPAymentFrm = new AddPAymentFrm();
            addPAymentFrm.Name = "studentRegFrm";
            addPAymentFrm.Text = "Add Payment";
            if (Application.OpenForms["studentRegFrm"] == null)
            {

                addPAymentFrm.Show();
                addPAymentFrm.MdiParent = this;
            }
        }

        private void paymentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentListFrm paymentListFrm = new PaymentListFrm();
            paymentListFrm.Name = "paymentListFrm";
            paymentListFrm.Text = "List Payments";
            if (Application.OpenForms["paymentListFrm"] == null)
            {

                paymentListFrm.Show();
                paymentListFrm.MdiParent = this;
            }
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassesListFrm classesListFrm = new ClassesListFrm();
            classesListFrm.Name = "classesListFrm";
            classesListFrm.Text = "List Classes";
            if (Application.OpenForms["classesListFrm"] == null)
            {

                classesListFrm.Show();
                classesListFrm.MdiParent = this;
            }
        }

        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListStudentFrm listStudentFrm = new ListStudentFrm();
            listStudentFrm.Name = "listStudentFrm";
            listStudentFrm.Text = "List Student";
            if (Application.OpenForms["listStudentFrm"] == null)
            {

                listStudentFrm.Show();
                listStudentFrm.MdiParent = this;
            }
        }
    }
}
