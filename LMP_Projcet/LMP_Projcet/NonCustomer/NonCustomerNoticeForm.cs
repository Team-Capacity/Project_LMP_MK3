using LibraryMgrProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet;
using LMP_Projcet.Customer;
using LMP_Projcet.Methods;

namespace LMP_Projcet.NonCustomer
{
    public partial class NonCustomerNoticeForm : Form
    {
        public NonCustomerNoticeForm()
        {
            InitializeComponent();
        }

        MouseEvent mouseEvent = new MouseEvent();

        private void plnNCN_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnNCN_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnNCN_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }


        private void btnNCNMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnNCNMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnNCNClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }


        private void plnNCN_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
