using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMgrProgram.NonCustomerForm;
using LMP_Projcet;
using LMP_Projcet.NonCustomer;
using LMP_Projcet.Methods;
using LMP_Projcet.NonCustomer;
using LMP_Projcet.Customer;

namespace LibraryMgrProgram
{
    public partial class NonCustomerMainForm : Form
    {
        public NonCustomerMainForm()
        {
            InitializeComponent();
        }
        NonCustomerOperationForm1 no = new NonCustomerOperationForm1();
        CustomerBookInfoForm cbi = new CustomerBookInfoForm();
        MouseEvent mouseEvent = new MouseEvent();
        FormChange formChange = new FormChange();

      
        NonCustomerContentsForm ncc = new NonCustomerContentsForm();

        

        private void lbCMInfo_Click(object sender, EventArgs e)
        {

        }

        private void plnNCM_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnNCM_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e,this);
        }

        private void plnNCM_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }


        private void btnNCMMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnNCMMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnNCMClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }

        private void plnNCM_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //메인 폼 판넬 안에 공지사항
        private void NonCustomerMainForm_Load(object sender, EventArgs e)
        {
            formChange.fromColorChange(this);
            Label[] back = { lbNCMHome, lbNCMBookInfo , lbNCMOperation, lbNCMLogin, label2 };
            Panel[] p = { plnAM, plnAM0 };
            formChange.fromColorChange(back, back, p);
            formChange.ChangeFIF(ncc, palNCMMain);
        }

        //로그인 화면으로 이동,아직 미완성
        private void lbNCMLogin_Click(object sender, EventArgs e)
        {
           
            LoginForm lf = new LoginForm();
            formChange.ChangeF(this, lf);
        }

        private void lbNCMLogo_Click(object sender, EventArgs e)
        {
            formChange.ChangeFIF(ncc, palNCMMain);
        }

   
   
        private void NonCustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        NonCustomerOperationForm1 no1 = new NonCustomerOperationForm1();

        private void lbNCMOperation_Click_1(object sender, EventArgs e)
        {
            formChange.ChangeFIF(no1, palNCMMain);
        }

        private void lbNCMBookInfo_Click_1(object sender, EventArgs e)
        {
            formChange.ChangeFIF(cbi, palNCMMain);
        }

      
    }
}
