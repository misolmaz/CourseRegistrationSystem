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
    public partial class ListStudentFrm : Form
    {
        public ListStudentFrm()
        {
            InitializeComponent();
        }

        private void ListStudentFrm_Load(object sender, EventArgs e)
        {
            listStudents();
        }

        private void listStudents()
        {
            CrsEntities context = new CrsEntities();
            var result = (
                          from s in context.student
                        
                        
                          

                        where s.name.StartsWith(txtName.Text)
                          select new
                          {
                              id = s.id,
                              
                              name = s.name,
                              lastname = s.lastname,
                              phone = s.phone,

                             
                          }).ToList();

            dgwList.DataSource = result;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listStudents();
        }
    }
}
