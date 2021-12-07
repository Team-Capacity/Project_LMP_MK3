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
using LMP_Projcet;

namespace LibraryMgrProgram
{
    public partial class IDPWSearchForm : Form
    {
        MouseEvent mouseEvent = new MouseEvent();
        public IDPWSearchForm()
        {
            InitializeComponent();
        }

        private void btnSerOK_Click(object sender, EventArgs e)
        {
            if (txtSerName.Text == "" && txtSerPH.Text == "" && txtSerBir.Text == "")
            {
                MessageBox.Show("입력해주세요.");
            }
            else if (txtSerName.Text == "" || txtSerPH.Text == "" || txtSerBir.Text == "")
            {
                MessageBox.Show("입력 칸 중 빈칸이있습니다.");
            }
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

        private void btnLFClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnSerPwOK_Click(object sender, EventArgs e)
        {
            if (txtSerID.Text == "" && txtSerPwName.Text == "" && txtSerPwBir.Text == "")
            {
                MessageBox.Show("입력해주세요.");
            }

            else if (txtSerID.Text == "" || txtSerPwName.Text == "" || txtSerPwBir.Text == "")
            {
                MessageBox.Show("입력 칸 중 빈칸이있습니다.");
            }
        }
    }
}
