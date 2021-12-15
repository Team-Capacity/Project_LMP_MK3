using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet;
using LMP_Projcet.Admin;
using LMP_Projcet.Methods;
using MySql.Data.MySqlClient;

namespace LibraryMgrProgram
{
    public partial class AdminNoticeForm : Form
    {
        public AdminNoticeForm()
        {
            InitializeComponent();
        }

        MouseEvent mouseEvent = new MouseEvent();
        dbTest db = new dbTest();


        private void plnAM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plnAM_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnAM_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnAM_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void btnLFMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnLFMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnLFClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }


        //공지사항 db쪽 내용 가져옴
        private void select1()
        {
            string sql = "select * from lmp.noticeList ORDER BY NNumber DESC;";
            mouseEvent.reloadForm(sql, dgvANList, 2);


            DataGridViewColumn column = dgvANList.Columns[2];
            dgvANList.Columns[0].Width = 100;
            dgvANList.Columns[2].Width = 200;
        }

        //공지사항 들어가면 자동으로 최신 공지사항 내용을 출력해주도록 함
        private void select2()
        {
            db.dbConnection();
            string sql2 = "select NName, NContent from lmp.noticeList order by NNumber desc limit 1;";


            MySqlCommand cmd = new MySqlCommand(sql2, db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string content = "";
            string name = "";

            while (reader.Read())
            {

                name = reader[0].ToString();
                content = reader[1].ToString();
            }

            reader.Close();
            db.conn.Close();

            txtANNoticeView.Text = name;
            txtANNoticeCont.Text = content;
            txtANNoticeView.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            txtANNoticeCont.Font = new Font("맑은 고딕", 25, FontStyle.Bold);
        }



        public void AdminNoticeForm_Load(object sender, EventArgs e)
        {
            select1();
            select2();
        }

     


        private void dgvANList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Discrption();
        }



        private void Discrption()
        {

            // 조회부분
            DataGridViewRow row = dgvANList.SelectedRows[0];

            txtANNoticeView.Text = row.Cells[1].Value.ToString();
            txtANNoticeCont.Text = row.Cells[2].Value.ToString();

            txtANNoticeView.Font = new Font("맑은고딕", 15, FontStyle.Bold);
            txtANNoticeCont.Font = new Font("맑은고딕", 25, FontStyle.Bold);

            dgvANList.MultiSelect = false;
           

        }

        private void btnANListFind_Click(object sender, EventArgs e)
        {
            if (comANSerList.SelectedItem.Equals("제목"))
            {
                string sql = ("select * from lmp.NoticeList where NName Like '%" + txtANInput.Text + "%';").ToString();
                mouseEvent.reloadForm(sql, dgvANList, 2);
            }
        }
        FormChange fc = new FormChange();

   

        //textbox 수정 허용/불가
        private void ReadOnlyF()
        {
            txtANNoticeView.ReadOnly = false;
            txtANNoticeCont.ReadOnly = false;
        }

        private void ReadOnlyT()
        {
            txtANNoticeView.ReadOnly = true;
            txtANNoticeCont.ReadOnly = true;
        }

        private void btnANClear_Click(object sender, EventArgs e)
        {

            txtANNoticeView.Clear();
            txtANNoticeCont.Clear();
            ReadOnlyF();

        }

        private void btnANModi_Click(object sender, EventArgs e)
        {

            db.dbConnection();
            DataGridViewRow row = dgvANList.SelectedRows[0];
            int number = Int32.Parse(row.Cells[0].Value.ToString());

            string mysql = "Update lmp.NoticeList set NName = '" + txtANNoticeView.Text
                    + "', NContent = '" + txtANNoticeCont.Text + "'"
                    + " where NNumber = " + number +";";

            try
            {
                MySqlCommand cmd = new MySqlCommand(mysql, db.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공적으로 수정이 되었습니다.");
                    mouseEvent.reloadForm("select * from lmp.NoticeList ORDER BY NNumber DESC;", dgvANList, 2);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnANDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvANList.SelectedRows[0];

            int number = Int32.Parse(row.Cells[0].Value.ToString());
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.dbConnection();
                string mysql = "delete from lmp.NoticeList where NNumber = " + number + ";";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(mysql, db.conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("성공적으로 삭제 되었습니다.");
                        mouseEvent.reloadForm("select * from lmp.NoticeList ORDER BY NNumber DESC;", dgvANList, 2);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnANAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtANNoticeCont.Text) || !string.IsNullOrWhiteSpace(txtANNoticeView.Text))
            {

                string Date = DateTime.Now.ToString("yyyy-MM-dd");
                string sql = "insert into noticeList(NName , NContent , NDate) values("
                        + "'" + txtANNoticeView.Text + "'"
                        + ",'" + txtANNoticeCont.Text + "'"
                        + ",'" + Date + "'"
                        + ");";

                db.dbUpdate(sql);
                string reloadSql = "select * from lmp.noticeList ORDER BY NNumber DESC;";
                mouseEvent.reloadForm(reloadSql, dgvANList, 2);

                db.conn.Close();


            }

            else
            {
                MessageBox.Show("제목 및 내용을 입력해 주세요");
                return;
            }
        }



        //dgv header 부분 눌렀을때 정렬 안되게 막는 메소드
        private void NotSort(DataGridView dgvANList)
        {
            foreach (DataGridViewColumn i in dgvANList.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

      
    }
}