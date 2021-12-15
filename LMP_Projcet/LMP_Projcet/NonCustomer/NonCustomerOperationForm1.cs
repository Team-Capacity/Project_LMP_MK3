using LibraryMgrProgram;
using LMP_Projcet.Customer;
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

namespace LMP_Projcet.NonCustomer
{
    public partial class NonCustomerOperationForm1 : Form
    {
        FormChange fc = new FormChange();
        FontChangeForm fch;
        CustomerNoticeForm cn;

        public static bool chkShow1 = false;  
        public static bool chkShow3 = false;


        public NonCustomerOperationForm1()
        {
            InitializeComponent();
        }

     

        private void lbNCONotice_Click(object sender, EventArgs e)
        {

            if (!chkShow1)
            {
                cn = new CustomerNoticeForm();
                cn.Location = new Point(500, 150);
                cn.Show();
                chkShow1 = true;
            }

            else
            {
                return;
            }
        }

        private void lbNCOColor_Click(object sender, EventArgs e)
        {
            if (!chkShow3)
            {
                fch = new FontChangeForm();
                fch.Location = new Point(500, 250);
                fch.Show();
                chkShow3 = true;
            }
            else
            {
                return;
            }

        }

        private void NonCustomerOperationForm1_Load(object sender, EventArgs e)
        {
            fc.fromColorChange(this);
            fc.fromColorChange(grpNCOBookInfo);
            fc.fromColorChange(grpNCOColor);
            Label[] back = { lbNCOColor, lbNCONotice };
            fc.fromColorChange(back, back);
        }
    }
}
