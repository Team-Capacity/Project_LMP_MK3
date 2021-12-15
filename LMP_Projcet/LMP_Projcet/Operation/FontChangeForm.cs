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
        public bool radioCheckedChanged = false;
        FormChange fc = new FormChange();


        public FontChangeForm()
        {
            InitializeComponent();
            this.rdoFCWhite.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.rdoFCBlack.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            this.rdoFCWhite.Click += new EventHandler(radioButton_Click);
            this.rdoFCBlack.Click += new EventHandler(radioButton_Click);
        }

        public void radioButton_Click(object sender, EventArgs e)
        {
            
            RadioButton rdo = sender as RadioButton;
            if (!radioCheckedChanged)
            {
                rdo.Checked = false;
            }
            radioCheckedChanged = false;

        }

        public void radioButton_CheckedChanged(object sender, EventArgs e)
        {
           
            radioCheckedChanged = true;
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

     
        private void btnFCMin_Click_1(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnFCMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }


  

        private void btnFCClose_Click_1(object sender, EventArgs e)
        {
            CustomerOperationForm.chkShow3 = false;
            this.Close();
        }


        private void plnFC_Paint(object sender, PaintEventArgs e)
        {



        }
        private void btnFCCancle_Click(object sender, EventArgs e)
        {
            CustomerOperationForm.chkShow3 = false;
            this.Close();
        }
        
        //대표글꼴 클릭시 옆에 한글 콤보박스에 해당 글꼴이 뜸
        private void lstFCListChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void FontChangeForm_Load(object sender, EventArgs e)
        {
            fc.fromColorChange(grpFCSetting);
            fc.fromColorChange(this);
            Panel[] p = { plnAM };
            Label[] b = { label1 };
            fc.fromColorChange(b, b, p);

            if (LMP_Projcet.Properties.Settings.Default.myColor == false)
            {
                rdoFCBlack.Checked = true;
            }
            else
            {
                rdoFCWhite.Checked = true;
            }
        }

        public void rdoFCBasic_CheckedChanged(object sender, EventArgs e)
        {
            cmbFCKo_Sel.Enabled = true;
            cmbFCKo.Enabled = true;
        }

        public void rdoFCSetting_CheckedChanged(object sender, EventArgs e)
        {
            cmbFCKo_Sel.Enabled = false;
            cmbFCKo.Enabled = false;
        }

        private void lstboxFCSizelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
        public void btnFCSetting_Click(object sender, EventArgs e)
        {

            if (rdoFCBlack.Checked)
            {
                LMP_Projcet.Properties.Settings.Default.myColor = false;
                LMP_Projcet.Properties.Settings.Default.Save();
                this.Close();
                Application.Restart();
            }else if(rdoFCWhite.Checked)
            {
                LMP_Projcet.Properties.Settings.Default.myColor = true;
                LMP_Projcet.Properties.Settings.Default.Save();
                this.Close();
                Application.Restart();
            }

        }

    }
}
