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
using MySql.Data.MySqlClient;

namespace LibraryMgrProgram
{
    public partial class AdminInputOutputForm : Form
    {
        MouseEvent me = new MouseEvent();
        dbTest db = new dbTest();
        public AdminInputOutputForm()
        {
            InitializeComponent();
        }
        //0.CNumber, 1.CRank, 2.CID, 3.CPW, 4.CName, 5.CLoanCot ,6.CAccrue, 7.CPH, 8.CBirth, 9.CAddress, 10.CDate , 11.CGender, 12.CMemo
        // 폼로드시
        private void AdminInputOutputForm_Load(object sender, EventArgs e)
        {
            string bookSQL = "select * from Book;";
            string cusSQL = "select * from Customer where CNumber > 1;";
            me.reloadForm(bookSQL, gdvAIOBView, 0);
            me.reloadForm(cusSQL, gdvAIOMView, 1);
        }
        // 맴버 그리드뷰 선택시
        private void gdvAIOMView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tacAIOMain.SelectedIndex == 0)
            {
                MemberlistDescription();
            }
            else
            {
                try
                {
                    MemberlistDescription0();
                    string number = lbAIOMNumView1.Text;
                    // 대출한 사람을 클릭하였을 도서 그리드뷰에서는 해당 대출자가 대출한 리스트를 출력하는 sql문
                    string bookSql = "select distinct BNumber, BName, BPublisher, BAuthor, BCount, BGenre, BProduct, Barea, BISBN, BPage, BLocal, BDate, BContent, BAddDate " +
                        "from LoanList, Book " +
                        "Where LoanList.LBookNum = Book.BNumber and LoanList.LCustomerNum = " + number + ";";
                    me.reloadForm(bookSql, gdvAIOBView, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // (0.BNumber ,1.BName, 2.BPublisher, 3.BAuthor, 4.BCount, 5.BGenre, 6.BProduct, 7.Barea, 8.BISBN, 9.Bpage ,10.BLocal, 11.BDate, 12.BContent)

        private void gdvAIOBView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tacAIOMain.SelectedIndex == 0)
            {
                BooklistDescription();
            }
            else
            {
                try
                {
                    BooklistDescription0();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // 대출버튼
        private void btnAIOLone_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbAIOMNumView0.Text.Equals("") || lbAIOBNumView0.Text.Equals(""))
                {
                    MessageBox.Show("도서와 회원을 선택해주세요");
                }
                else
                {
                    string cusNum = lbAIOMNumView0.Text;
                    string bookNum = lbAIOBNumView0.Text;
                    MessageBox.Show("cusNum = " + cusNum + "\nbookNum = " + bookNum);
                    // 고객/ 책의 개수 파악
                    string accureSql = "select CAccrue from Customer where CNumber = '" + cusNum + "';";
                    string cusSql = "select CLoanCot from Customer where CNumber = '" + cusNum + "';";
                    string bookSQL = "select BCount from Book where BNumber = '" + bookNum + "';";
                    // 고객이 동일한 책을 빌렸는지 확인하기 위한 sql문
                    string chkSQL = "select LCustomerNum, LBookNum from LoanList where LCustomerNum = '" + cusNum + "' and LBookNum = '" + bookNum + "';";


                    int chkCount = chkLoan(chkSQL);
                    int cusAccureCount = chkLoan(accureSql);
                    int cusCount = chkLoan(cusSql);
                    int bookCount = chkLoan(bookSQL);

                    //빌릴 수 있는 상황 책의 수 0개 회원이 대출 가능 책 수 0개 이상이며, 동일한 책을 빌리지 않았을 때
                    if (cusCount > 0 && bookCount > 0 && chkCount == 0)
                    {
                        // 각각에 맞게 sql문 만들기 (개수 줄이기)
                        string newCusSQL = "update Customer set CLoanCot = '" + --cusCount + "' , CAccrue = '" + ++cusAccureCount + "' where CNumber = '" + cusNum + "';";
                        string newBookSQL = "update Book set BCount = '" + --bookCount + "' where BNumber = '" + bookNum + "';";
                        //대출리스트에 추가하기 위한 sql문
                        string loanAddSql = "insert into LoanList (LCustomerNum , LBookNum, LTime) values ("
                                            + cusNum
                                            + ", " + bookNum
                                            + ", '" + new DateTime().AddDays(8).ToString("yyyy/MM/dd") + "');"; //날짜가 이상함 바꿔야함
                                                                                                                //업데이트 진행
                        db.dbUpdate(newCusSQL);
                        db.dbUpdate(newBookSQL);
                        db.dbUpdate(loanAddSql);
                    }
                    //개수가 없다면
                    else
                    {
                        if (cusCount == 0)
                        {
                            MessageBox.Show("대출가능 권수가 초과하였습니다.");
                        }
                        if (chkCount > 0)
                        {
                            MessageBox.Show("동일한 책을 이미 빌리셨습니다.");
                        }
                    }
                    db.conn.Clone();
                    string sql = "select * from Book;";
                    me.reloadForm(sql, gdvAIOBView, 0);
                    string sql0 = "select * from Customer where CNumber > 1;";
                    me.reloadForm(sql0, gdvAIOMView, 1);
                }
            }catch (Exception)
            {
                MessageBox.Show("대출에 실패하였습니다.");
            }
        }


        // 도서 검색버튼
        private void btnAIOBSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gdvAIOBView.Columns.Clear();
                if (txtAIOBSearch.Text == "")
                {
                    string sql = "select * from Book;";
                    me.reloadForm(sql, gdvAIOBView, 0);
                }
                else
                {
                    if (cboxAIOBSort.SelectedItem.Equals("제목"))
                    {
                        string sql = ("select * from Book where BName Like '%" + txtAIOBSearch.Text + "%';").ToString();
                        me.reloadForm(sql, gdvAIOBView, 0);
                        BooklistDescription();
                    }
                    else if (cboxAIOBSort.SelectedItem.Equals("저자"))
                    {
                        string sql = ("select * from Book where BAuthor Like '%" + txtAIOBSearch.Text + "%';").ToString();
                        me.reloadForm(sql, gdvAIOBView, 0);
                        BooklistDescription();
                    }
                    else if (cboxAIOBSort.SelectedItem.Equals("장르"))
                    {
                        string sql = ("select * from Book where BGenre Like '%" + txtAIOBSearch.Text + "%';").ToString();
                        me.reloadForm(sql, gdvAIOBView, 0);
                        BooklistDescription();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("검색내용이 없습니다.");
                string sql = "select * from Book;";
                me.reloadForm(sql, gdvAIOBView, 0);
            }
        }

        // 회원 검색버튼
        private void btnAIOMSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gdvAIOMView.Columns.Clear();
                if (txtAIOMSearch.Text == "")
                {
                    string sql = "select * from Customer where CNumber > 0;";
                    me.reloadForm(sql, gdvAIOMView, 1);
                }
                else
                {
                    if (cboxAIOMSort.SelectedItem.Equals("이름"))
                    {
                        string sql = ("select * from Customer where CName Like '%" + txtAIOMSearch.Text + "%';").ToString();
                        me.reloadForm(sql, gdvAIOMView, 1);
                    }
                    else if (cboxAIOMSort.SelectedItem.Equals("아이디"))
                    {
                        string sql = ("select * from Customer where CID Like '%" + txtAIOMSearch.Text + "%';").ToString();
                        me.reloadForm(sql, gdvAIOMView, 1);
                    }
                    else if (cboxAIOMSort.SelectedItem.Equals("생년월일"))
                    {
                        string sql = ("select * from Customer where CBirth Like '%" + txtAIOMSearch.Text + "%';").ToString();
                        me.reloadForm(sql, gdvAIOMView, 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("검색내용이 없습니다.");
                string sql = "select * from Customer where CNumber > 0;";
                me.reloadForm(sql, gdvAIOMView, 1);
            }
           
        }

        private void btnAIOReturn_Click(object sender, EventArgs e)
        {

            if (lbAIOMNumView1.Text.Equals("") || lbAIOBNumView1.Text.Equals(""))
            {
                MessageBox.Show("도서와 회원을 선택해주세요");
            }
            else
            {
                string cusNum = lbAIOMNumView1.Text;
                string bookNum = lbAIOBNumView1.Text;
                try
                {
                    MessageBox.Show("cusNum = " + cusNum + "\nbookNum = " + bookNum);
                    string chkloan = "select LCustomerNum, LBookNum from LoanList where LCustomerNum = '" + cusNum + "' and LBookNum = '" + bookNum + "';";
                    int chkCount = chkLoan(chkloan);
                    MessageBox.Show(chkCount.ToString());

                    string cusSql = "select CLoanCot from Customer where CNumber = '" + cusNum + "';";
                    string bookSQL = "select BCount from Book where BNumber = '" + bookNum + "';";

                    int cusCount = chkLoan(cusSql);
                    int bookCount = chkLoan(bookSQL);

                    if (chkCount > 0)
                    {

                        // 각각에 맞게 sql문 만들기 (개수 줄이기)
                        string newCusSQL = "update Customer set CLoanCot = '" + ++cusCount + "' where CNumber = '" + cusNum + "';";
                        string newBookSQL = "update Book set BCount = '" + ++bookCount + "' where BNumber = '" + bookNum + "';";
                        //대출리스트에 추가하기 위한 sql문
                        string loanDeleteSql = "delete from LoanList where LCustomerNum = '" + cusNum + "' and LBookNum = '" + bookNum + "';";
                        //업데이트 진행
                        db.dbUpdate(newBookSQL);
                        db.dbUpdate(newCusSQL);
                        db.dbUpdate(loanDeleteSql);
                    }
                    MessageBox.Show("성공적으로 반납을 진행하였습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAIOExtension_Click(object sender, EventArgs e)
        {

        }


        // 대출 가능 여부 확인용
        private int chkLoan(string sql)
        {
            try
            {
                db.dbConnection();
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                int result = 0;
                while (dbReader.Read())
                {
                    result = Int32.Parse(dbReader[0].ToString());
                }
                return result;
                dbReader.Close();
                db.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void tacAIOMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("전환이 이루어짐");
            if (tacAIOMain.SelectedIndex == 1)
            {
                try
                {
                    string bookSql = ("select * from Book where BNumber = '0';").ToString();
                    me.reloadForm(bookSql, gdvAIOBView, 0);
                    string cusSql = ("select distinct CNumber, CRank, CID, CPW, CName, CLoanCot, CAccrue, CPH, CBirth, CAddress, CDate, CGender, CMemo from LoanList INNER JOIN Customer ON LoanList.LCustomerNum = Customer.CNumber;").ToString();
                    me.reloadForm(cusSql, gdvAIOMView, 1);
                    MemberlistDescription0();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("회원 출력도중에 에러가 발생하였습니다. \n" + ex.Message);
                }
            }
            else
            {
                string sql = ("select * from Book;").ToString();
                me.reloadForm(sql, gdvAIOBView, 0);
                string cusSql = ("select * from Customer where CNumber > 1 ;").ToString();
                me.reloadForm(cusSql, gdvAIOMView, 1);
                MemberlistDescription();
                BooklistDescription();
            }
        }

        //대출페이지 글
        private void MemberlistDescription()
        {
            DataGridViewRow row = gdvAIOMView.SelectedRows[0];
            lbAIOMNumView0.Text = row.Cells[0].Value.ToString();
            lbAIOMRankView0.Text = row.Cells[1].Value.ToString();
            lbAIOMNameView0.Text = row.Cells[4].Value.ToString();
            lbAIOMCountView0.Text = row.Cells[5].Value.ToString();
            lbAIOMHPView0.Text = row.Cells[7].Value.ToString();
            lbAIOBirthView0.Text = row.Cells[8].Value.ToString();
            lbAIOMAddrView0.Text = row.Cells[9].Value.ToString();
            lbAIOSexView0.Text = row.Cells[11].Value.ToString();
            lbAIOMMemoView0.Text = row.Cells[12].Value.ToString();

            string rank = lbAIOMRankView0.Text;
            int loanCount = 0;
            if (rank.Equals("1") || rank.Equals("2") || rank.Equals("3"))
            {
                loanCount = Int32.Parse(rank);
            }
            else if (rank.Equals("N"))
            {
                loanCount = 1;
            }
            lbAIOMCountView0.Text += "/" + (9 / loanCount).ToString();
        }
        //반납 페이지 글
        private void MemberlistDescription0()
        {
            DataGridViewRow row = gdvAIOMView.SelectedRows[0];
            lbAIOMNumView1.Text = row.Cells[0].Value.ToString();
            lbAIOMRankView1.Text = row.Cells[1].Value.ToString();
            lbAIOMNameView1.Text = row.Cells[4].Value.ToString();
            lbAIOMCountView1.Text = row.Cells[5].Value.ToString();
            lbAIOMHPView1.Text = row.Cells[7].Value.ToString();
            lbAIOBirthView1.Text = row.Cells[8].Value.ToString();
            lbAIOMAddrView1.Text = row.Cells[9].Value.ToString();
            lbAIOSexView1.Text = row.Cells[11].Value.ToString();
            lbAIOMMemoView1.Text = row.Cells[12].Value.ToString();

            string rank = lbAIOMRankView1.Text;
            int loanCount = 0;
            if (rank.Equals("1") || rank.Equals("2") || rank.Equals("3"))
            {
                loanCount = Int32.Parse(rank);
            }
            else if (rank.Equals("N"))
            {
                loanCount = 1;
            }
            lbAIOMCountView1.Text += "/" + (9 / loanCount).ToString();
        }

        private void BooklistDescription()
        {
            DateTime maxTime = DateTime.Now;
            DataGridViewRow row = gdvAIOBView.SelectedRows[0];
            lbAIOBNumView0.Text = row.Cells[0].Value.ToString();
            lbAIOBNameView0.Text = row.Cells[1].Value.ToString();
            lbAIOBPubliView0.Text = row.Cells[2].Value.ToString();
            lbAIOBAuthorView0.Text = row.Cells[3].Value.ToString();
            lbAIOBCountView0.Text = row.Cells[4].Value.ToString();
            lbAIOBISBNView0.Text = row.Cells[8].Value.ToString();
            lbAIOBPageView0.Text = row.Cells[9].Value.ToString();
            lbAIOBAddrView0.Text = row.Cells[10].Value.ToString();
            // 대출기간은 +7~14한 날짜여야함으로 바뀌어야함
            lbAIOBTimeView0.Text = maxTime.ToString("yyyy/MM/dd") + " ~ " + maxTime.AddDays(8).ToString("yyyy/MM/dd");
        }

        private void BooklistDescription0()
        {
            DateTime maxTime = DateTime.Now;
            DataGridViewRow row = gdvAIOBView.SelectedRows[0];
            lbAIOBNumView1.Text = row.Cells[0].Value.ToString();
            lbAIOBNameView1.Text = row.Cells[1].Value.ToString();
            lbAIOBPubliView1.Text = row.Cells[2].Value.ToString();
            lbAIOBAuthorView1.Text = row.Cells[3].Value.ToString();
            lbAIOBCountView1.Text = row.Cells[4].Value.ToString();
            lbAIOBISBNView1.Text = row.Cells[8].Value.ToString();
            lbAIOBPageView1.Text = row.Cells[9].Value.ToString();
            lbAIOBAddrView1.Text = row.Cells[10].Value.ToString();
            // 대출기간은 +7~14한 날짜여야함으로 바뀌어야함
            lbAIOBTimeView1.Text = maxTime.ToString("yyyy/MM/dd") + " ~ " + maxTime.AddDays(8).ToString("yyyy/MM/dd");
        }

    }
}
