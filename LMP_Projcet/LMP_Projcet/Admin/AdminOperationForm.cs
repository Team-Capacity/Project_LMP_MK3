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
using LibraryMgrProgram;

namespace LMP_Projcet.Admin
{
    public partial class AdminOperationForm : Form
    {
        FormChange formChange = new FormChange();

        public AdminOperationForm()
        {
            InitializeComponent();
        }

        private void AdminOperationForm_Load(object sender, EventArgs e)
        {

        }


        private void lbAOSuggestionBox_Click(object sender, EventArgs e)
        {
            AdminSuggestionForm suggestForm = new AdminSuggestionForm();
            suggestForm.Show();
        }

        private void lbAOColor_Click(object sender, EventArgs e)
        {
            FontChangeForm fCForm = new FontChangeForm();
            fCForm.Show();
        }

        private void lbAONotice_Click(object sender, EventArgs e)
        {
            AdminNoticeForm aNForm = new AdminNoticeForm();
            aNForm.Show();
        }
    }
}
