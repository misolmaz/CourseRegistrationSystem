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
    public partial class ClassesListFrm : Form
    {
        public ClassesListFrm()
        {
            InitializeComponent();
        }

        private void ClassesListFrm_Load(object sender, EventArgs e)
        {
            listClasses();
        }

        private void listClasses()
        {
            CrsEntities context = new CrsEntities();
            var result = (
                          from cs in context.classesSet 
                          join c in context.course on cs.cid equals c.id
                          join i in context.instructor on c.iid equals i.id

                         where i.name.StartsWith(txtName.Text) 
                          select new
                          {
                              id = cs.id,
                              course = c.name,
                              tutors=i.name,
                             
                              date = cs.sdate

                          }).ToList();

            dgwList.DataSource = result;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listClasses();
        }
    }
}
