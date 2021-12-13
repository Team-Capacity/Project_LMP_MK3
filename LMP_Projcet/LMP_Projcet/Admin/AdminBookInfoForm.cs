using System;
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
using LMP_Projcet.Methods.DB;
using MySql.Data.MySqlClient;

namespace LibraryMgrProgram
{
    public partial class AdminBookInfoForm : Form
    {

        int i = 0;
        public AdminBookInfoForm()
        {
            InitializeComponent();
        }

        dbTest db = new dbTest();
        MouseEvent me = new MouseEvent();

        private void AdminBookInfoForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from lmp.Book;";
            me.reloadForm(sql,dgvABIBookList,i);
            listDescription();
        }

        private void btnABIImgUplode2_Click(object sender, EventArgs e)
        {
            me.ImageUpload(ImgAMView2);
        }

        private void btnABIOk2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime bookAddDay = Convert.ToDateTime(txtABIMakeDay2.Text);
            
            string sql = "insert into Book(BName, BPublisher, BAuthor, BCount, BGenre, BProduct, Barea, BISBN, Bpage, BLocal, BDate, BContent,BAddDate) values("
                    + "'" + txtABIBookName2.Text + "'"
                    + ",'" + txtABICompany2.Text + "'"
                    + ",'" + txtABIBookMaker2.Text + "'"
                    + "," + Int32.Parse(txtABIBookCount2.Text)
                    + ",'" + comABIBookger2.Text + "'"
                    + ",'" + txtABIMakePlace2.Text + "'"
                    + ",'" + txtABIArea2.Text + "'"
                    + ",'" + txtABIISBN2.Text + "'"
                    + "," + Int32.Parse(txtABIBookpage2.Text)
                    + ",'" + txtABIBLocation2.Text + "'"
                    // 이부분은 DateTime의 형태로 바꾸어주어야함
                    + ",'"+ bookAddDay.Year+"/"+bookAddDay.Month+"/"+bookAddDay.Day + "'"
                    + ",'" + rtxtABIBBookExp2.Text + "'"
                    + ",'" + now.ToString("yy/dd/MM") + "'"
                    + ");";
            db.dbUpdate(sql);
            string reloadSql = "select * from lmp.Book;";
            me.reloadForm(reloadSql, dgvABIBookList,i);
        }

        // 도서 추가 초기화 버튼
        private void btnABIClear2_Click(object sender, EventArgs e)
        {
            txtABIBookName2.Text = "";
            txtABICompany2.Text = "";
            txtABIBookMaker2.Text = "";
            txtABIBookCount2.Text = "";
            comABIBookger2.Text = "";
            txtABIMakePlace2.Text = "";
            txtABIISBN2.Text = "";
            txtABIBookpage2.Text = "";
            txtABIBLocation2.Text = "";
            txtABIMakeDay2.Text = "";
            rtxtABIBBookExp2.Text = "";
            txtABIArea2.Text = "";
        }

        // 검색 버튼 클릭시 이벤트
        private void btnABISer_Click(object sender, EventArgs e)
        {
            dgvABIBookList.Columns.Clear();
            if(txtABISerBar.Text == "")
            {
                string sql = "select * from lmp.Book;";
                me.reloadForm(sql,dgvABIBookList,i);
            }
            else
            {
                string sql = ("select * from lmp.Book where BName = '" + txtABISerBar.Text + "';").ToString();
                me.reloadForm(sql, dgvABIBookList,i);
            }
        }

        //셀 클릭 이벤트 처리
        private void dgvABIBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listDescription();
        }

        // 셀 클릭시 도서정보 조회
        public void listDescription()
        {
            DataGridViewRow row = dgvABIBookList.SelectedRows[0];
            // 기본
            lbABIBookName.Text = row.Cells[1].Value.ToString();
            lbABICompany.Text = row.Cells[2].Value.ToString();
            lbABIBookMaker.Text = row.Cells[3].Value.ToString();
            lbABIBookCount.Text =row.Cells[4].Value.ToString();
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
        }

        // 도서 수정 초기화 버튼
        private void btnABIClear1_Click(object sender, EventArgs e)
        {
            txtABIBookName1.Text = "";
            txtABICompany1.Text = "";
            txtABIBookMaker1.Text = "";
            txtABIBookCount1.Text = "";
            comABIBookger1.Text = "";
            txtABIMakePlace1.Text = "";
            txtABIISBN1.Text = "";
            txtABIBookpage1.Text = "";
            txtABIBLocation1.Text = "";
            txtABIMakeDay1.Text = "";
            rtxtABIBBookExp1.Text = "";
            txtABIArea1.Text = "";
        }

        private void btnABIOk1_Click(object sender, EventArgs e)
        {
            db.dbConnection();
            DataGridViewRow row = dgvABIBookList.SelectedRows[0];
            int number = Int32.Parse(row.Cells[0].Value.ToString());

            string mysql = "Update Book set BName = '" + txtABIBookName1.Text
                    + "' ,BPublisher ='" + txtABICompany1.Text
                    + "' ,BAuthor ='" + txtABIBookMaker1.Text
                    + "' ,BCount =" + Int32.Parse(txtABIBookCount1.Text)
                    + "  ,BGenre ='" + comABIBookger1.Text
                    + "' ,BProduct ='" + txtABIMakePlace1.Text
                    + "' ,Barea ='" + txtABIArea1.Text
                    + "' ,BISBN ='" + txtABIISBN1.Text
                    + "' ,Bpage = " + Int32.Parse(txtABIBookpage1.Text)
                    + "  ,BLocal ='" + txtABIBLocation1.Text
                    + "' ,BContent ='" + rtxtABIBBookExp1.Text + "'"
                    + " where BNumber = " + number + ";";

            try
            {
                MySqlCommand cmd = new MySqlCommand(mysql, db.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공적으로 추가 되었습니다.");
                    me.reloadForm("select * from lmp.Book.;", dgvABIBookList,i);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnABIRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvABIBookList.SelectedRows[0];
            int number = Int32.Parse(row.Cells[0].Value.ToString());
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.dbConnection();
                string mysql = "delete from Book where BNumber = " + number + ";";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(mysql, db.conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("성공적으로 삭제 되었습니다.");
                        me.reloadForm("select * from lmp.Book;", dgvABIBookList,i);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

     
    }
}
