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
    public partial class CoursesFrm : Form
    {
        int selectId;
        course updates;
        public CoursesFrm()
        {
            InitializeComponent();
        }

        private void CoursesFrm_Load(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            List<instructor> list = context.instructor.ToList();
            cmbInstructor.DataSource = list;
            cmbInstructor.ValueMember = "id";
            cmbInstructor.DisplayMember = "name";
            listCourses();
        }

        private void listCourses()
        {

            CrsEntities context = new CrsEntities();

            // List<kullanicilar> ssloc = context.kullanicilar.Where(w => w.rolID == 1).ToList();

            dgwList.DataSource = context.course.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            course crs = new course();
            CrsEntities context = new CrsEntities();

            crs.name = txtName.Text;
            crs.hours = txtHours.Text;
            crs.price = Convert.ToInt32(txtPrice.Text);
            crs.iid = (int)cmbInstructor.SelectedValue;

            try
            {
                context.course.Add(crs);
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
            listCourses();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            var matches = from m in context.course
                          where m.name.Contains(txtName.Text)
                          select m;

            dgwList.DataSource = matches.ToList<course>();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();

            updates = context.course.Find(selectId);
            updates.name = txtName.Text;
            updates.hours = txtHours.Text;
            updates.price =Convert.ToInt32(txtPrice.Text);
            updates.iid =(int) cmbInstructor.SelectedValue;
            try
            {
                context.SaveChanges();
                listCourses();
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

        private void dgwList_SelectionChanged(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            if (dgwList.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwList.SelectedRows[0].Cells[0].Value);

                updates = context.course.Find(selectId);
                txtName.Text = updates.name;
                txtHours.Text = updates.hours;
                txtPrice.Text = updates.price.ToString();
                cmbInstructor.SelectedIndex = cmbInstructor.FindStringExact(updates.instructor.name);




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
                        context.course.Remove(context.course.Find(id));
                        context.SaveChanges();
                        MessageBox.Show("Deleted.");
                        listCourses();
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
