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


namespace LibraryMgrProgram
{
    public partial class FontChangeForm : Form
    {
        public FontChangeForm()
        {
            InitializeComponent();
            
        }

        MouseEvent mouseEvent = new MouseEvent();
      
       

        private void plnFC_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnFC_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnFC_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void btnFCMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnFCMax_Click_1(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

     
        private void btnFCClose_Click(object sender, EventArgs e, bool chkShow)
        {

            chkShow = false;



            this.Close();

           //mouseEvent.ButtonClose(this);

        }



        private void plnFC_Paint(object sender, PaintEventArgs e)
        {



        }

        private void PlnFC_MouseUP(object sender, MouseEventArgs e)
        {

        }


       
        private void btnFCClose_Click(object sender, EventArgs e)
        {

            CustomerOperationForm.chkShow = false;
            this.Close();

        }


       
        private void btnFCCancle_Click(object sender, EventArgs e)
        {
            CustomerOperationForm.chkShow = false;
            this.Close();
        }
        
        //대표글꼴 클릭시 옆에 한글 콤보박스에 해당 글꼴이 뜸
        private void lstFCListChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstFCListChoice.SelectedItems != null)
            {
                int choiceIndex = lstFCListChoice.SelectedIndex;
                cmbFCKo_Sel.Text = lstFCListChoice.Items[choiceIndex].ToString();
            }
            
        }

        private void FontChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void rdoFCBasic_CheckedChanged(object sender, EventArgs e)
        {
            grpFCSetting.Enabled = false;
        }

        private void rdoFCSetting_CheckedChanged(object sender, EventArgs e)
        {
            grpFCSetting.Enabled = true;
        }

        private void lstboxFCSizelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
