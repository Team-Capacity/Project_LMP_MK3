﻿using LMP_Projcet.Methods;
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
    public partial class CustomerMyInfomationForm : Form
    {
        
        public CustomerMyInfomationForm()
        {
            InitializeComponent();
        }

        FormChange fc = new FormChange();
        
        


        private void CustomerMyInfomationForm_Load(object sender, EventArgs e)
        {

        }
       
        private void btnCMIEdit_Click(object sender, EventArgs e)
        {
            CustomerEditForm ce = new CustomerEditForm();
            ce.Show();
        }

        private void lbCMIMyEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbCMIMyBirth_Click(object sender, EventArgs e)
        {

        }

        private void lbCMIBirth_Click(object sender, EventArgs e)
        {

        }

        private void lbCMIMyAge_Click(object sender, EventArgs e)
        {

        }
    }
}
