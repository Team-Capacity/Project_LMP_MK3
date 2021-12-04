using LibraryMgrProgram;
using LMP_Projcet.Methods;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMP_Projcet.Customer
{
    public partial class CustomerOperationForm : Form
    {

        FormChange formChange = new FormChange();
    
        public CustomerOperationForm()
        {
            InitializeComponent();
        }

        //공지사항 클릭 이동
        private void lbCONotice_Click(object sender, EventArgs e)
        {

          
            CustomerNoticeForm cn = new CustomerNoticeForm();
            cn.Location = new Point(500, 150);
            cn.Show();

            
            
          
      
        }

        //건의하기 클릭 이동, 해당 창이 뜰때 위치
        private void lbCOSuggest_Click(object sender, EventArgs e)
        {
           
            CustomerWriteForm cw = new CustomerWriteForm();   
            cw.Show();      
            
            //한번 더 클릭시 기존의 창은 닫히고 다시 열리는

           
        }

        //색상/글꼴 클릭 이동



        FontChangeForm fc;
     
        public static bool chkShow = false;

        private void lbCOColor_Click(object sender, EventArgs e)
        {

        if(!chkShow)
            {
                fc = new FontChangeForm();
                fc.Show();
                chkShow = true;
            }
        else
            {
                return;
            }
   

        }



        private void CustomerOperationForm_Load(object sender, EventArgs e)
        {


        }

       
    }
}
