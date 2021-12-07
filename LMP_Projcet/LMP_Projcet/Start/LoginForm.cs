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
using LMP_Projcet.Methods;
using LMP_Projcet.Start;

namespace LMP_Projcet
{

    public partial class LoginForm : Form
    {
        FormChange formChange = new FormChange();
        MouseEvent mouseEvent = new MouseEvent();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLFNonLogin_Click(object sender, EventArgs e)
        {
            NonCustomerMainForm nonCustomerMainForm = new NonCustomerMainForm();
            nonCustomerMainForm.Show();
            this.Hide();
        }

        private void btnLFLogin_Click(object sender, EventArgs e)
        {
            if(txtLFID.Text == "admin" && txtLFPW.Text == "admin")
            {
                AdminMainForm adminMainForm = new AdminMainForm();
                formChange.ChangeF(this, adminMainForm);
            }
            else if(txtLFID.Text =="1" && txtLFID.Text == "1")
            {
                CustomerMainForm customerMainForm = new CustomerMainForm();
                formChange.ChangeF(this, customerMainForm);
            }
            //빈칸 입력시 메시지 출력
            if(txtLFID.Text == "" && txtLFPW.Text == "")
            {
                MessageBox.Show("빈칸이있습니다.");
            }
        }

        private void btnLFMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnLFMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnLFClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }

        private void plnAM_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnAM_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnAM_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void labLFSearch_Click(object sender, EventArgs e)
        {
            IDPWSearchForm serchf = new IDPWSearchForm();
            formChange.ChangeF(this, serchf);
        }

        private void labLFAddMem_Click(object sender, EventArgs e)
        {
            MemberAddForm MA = new MemberAddForm();
            formChange.ChangeF(this, MA);
        }

        private void txtLFID_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpLogLogin_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
