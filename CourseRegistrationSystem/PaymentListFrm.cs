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
    public partial class PaymentListFrm : Form
    {
        public PaymentListFrm()
        {
            InitializeComponent();
        }

        private void PaymentListFrm_Load(object sender, EventArgs e)
        {
            listPayments();
        }
        
        private void listPayments()
        {
            CrsEntities context = new CrsEntities();
            var result = (from p in context.payments
                         join cl in context.classlist on p.clid equals cl.id
                          join cs in context.classesSet on cl.clid equals cs.id
                          join c in context.course on cs.cid equals c.id
                          join s in context.student on p.sid equals s.id

                          where s.name.StartsWith(txtName.Text)&& s.lastname.StartsWith(txtLastName.Text)
                          select new
                          {
                              id = p.id,
                              course = c.name,
                              name = s.name,
                              lastName = s.lastname,
                              amount = p.amount,
                              date = p.date

                          }).ToList();

            dgwList.DataSource = result;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listPayments();
        }
    }
}
