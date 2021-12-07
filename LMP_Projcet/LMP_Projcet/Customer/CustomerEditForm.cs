﻿using LibraryMgrProgram;
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
    public partial class CustomerEditForm : Form
    {
        public CustomerEditForm()
        {
            InitializeComponent();
        }

        MouseEvent mouseEvent = new MouseEvent();
     
   
     

        private void btnCusDel_Click(object sender, EventArgs e)
        {
           
        }

     
        //개인정보 수정 취소 -> 메인화면 개인정보뜬 화면으로 이동
        private void btnCusEditCancel_Click(object sender, EventArgs e)
        {
             CustomerMyInfomationForm.chkShow = false;
             this.Close();
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

        }

        private void plnCE_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnCE_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnCE_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void btnCEMin_Click_1(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnCEMax_Click_1(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnCEClose_Click_1(object sender, EventArgs e)
        {
            CustomerMyInfomationForm.chkShow = false;
            mouseEvent.ButtonClose(this);
            
        }



        private void plnCM_Paint(object sender, PaintEventArgs e)
        {

        }

        //버튼 클릭시 사진 불러오기
        //@"D:w" -> 불러올 초기 위치
        private void btnCELoad_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:w";

            dialog.Filter = "모든파일(*.*)|*.*";
            dialog.RestoreDirectory = true;

            var result = dialog.ShowDialog();  //변수로 선언해주고 if문안에 넣어주지 않으면 취소눌러도 파일창이 한번 더뜸.

            if (result == DialogResult.OK)
            {
                image_file = dialog.FileName;
                picCMICustomerImg.Image = Bitmap.FromFile(image_file);
                picCMICustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (result == DialogResult.Cancel)
            {
                return;
                

            }
            this.Close();




        }

        //저장버튼 클릭
        private void btnCESave_Click(object sender, EventArgs e)
        {
           
        }
    }
}
