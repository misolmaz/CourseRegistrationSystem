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
    public partial class CreateClassFrm : Form
    {
        public CreateClassFrm()
        {
            InitializeComponent();
        }

        private void CreateClassFrm_Load(object sender, EventArgs e)
        {

            CrsEntities context = new CrsEntities();
            List<course> list = context.course.ToList();
            cmbCourses.DataSource = list;
            cmbCourses.ValueMember = "id";
            cmbCourses.DisplayMember = "name";
            listClasses();
            txtStartDate.Text = DateTime.Now.ToShortDateString();

        }

        private void listClasses()
        {

            CrsEntities context = new CrsEntities();

            dgwList.DataSource = context.classesSet.ToList();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            classes cls = new classes();
            CrsEntities context = new CrsEntities();

            cls.cid = (int)cmbCourses.SelectedValue;
            cls.sdate = Convert.ToDateTime(txtStartDate.Text);


            try
            {
                context.classesSet.Add(cls);
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
            listClasses();

        
   
        }
    }
}
