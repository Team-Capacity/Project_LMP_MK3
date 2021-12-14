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

        public static Color color;


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

        private void btnFCClose_Click_1(object sender, EventArgs e, bool chkShow) 
        {
            chkShow = false;
            this.Close();

            //mouseEvent.ButtonClose(this);
        }



        private void plnFC_Paint(object sender, PaintEventArgs e)
        {



        }



       
        private void btnFCClose_Click(object sender, EventArgs e)
        {

            CustomerOperationForm.chkShow3 = false;
            this.Close();

        }


       
        private void btnFCCancle_Click(object sender, EventArgs e)
        {
            CustomerOperationForm.chkShow3 = false;
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

        public void FontChangeForm_Load(object sender, EventArgs e)
        {

        }

        public void rdoFCBasic_CheckedChanged(object sender, EventArgs e)
        {
            grpFCSetting.Enabled = false;
        }

        public void rdoFCSetting_CheckedChanged(object sender, EventArgs e)
        {
            grpFCSetting.Enabled = true;
        }

        private void lstboxFCSizelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
        public void btnFCSetting_Click(object sender, EventArgs e)
        {

            if (rdoFCBlack.Checked)
            {
                SetText("black");
                color = Color.FromArgb(100, 100, 100);
                LMP_Projcet.Properties.Settings.Default.myColor = false;
                LMP_Projcet.Properties.Settings.Default.Save();
                this.Close();
                Application.Restart();
            }

            if(rdoFCWhite.Checked)
            {
                SetText("white");
                color = Color.FromArgb(255, 255, 255);
                LMP_Projcet.Properties.Settings.Default.myColor = true;
                LMP_Projcet.Properties.Settings.Default.Save();
                this.Close();
                Application.Restart();
            }

        }
        public void SetText(string str)
        {
            if (str == "black")
            {
                MessageBox.Show("어두운 테마가 선택 되었습니다.");
            }

            if(str == "white")
            {
                MessageBox.Show("밝은 테마가 선택 되었습니다.");
            }
        }

       
    }
}
