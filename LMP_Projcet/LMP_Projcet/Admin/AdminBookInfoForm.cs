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

        public AdminBookInfoForm()
        {
            InitializeComponent();
        }

        dbTest db = new dbTest();
        MouseEvent me = new MouseEvent();
        DataTable dbdataset;
        BindingSource bSource;

        string[] name = { "책 번호", "제목", "출판사", "저자", "갯수", "장르","출판 지역", "책 본고장", "ISBN", "페이지", "책의 위치", "날짜", "설명" };

        private void AdminBookInfoForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from LibaryProgram_DB.Book;";
            reloadForm(sql);
        }

        private void reloadForm(string sqlQuery)
        {
            db.dbConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(sqlQuery, db.conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dgvABIBookList.DataSource = bSource;
                sda.Update(dbdataset);


                for (int i = 0; i < 13; i++)
                {
                    dgvABIBookList.Columns[i].HeaderText = name[i];
                }
                dgvABIBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvABIBookList.AllowUserToAddRows = false;

                int count = dgvABIBookList.Rows.Count;
                if (count < 20)
                {
                    for(int i = 0; i< 20 - count; i++)
                    {
                        dbdataset.Rows.Add(null, "", "", "", null, "", "", "", "", null, "", null, "");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
            

        private void btnABIImgUplode2_Click(object sender, EventArgs e)
        {
            me.ImageUpload(ImgAMView2);
        }

        private void btnABIOk2_Click(object sender, EventArgs e)
        {
            DateTime ad = DateTime.Now;
            try
            {
                db.dbConnection();
                int number = 8;
                string sql = "insert into Book(BNumber,BName, BPublisher, BAuthor, BCount, BGenre, BProduct, Barea, BISBN, Bpage, BLocal, BDate, BContent) values("
                    + number
                    + ",'"+ txtABIBookName2.Text+ "'"
                    + ",'"+ txtABICompany2.Text+ "'"
                    + ",'"+ txtABIBookMaker2.Text+ "'"
                    + "," + Int32.Parse(txtABIBookCount2.Text)
                    + ",'"+ comABIBookger2.Text + "'"
                    + ",'"+ txtAMIMakePlace2.Text+ "'"
                    + ",'대한민국'"
                    + ",'"+ txtABIISBN2.Text+ "'"
                    + "," + Int32.Parse(txtAMIBookpage2.Text)
                    + ",'"+ txtABIBLocation2.Text+ "'"
                    + ",'"+ ad + "'"
                    + ",'"+ rtxtABIBBookExp2.Text + "'"
                    +");";

                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공적으로 추가 되었습니다.");
                    db.conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("DB수정에 실패하였습니다.");
            }
        }

        private void btnABIClear2_Click(object sender, EventArgs e)
        {
            me.ftpList();
        }

        private void btnABISer_Click(object sender, EventArgs e)
        {
            dgvABIBookList.Columns.Clear();
            if(txtABISerBar.Text == "")
            {
                string sql = "select * from LibaryProgram_DB.Book;";
                reloadForm(sql);
            }
            else
            {
                string sql = ("select * from Book where BName = '" + txtABISerBar.Text + "';").ToString();
                reloadForm(sql);
            }
        }

        private void dgvABIBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listDescription();
        }

        private void listDescription()
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

            // 추가
            
            // 수정
        }
    }
}
