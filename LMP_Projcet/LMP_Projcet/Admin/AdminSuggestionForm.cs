using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMgrProgram;
using LMP_Projcet.Methods;
using MySql.Data.MySqlClient;

namespace LMP_Projcet.Admin
{
    public partial class AdminSuggestionForm : Form
    {
        dbTest db = new dbTest();

        MouseEvent mouseEvent = new MouseEvent();
        public AdminSuggestionForm()
        {
            InitializeComponent();
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
        // 폼 로드시 셀 출력
        private void AdminSuggestionForm_Load(object sender, EventArgs e)
        {
            loadList();
        }

        //셀 크기 조절 막기 이벤트
        private void lvASList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lvASList.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        //셀 클릭시 발생 이벤트
        private void ItemSelect_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvASList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lvASList.SelectedItems;
                ListViewItem lvItem = items[0];
                string title = lvItem.SubItems[1].Text;
                string date = lvItem.SubItems[2].Text;
                string name = lvItem.SubItems[3].Text;
                string content = lvItem.SubItems[4].Text;
                //string[] splitDate = date.Split('/');
                //string newDate = splitDate[2] + splitDate[1] + splitDate[0];

                txtASTitleView.Text = title;
                lbASRealday.Text = date;
                lbASRealWriter.Text = name;
                txtASContentView.Text = content;

            }
        }
        //데이터 베이스 리스트 불러오는거
        private void loadList()
        {
            string qdate = "";
            DateTime addtime;
            lvASList.FullRowSelect = true;
            db.dbConnection();

            string sql = "SELECT * FROM QuestionList order by QNumber desc;";
            MySqlCommand cmd = new MySqlCommand(sql, db.conn);

            lvASList.Items.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["QNumber"].ToString());
                item.SubItems.Add(reader["QName"].ToString());
                //item.SubItems.Add(reader["QDate"].ToString());
                qdate = reader["QDate"].ToString();
                item.SubItems.Add(string.Format("{0:yyyy-MM=dd HH:mm:dd}", qdate));// 문자 포멧필요
                item.SubItems.Add(reader["QWriter"].ToString());
                item.SubItems.Add(reader["QContent"].ToString());

                lvASList.Items.Add(item);
            }
            reader.Close();
            db.conn.Close();
        }
        // 삭제 버튼 클릭시 삭제하고 갱신
        private void btnASDel_Click(object sender, EventArgs e)
        {
            db.dbConnection();
            int SelectRow = lvASList.SelectedItems[0].Index;
            string a = lvASList.Items[SelectRow].SubItems[0].Text;


            if (MessageBox.Show("정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from QuestionList where QNumber = " + a + ";";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("성공적으로 삭제 되었습니다.");
                        loadList();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            db.conn.Close();
        }
    }
}
