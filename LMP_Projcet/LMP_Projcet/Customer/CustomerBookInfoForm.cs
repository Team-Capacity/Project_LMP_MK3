﻿using LMP_Projcet.Methods;
using LMP_Projcet.Methods.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMP_Projcet.Customer
{
    public partial class CustomerBookInfoForm : Form
    {


        public CustomerBookInfoForm()
        {
            InitializeComponent();
        }

        DataTable dbdataset;
        BindingSource bSource;
        dbConnect dc = new dbConnect();
        dbTest db = new dbTest();

        //Mysql 접근
        private void reload(string sqlQuery)
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
                dgvCBIBookList.DataSource = bSource;
                sda.Update(dbdataset);


                //DB book테이블 컬럼을 DataGridView로 출력하는 반복문
                String[] name = { "책 번호", "제목", "출판사", "저자", "갯수", "장르", "출판 지역", "책 본고장", "ISBN", "페이지", "책의 위치", "발행 날짜", "설명","책 추가 날짜" };
                for (int i = 0; i <= 13; i++)
                {
                    dgvCBIBookList.Columns[i].HeaderText = name[i];
                }

                dgvCBIBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //나머지 컬럼 빈칸으로 보여지게 함.
                for (int i = 0; i < 40; i++)
                {
                    dbdataset.Rows.Add(null, "", "", "", null, "", "", "", "", null, "", null, "",null);
                }


           



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //책 제목 OR 저자 검색시 DataGridView에 해당 조건에 맞는 내용만 보이게 하는 함수
        private void Search(string sqlQuery)
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
                dgvCBIBookList.DataSource = bSource;
                sda.Update(dbdataset);

                //DB book테이블 컬럼을 DataGridView로 출력하는 반복문
                String[] name = { "책 번호", "제목", "출판사", "저자", "갯수", "장르", "출판 지역", "책 본고장", "ISBN", "페이지", "책의 위치", "발행 날짜", "설명", "책추가" };
                for (int i = 0; i < 14; i++)
                {
                    dgvCBIBookList.Columns[i].HeaderText = name[i];
                }


                dgvCBIBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerBookInfoForm_Load(object sender, EventArgs e)
        {
            String sqlQ = "select * from lmp.Book;";
            reload(sqlQ);
        }



        private void dgvCBIBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView 행 클릭시 옆에 자세한 내용 출력
            lbCBIBookName2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[1].Value.ToString();
            lbCBICompany.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[2].Value.ToString();
            lbCBIBookMaker2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[3].Value.ToString();
            lbCBIBookCount2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[4].Value.ToString();
            lbCBIBookger2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[5].Value.ToString();
            lbCBIMakePlace2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[6].Value.ToString();
            lbCBIISBN2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[8].Value.ToString();
            lbCBIBookPage2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[9].Value.ToString();
            lbCBIBLocation2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[10].Value.ToString();
            lbCBIMakeDay2.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[11].Value.ToString();
            lbCBIBBookExp.Text = dgvCBIBookList.Rows[dgvCBIBookList.CurrentCellAddress.Y].Cells[12].Value.ToString();


        }


        //버튼 클릭시 이벤트
        private void btnCBISer_Click(object sender, EventArgs e)
        {

            // dgvCBIBookList.Columns.Clear(); 이거 없어도 될듯


            if (txtCBISerBar.Text == "")
            {
                String sqlQ = "select * from lmp.Book;";
                reload(sqlQ);
            }
            //콤보박스 제목 누를 시 제목으로 책검색, 저자 누를시 저자이름으로 검색 결과 뜨도록 나옴
            else
            {
                if(cmbCBISerList.SelectedItem.Equals("제목"))
                {
                    string sql = ("select * from lmp.Book where BName = '" + txtCBISerBar.Text + "';").ToString();
                    Search(sql);
                }

                else if (cmbCBISerList.SelectedItem.Equals("저자"))
                {
                    string sql = ("select * from lmp.Book where BAuthor = '" + txtCBISerBar.Text + "';").ToString();
                    Search(sql);
                }

            }




        }

       
    }
}


   