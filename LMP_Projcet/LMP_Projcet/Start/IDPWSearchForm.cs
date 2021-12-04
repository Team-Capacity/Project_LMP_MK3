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

    }
}
