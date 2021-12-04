using LibraryMgrProgram;
using LMP_Projcet.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMP_Projcet.Start
{
    public partial class MemberAddForm : Form
    {
        public MemberAddForm()
        {
            InitializeComponent();
        }


  
        private void MemberAddForm_Load(object sender, EventArgs e)
        {

            //생년월일 콤보박스에 값 추가
            int choice;
            for (choice = 1980; choice < 2100; choice++)
            {
                cmbMA_Year.Items.Add(choice);
            }


            for (choice = 1; choice < 13; choice++)
            {
                cmbMA_Month.Items.Add(choice);
            }

            for (choice = 1; choice < 32; choice++)
            {
                cmbMA_Day.Items.Add(choice);
            }

            //비밀번호 *표시로, 최대길이는 16
            txtMA_Pw.PasswordChar = '*';
            txtMA_Pw.MaxLength = 16;

            txtMA_PwCheck.PasswordChar = '*';
            txtMA_PwCheck.MaxLength = 16;




        }


        MouseEvent mouseEvent = new MouseEvent();


        private void plnMA_MouseUp(Object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void plnMA_MouseDown(Object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnMA_MouseMove(Object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnMA_Paint(object sender, PaintEventArgs e)
        {



        }

        private void btnMAMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnMAMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnMAClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }





        private void btnMA_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
