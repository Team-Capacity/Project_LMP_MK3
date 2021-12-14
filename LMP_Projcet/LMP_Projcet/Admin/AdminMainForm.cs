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
using LMP_Projcet.Admin;
using LMP_Projcet.Methods;
using LibraryMgrProgram.AdminForm;

namespace LibraryMgrProgram
{
    public partial class AdminMainForm : Form
    {
        AdminBookInfoForm aInfoForm = new AdminBookInfoForm();
        AdminContentsMainForm aConForm = new AdminContentsMainForm();
        AdminOperationForm aOperForm = new AdminOperationForm();
        AdminInputOutputForm aInOutForm = new AdminInputOutputForm();
        AdminCustomerMgrForm aCusMgrForm = new AdminCustomerMgrForm();
        LoginForm lg = new LoginForm();

        FormChange formChange = new FormChange();
        MouseEvent mouseEvent = new MouseEvent();
        dbTest db = new dbTest();
        String sql = "";


        public AdminMainForm()
        {
            InitializeComponent();
        }
        private void plnAM_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnAM_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e,this);
        }

        private void plnAM_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void btnAMMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnAMMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnAMClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            formChange.ChangeFIF(aConForm, palAMMain);
            lbAMCustomer.Text = LoginForm.name+"님 환영합니다.";

            bool color = LMP_Projcet.Properties.Settings.Default.myColor;
            if(color == false)
            {
                this.BackColor = FontChangeForm.color;
            }
        }

        private void lbAMHome_Click(object sender, EventArgs e)
        { 
            formChange.ChangeFIF(aConForm, palAMMain);
        }

        //로그아웃 -> 회원 폼을 비회원 폼으로 이동
        private void lbAMLoginOut_Click(object sender, EventArgs e)
        {
            formChange.ChangeF(this, lg);
        }

        private void lbAMOperation_Click(object sender, EventArgs e)
        {
            formChange.ChangeFIF(aOperForm,palAMMain);
        }

        private void lbAMInOut_Click(object sender, EventArgs e)
        {
            formChange.ChangeFIF(aInOutForm, palAMMain);
        }

        private void lbAMBookInfo_Click(object sender, EventArgs e)
        {
            formChange.ChangeFIF(aInfoForm, palAMMain);
        }

        private void lbAMCusInfo_Click(object sender, EventArgs e)
        {
            formChange.ChangeFIF(aCusMgrForm, palAMMain);
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
