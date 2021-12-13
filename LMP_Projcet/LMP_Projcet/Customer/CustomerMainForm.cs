using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMgrProgram.CustomerForm;
using LMP_Projcet;
using LMP_Projcet.Customer;
using LMP_Projcet.Methods;



namespace LibraryMgrProgram
{
    public partial class CustomerMainForm : Form
    {
       
        public CustomerMainForm()
        {
            InitializeComponent();
            FontChangeForm fc = new FontChangeForm();
            if(fc.rdoFCBlack.Checked)
            {
                this.BackColor = Color.Black;
            }


        }

        MouseEvent mouseEvent = new MouseEvent();
        FormChange formChange = new FormChange();

        CustomerMyInfomationForm cmi = new CustomerMyInfomationForm();
        CustomerOperationForm cof = new CustomerOperationForm();
        CustomerContentsForm ccf = new CustomerContentsForm();
        CustomerBookInfoForm cbi = new CustomerBookInfoForm();
        LoginForm lf = new LoginForm();

        dbTest db = new dbTest();

        public static string myname;
    

        private void btnCMMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnCMMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnCMClose_Click(object sender, EventArgs e)
        {
            //mouseEvent.ButtonClose(this);
            Application.Exit();
        }


        private void plnCM_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnCM_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnCM_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

       

   


        //로그아웃 -> 로그인 화면으로 이동
        private void lbCMLogOut_Click_1(object sender, EventArgs e)
        {
            
            
            formChange.ChangeF(this,lf) ;
        }

     
   



        //공지사항,추천도서,현황 기본으로 로드
        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            formChange.ChangeFIF(ccf, palCMMain);
            lbCMCustomer.Text = LoginForm.name + "님 환영합니다.";
            myname = lbCMCustomer.Text;
        }

        CustomerEditForm ce = new CustomerEditForm();
        //회원정보 클릭시 내정보
        private void lbCMInfo_Click(object sender, EventArgs e)
        {
           ce.change();
            formChange.ChangeFIF(cmi, palCMMain);
        }


        //환경설정 클릭시 이벤트
        private void lbCMOperation_Click(object sender, EventArgs e)
        { 
            formChange.ChangeFIF(cof, palCMMain);     
        }

        private void plnCM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCMBookInfo_Click(object sender, EventArgs e)
        {
            formChange.ChangeFIF(cbi, palCMMain);
        }

      

        private void CustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
