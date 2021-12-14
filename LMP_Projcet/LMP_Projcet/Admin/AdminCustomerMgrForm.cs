using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet.Methods;

namespace LibraryMgrProgram
{
    public partial class AdminCustomerMgrForm : Form
    {

        MouseEvent me = new MouseEvent();

        public AdminCustomerMgrForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminCustomerMgrForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from Customer;";
            me.reloadForm(sql, dgvACMCustomerList, 1);
        }

        private void btnACMAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
