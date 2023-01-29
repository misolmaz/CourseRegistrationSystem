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
    public partial class TutoursFrm : Form
    {
        int selectId;
        instructor updates;
        public TutoursFrm()
        {
            InitializeComponent();
        }

        private void TutoursFrm_Load(object sender, EventArgs e)
        {
            listTutours();
        }

        private void listTutours()
        {

            CrsEntities context = new CrsEntities();

            // List<kullanicilar> ssloc = context.kullanicilar.Where(w => w.rolID == 1).ToList();
            
            dgwList.DataSource = context.instructor.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            instructor ins = new instructor();
            CrsEntities context = new CrsEntities();
            ins.name = txtName.Text;
            ins.lastname = txtLastname.Text;
            ins.phone = txtPhone.Text;

            try
            {
                context.instructor.Add(ins);
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

            listTutours();




        }

        private void dgwList_SelectionChanged(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            if (dgwList.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwList.SelectedRows[0].Cells[0].Value);

                updates = context.instructor.Find(selectId);
                txtName.Text = updates.name;
                txtLastname.Text = updates.lastname;
                txtPhone.Text = updates.phone;
               

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();
            var matches = from m in context.instructor
                          where m.name.Contains(txtName.Text)
                          select m;

            dgwList.DataSource = matches.ToList<instructor>();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CrsEntities context = new CrsEntities();

            updates = context.instructor.Find(selectId);
            updates.name=txtName.Text ;
            updates.lastname=txtLastname.Text ;
            updates.phone= txtPhone.Text;
            try
            {
                context.SaveChanges();
                listTutours();
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

                        MessageBox.Show(
                            ve.PropertyName+" "+ ve.ErrorMessage);
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
                        context.instructor.Remove(context.instructor.Find(id));
                        context.SaveChanges();
                        MessageBox.Show("Deleted.");
                        listTutours();
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
