﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet.Methods;

namespace LibraryMgrProgram
{
    public partial class AdminBookInfoForm : Form
    {

        public AdminBookInfoForm()
        {
            InitializeComponent();
        }

        dbTest db = new dbTest();
        private void AdminBookInfoForm_Load(object sender, EventArgs e)
        {
            //db.dbConnection();
        }
    }
}
