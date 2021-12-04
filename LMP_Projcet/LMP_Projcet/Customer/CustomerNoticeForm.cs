using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMgrProgram;
using LMP_Projcet;
using LMP_Projcet.Methods;


namespace LMP_Projcet.Customer
{
    public partial class CustomerNoticeForm : Form
    {
        public CustomerNoticeForm()
        {
            InitializeComponent();
        }

        MouseEvent mouseEvent = new MouseEvent();


        private void plnCN_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnCN_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e,this);
        }

        private void plnCN_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void btnCNMin_Click_1(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnCNMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnCNClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }





        private void plnCN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerNoticeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
