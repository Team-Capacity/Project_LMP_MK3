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

namespace LibraryMgrProgram
{
    public partial class AdminCustomerMgrForm : Form
    {

        int i = 1;
        dbTest db = new dbTest();
        MouseEvent me = new MouseEvent();

        public AdminCustomerMgrForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminCustomerMgrForm_Load(object sender, EventArgs e)
        {
            string sql = "select CNumber, CRank, CID, CPW, CName, CLoanCot, CPH, CBirth, CAddress, CDate, CGender from LibaryProgram_DB.Customer;";
            me.reloadForm(sql, dgvACMCustomerList,i);
        }

/*        private void listDescription()
        {
            DataGridViewRow row = dgvACMCustomerList.SelectedRows[0];
            // 기본
            lbABIBookName.Text = row.Cells[1].Value.ToString();
            lbABICompany.Text = row.Cells[2].Value.ToString();
            lbABIBookMaker.Text = row.Cells[3].Value.ToString();
            lbABIBookCount.Text = row.Cells[4].Value.ToString();
            lbABIBookger.Text = row.Cells[5].Value.ToString();
            lbABIMakePlace.Text = row.Cells[6].Value.ToString();
            lbABIISBN.Text = row.Cells[8].Value.ToString();
            lbABIBookpage.Text = row.Cells[9].Value.ToString();
            lbABIBLocation.Text = row.Cells[10].Value.ToString();
            lbABIMakeDay.Text = row.Cells[11].Value.ToString();
            lbABIBBookExp.Text = row.Cells[12].Value.ToString();
            lbABIArea.Text = row.Cells[7].Value.ToString();

            // 추가
            txtABIBookName2.Text = row.Cells[1].Value.ToString();
            txtABICompany2.Text = row.Cells[2].Value.ToString();
            txtABIBookMaker2.Text = row.Cells[3].Value.ToString();
            txtABIBookCount2.Text = row.Cells[4].Value.ToString();
            comABIBookger2.Text = row.Cells[5].Value.ToString();
            txtABIMakePlace2.Text = row.Cells[6].Value.ToString();
            txtABIISBN2.Text = row.Cells[8].Value.ToString();
            txtABIBookpage2.Text = row.Cells[9].Value.ToString();
            txtABIBLocation2.Text = row.Cells[10].Value.ToString();
            txtABIMakeDay2.Text = row.Cells[11].Value.ToString();
            rtxtABIBBookExp2.Text = row.Cells[12].Value.ToString();
            txtABIArea2.Text = row.Cells[7].Value.ToString();
            // 수정
            txtABIBookName1.Text = row.Cells[1].Value.ToString();
            txtABICompany1.Text = row.Cells[2].Value.ToString();
            txtABIBookMaker1.Text = row.Cells[3].Value.ToString();
            txtABIBookCount1.Text = row.Cells[4].Value.ToString();
            comABIBookger1.Text = row.Cells[5].Value.ToString();
            txtABIMakePlace1.Text = row.Cells[6].Value.ToString();
            txtABIISBN1.Text = row.Cells[8].Value.ToString();
            txtABIBookpage1.Text = row.Cells[9].Value.ToString();
            txtABIBLocation1.Text = row.Cells[10].Value.ToString();
            txtABIMakeDay1.Text = row.Cells[11].Value.ToString();
            rtxtABIBBookExp1.Text = row.Cells[12].Value.ToString();
            txtABIArea1.Text = row.Cells[7].Value.ToString();
        }*/
    }
}
