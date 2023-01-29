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
    public partial class StudentRegFrm : Form
    {
        int selectedIdx;
        public StudentRegFrm()
        {
            InitializeComponent();
        }

        private void StudentRegFrm_Load(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            // List<classes> list = context.classesSet.ToList();

            var result = (from cs in context.classesSet
                              join c in context.course on cs.cid equals c.id
                              
                              select new
                              {
                                  course = c.name,
                                  id = cs.id,
                                //  Title = t.Title,
                                //  EID = e.EID
                              }).ToList();



            cmbCourses.DataSource = result;
   
            cmbCourses.ValueMember = "id";
            cmbCourses.DisplayMember = "course";

            List<student> list = context.student.ToList();
            lstStudent.DataSource = list;

            lstStudent.ValueMember = "id";
            lstStudent.DisplayMember = "name";

            listStudent();
        }


        private void listStudent()
        {
            CrsEntities context = new CrsEntities();
            var result = (from cl in context.classlist
                          join cs in context.classesSet on cl.clid equals cs.id
                          join c in context.course on cs.cid equals c.id
                          join s in context.student on cl.sid equals s.id
                          where cl.clid == selectedIdx
                          select new
                          {
                              id = cs.id,
                              course = c.name,
                              name = s.name,
                              lastName=s.lastname
                              
                           
                          }).ToList();

            dgwList.DataSource = result;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            classlist clist = new classlist();
            CrsEntities context = new CrsEntities();

            clist.clid = (int)cmbCourses.SelectedValue;
            clist.sid = Convert.ToInt32(lstStudent.SelectedValue);


            try
            {
                context.classlist.Add(clist);
                context.SaveChanges();
                MessageBox.Show("Student Added Succesfully");
               //lstStudent.DataSource = null;
               // lstStudent.Items.Remove(lstStudent.SelectedItem);
                lstStudent.Refresh();
                listStudent();
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
            listStudent();

        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                selectedIdx = (int)cmbCourses.SelectedValue;
            } catch (Exception err){
                Console.WriteLine(err.Message);
            }
           // MessageBox.Show(selectedIdx.ToString());
            listStudent();
        }
    }
}
