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
    public partial class AddPAymentFrm : Form
    {
        int selectId;
        int classId;
        student updates;
        public AddPAymentFrm()
        {
            InitializeComponent();
        }

        private void AddPAymentFrm_Load(object sender, EventArgs e)
        {
            listStudent();
        }

        private void listStudent()
        {
            CrsEntities context = new CrsEntities();
            var result = (from s in context.student

                          select new
                          {
                              id = s.id,

                              name = s.name,

                              lastName = s.lastname,

                              phone = s.phone


                          }).ToList();

            dgwList.DataSource = result;

        }

        private void dgwList_SelectionChanged(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            if (dgwList.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwList.SelectedRows[0].Cells[0].Value);

               updates = context.student.Find(selectId);
                txtStudent.Text = updates.name.Trim() + " "+ updates.lastname.Trim();
                txtDate.Text = DateTime.Now.ToShortDateString();



                //  List<classlist> ssloc = context.classlist.Where(w => w.sid == selectId).ToList();

                var result = (from cl in context.classlist
                              
                              join cs in context.classesSet on cl.clid equals cs.id
                              join c in context.course on cs.cid equals c.id

                              where cl.sid== selectId
                              select new
                              {
                                  id = cl.id,
                                  name = c.name
 

                              }).ToList();
                cmbClass.DataSource = result;

                cmbClass.ValueMember = "id";
                cmbClass.DisplayMember = "name".Trim();
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            int idcs=0;
            try
            {
                 idcs = (int)cmbClass.SelectedValue;

               // MessageBox.Show(idcs.ToString());
            var result = (
                           from cl in context.classlist

                          join cs in context.classesSet on cl.clid equals cs.id
                          join c in context.course on cs.cid equals c.id

                          where cl.id ==  idcs
                          select new
                          {
                              id = c.id,
                              price = c.price,
                              clid=cs.id


                          }).First();
            txtAmount.Text = result.price.ToString();
                classId = result.clid;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            payments pay = new payments();

            pay.clid = classId;
            pay.sid = selectId;
            pay.amount =Convert.ToInt32( txtAmount.Text);
            pay.date =Convert.ToDateTime( txtDate.Text);

            try
            {
                context.payments.Add(pay);
                context.SaveChanges();
                MessageBox.Show("Payment Save succesfully");
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
    }
}
