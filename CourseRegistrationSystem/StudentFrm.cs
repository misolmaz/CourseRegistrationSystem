using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    public partial class StudentFrm : Form
    {
        int selectId;
        student updates;
        public StudentFrm()
        {
            InitializeComponent();
        }

        private void StudentFrm_Load(object sender, EventArgs e)
        {
            listStudents();
        }

        private void listStudents()
        {

            CrsEntities context = new CrsEntities();

            dgwList.DataSource = context.student.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            student stud = new student();
            CrsEntities context = new CrsEntities();
            stud.name = txtName.Text;
            stud.lastname = txtLastname.Text;
            stud.phone = txtPhone.Text;

            try
            {
                context.student.Add(stud);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            listStudents();
        }

        private void dgwList_SelectionChanged(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            if (dgwList.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwList.SelectedRows[0].Cells[0].Value);

                updates = context.student.Find(selectId);
                txtName.Text = updates.name;
                txtLastname.Text = updates.lastname;
                txtPhone.Text = updates.phone;

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            var matches = from m in context.student
                          where m.name.Contains(txtName.Text)
                          select m;

            dgwList.DataSource = matches.ToList<student>();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();

            updates = context.student.Find(selectId);
            updates.name = txtName.Text;
            updates.lastname = txtLastname.Text;
            updates.phone = txtPhone.Text;
            try
            {
                context.SaveChanges();
                listStudents();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            if (dgwList.SelectedRows.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show("Are You Sure to Delete", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in dgwList.SelectedRows)
                    {

                        int id = Convert.ToInt32(item.Cells[0].Value);
                        context.student.Remove(context.student.Find(id));
                        context.SaveChanges();
                        MessageBox.Show("Deleted.");
                        listStudents();
                    }
                }
                else
                {
                    MessageBox.Show("Can't delete.");

                }

            }
        }
    }
}
