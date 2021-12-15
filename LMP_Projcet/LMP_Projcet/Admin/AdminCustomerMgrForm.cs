using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet.Methods;
using MySql.Data.MySqlClient;

namespace LibraryMgrProgram
{
    public partial class AdminCustomerMgrForm : Form
    {

        MouseEvent me = new MouseEvent();
        dbTest db = new dbTest();
        FormChange fc = new FormChange();

        public AdminCustomerMgrForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminCustomerMgrForm_Load(object sender, EventArgs e)
        {
            
            fc.fromColorChange(this);
            fc.fromColorChange(grpACMView);
            fc.fromColorChange(grpACMModi);
            fc.fromColorChange(tacAIOMain);
            string cusSQL = "select * from Customer;";
            me.reloadForm(cusSQL, dgvACMCustomerList, 1);
            MemberlistDescription();
        }

        private void btnACMAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAIOMSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvACMCustomerList.Columns.Clear();
                if (txtAIOMSearch.Text == "")
                {
                    string sql = "select * from Customer where CNumber > 0;";
                    me.reloadForm(sql, dgvACMCustomerList, 1);
                }
                else
                {
                    if (cboxAIOMSort.SelectedItem.Equals("이름"))
                    {
                        string sql = ("select * from Customer where CName Like '%" + txtAIOMSearch.Text + "%';").ToString();
                        me.reloadForm(sql, dgvACMCustomerList, 1);
                    }
                    else if (cboxAIOMSort.SelectedItem.Equals("아이디"))
                    {
                        string sql = ("select * from Customer where CID Like '%" + txtAIOMSearch.Text + "%';").ToString();
                        me.reloadForm(sql, dgvACMCustomerList, 1);
                    }
                    else if (cboxAIOMSort.SelectedItem.Equals("생년월일"))
                    {
                        string sql = ("select * from Customer where CBirth Like '%" + txtAIOMSearch.Text + "%';").ToString();
                        me.reloadForm(sql, dgvACMCustomerList, 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("검색내용이 없습니다.");
                string sql = "select * from Customer where CNumber > 0;";
                me.reloadForm(sql, dgvACMCustomerList, 1);
            }
        }


        private void MemberlistDescription()
        {
            DataGridViewRow row = dgvACMCustomerList.SelectedRows[0];
            lbACMNumView0.Text = row.Cells[0].Value.ToString();
            lbACMRankView0.Text = row.Cells[1].Value.ToString();
            lbACMNameView0.Text = row.Cells[4].Value.ToString();
            lbACMCountView0.Text = row.Cells[5].Value.ToString();
            lbACMHPView0.Text = row.Cells[7].Value.ToString();
            lbACMBirthView0.Text = row.Cells[8].Value.ToString();
            lbACMAddrView0.Text = row.Cells[9].Value.ToString();
            lbACMSexView0.Text = row.Cells[11].Value.ToString();
            lbACMMemoView0.Text = row.Cells[12].Value.ToString();

            string rank = lbACMRankView0.Text;
            int loanCount = 0;
            if (rank.Equals("1") || rank.Equals("2") || rank.Equals("3"))
            {
                loanCount = Int32.Parse(rank);
            }
            else if (rank.Equals("N"))
            {
                loanCount = 1;
            }
            else if (rank.Equals("M"))
            {
                loanCount = 1;
            }
            lbACMCountView0.Text += "/" + (9 / loanCount).ToString();
        }

        private void MemberlistDescription1()
        {
            DataGridViewRow row = dgvACMCustomerList.SelectedRows[0];
            txtACMNumView2.Text = row.Cells[0].Value.ToString();
            comACMRankView2.Text = row.Cells[1].Value.ToString();
            txtACMPW2.Text = row.Cells[3].Value.ToString();
            txtACMNameView2.Text = row.Cells[4].Value.ToString();
            lbACMCountView2.Text = row.Cells[5].Value.ToString();
            txtACMHPView2.Text = row.Cells[7].Value.ToString();
            txtACMBirth2.Text = row.Cells[8].Value.ToString();
            txtACMAddrView2.Text = row.Cells[9].Value.ToString();

            if (lbACMSexView0.Text.Equals("남자"))
            {
                rdbACMMan2.Checked = true;
            }
            else
            {
                rdbACMWom2.Checked = false;
            }
            txtACMMemoView2.Text = row.Cells[12].Value.ToString();

            string rank = comACMRankView2.Text;
            int loanCount = 0;
            if (rank.Equals("1") || rank.Equals("2") || rank.Equals("3"))
            {
                loanCount = Int32.Parse(rank);
            }
            else if (rank.Equals("N"))
            {
                loanCount = 1;
            }
            else if (rank.Equals("M"))
            {
                loanCount = 1;
            }
            lbACMCountView2.Text += "/" + (9 / loanCount).ToString();
        }

        private void dgvACMCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tacAIOMain.SelectedIndex == 0)
            {
                try
                {
                    MemberlistDescription();
                    string number = lbACMNumView0.Text;
                    // 대출한 사람을 클릭하였을 도서 그리드뷰에서는 해당 대출자가 대출한 리스트를 출력하는 sql문
                    string bookSql = "select distinct BNumber, BName, BPublisher, BAuthor, BCount, BGenre, BProduct, Barea, BISBN, BPage, BLocal, BDate, BContent, BAddDate " +
                        "from LoanList, Book " +
                        "Where LoanList.LBookNum = Book.BNumber and LoanList.LCustomerNum = " + number + ";";
                    me.reloadForm(bookSql, dgvACMStatus0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    MemberlistDescription1();
                    string number = txtACMNumView2.Text;
                    // 대출한 사람을 클릭하였을 도서 그리드뷰에서는 해당 대출자가 대출한 리스트를 출력하는 sql문
                    string bookSql = "select distinct BNumber, BName, BPublisher, BAuthor, BCount, BGenre, BProduct, Barea, BISBN, BPage, BLocal, BDate, BContent, BAddDate " +
                        "from LoanList, Book " +
                        "Where LoanList.LBookNum = Book.BNumber and LoanList.LCustomerNum = " + number + ";";
                    me.reloadForm(bookSql, dgvACMStatus2, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        //회원 삭제버튼
        private void btnACMDel_Click(object sender, EventArgs e)
        {
            if (AdminMainForm.rank.Equals("M"))
            {
                try
                {
                    db.dbConnection();
                    string sql = "select * from LoanList where LCustomerNum = " + Int32.Parse(lbACMNumView0.Text)+ ";";

                    MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                    MySqlDataReader dbReader = cmd.ExecuteReader();
                    string result = "";
                    while (dbReader.Read())
                    {
                        result = dbReader[0].ToString();
                    }
                    dbReader.Close();

                    // 만약 대여중이고 관리자 계정이아니라면
                    if (result.Equals("") && lbACMNumView0.Text != "1")
                    {
                        int number = Int32.Parse(lbACMNumView0.Text);
                        // 삭제여부 확인
                        if (MessageBox.Show("정말로 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string mysql = "delete from Customer where CNumber = " + number + ";";
                            try
                            {
                                MySqlCommand cmd0 = new MySqlCommand(mysql, db.conn);
                                if (cmd0.ExecuteNonQuery() == 1)
                                {

                                    MessageBox.Show("성공적으로 삭제 되었습니다.");
                                    me.reloadForm("select * from Customer;", dgvACMCustomerList, 1);
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else if(lbACMNumView0.Text == "1")
                    {
                        MessageBox.Show("관리자 계정은 삭제할 수 없습니다.");
                    }
                    else
                    {
                        MessageBox.Show("책을 대여중이십니다.");
                    }
                    db.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("회원 삭제도중 에러가 발생하였습니다. \n" + ex.Message);
                }
            }
            else
            {
                btnACMDel.Enabled = false;
            }
        }

        private void btnACMModi_Click(object sender, EventArgs e)
        {
            if (AdminMainForm.rank.Equals("M"))
            {
                string gender = "";
                if (rdbACMMan2.Checked)
                {
                    gender = "남자";
                }
                else
                {
                    gender = "여성";
                }
                try
                {
                    db.dbConnection();
                    DataGridViewRow row = dgvACMCustomerList.SelectedRows[0];
                    string password = "";
                    if (IsValidPassword(txtACMPW2.Text))
                    {
                        password = txtACMPW2.Text;
                    }
                    else
                    {
                        MessageBox.Show("비밀번호는 8글자이상, 영문, 숫자, 특수문자를 포함해야합니다.");
                        return;
                    }

                    string mysql = "Update Customer set CName = '" + txtACMNameView2.Text
                            + "' ,CRank ='" + comACMRankView2.Text
                            + "' ,CPH ='" + txtACMHPView2.Text
                            + "' ,CGender ='" + gender
                            + "' ,CBirth = '" + Convert.ToDateTime(txtACMBirth2.Text).ToString("yyyy-MM-dd")//데이트로 바꾸어주어야함
                            + "' ,CPW ='" + password
                            + "' ,CAddress ='" + txtACMAddrView2.Text
                            + "' ,CMemo ='" + txtACMMemoView2.Text + "'"
                            + " where CNumber = " + Int32.Parse(txtACMNumView2.Text) + ";";
                    db.dbUpdate(mysql);
                    db.conn.Close();
                    MessageBox.Show("성공적으로 수정되었습니다.");
                    string reload = "select * from Customer;";
                    me.reloadForm(reload, dgvACMCustomerList, 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("회원 수정도중 에러가 발생하였습니다. \n" + ex.Message);
                }
            }
            else
            {
                btnACMModi.Enabled = false;
            }
        }

        private void btnACMPWClear_Click(object sender, EventArgs e)
        {
            txtACMPW2.Text = "a123456789!";
        }

        private void tacAIOMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tacAIOMain.SelectedIndex == 1)
            {
                try
                {
                    MemberlistDescription1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("회원 출력도중에 에러가 발생하였습니다. \n" + ex.Message);
                }
            }
            else
            {
                MemberlistDescription();
            }
        }

        private static bool IsValidPassword(string Text)
        {
            //영문, 숫자, 특수문자 포함 8글자 이상
            Regex Pregex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$");
            Match Pmatch = Pregex.Match(Text);
            return Pmatch.Success;
        }
    }
}
