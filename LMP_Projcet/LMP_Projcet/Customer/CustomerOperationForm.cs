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
        FontChangeForm fc;

        public static bool chkShow1 = false;  // chkShow를 같이 쓰면 공지사항 클릭했을때 다른 (색상/글꼴,건의사항)버튼 이벤트가 발생 안함
        public static bool chkShow2 = false;
        public static bool chkShow3 = false;

        public CustomerOperationForm()
        {
            InitializeComponent();
          









        }

        //공지사항 클릭 이동
        private void lbCONotice_Click(object sender, EventArgs e)
        {

          
            if(!chkShow1)
            {
                CustomerNoticeForm cn = new CustomerNoticeForm();
                cn.Location = new Point(500, 150);
                cn.Show();
                chkShow1 = true;
            }
           
            else
            {
                return;
            }

            
            
          
      
        }

        //건의하기 클릭 이동, 해당 창이 뜰때 위치
        private void lbCOSuggest_Click(object sender, EventArgs e)
        {
           
            if(!chkShow2)
            {
                CustomerWriteForm cw = new CustomerWriteForm();
                cw.Show();
                chkShow2 = true;
            }
            else
            {
                return;
            }
              
            
            //한번 더 클릭시 기존의 창은 닫히고 다시 열리는

           
        }

        //색상/글꼴 클릭 이동




     
     

        private void lbCOColor_Click(object sender, EventArgs e)
        {

        if(!chkShow3)
            {
                fc = new FontChangeForm();
                fc.Location = new Point(500, 250);
                fc.Show();
                chkShow3 = true;
                
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
