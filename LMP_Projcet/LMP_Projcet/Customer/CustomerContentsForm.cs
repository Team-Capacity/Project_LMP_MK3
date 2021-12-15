using LMP_Projcet.Methods;
using MySql.Data.MySqlClient;
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
using LMP_Projcet;

namespace LibraryMgrProgram.CustomerForm
{
    public partial class CustomerContentsForm : Form
    {
        public CustomerContentsForm()
        {
            InitializeComponent();
        }
        dbTest db = new dbTest();
        FormChange fc = new FormChange();
        MouseEvent me = new MouseEvent();

        private void CustomerContentsForm_Load(object sender, EventArgs e)
        {
            fc.fromColorChange(this);
            Label[] back = { lbCCNotic, lbCCBestBook, lbCCStatus, lbCCBookName1,  lbAuthor1,  lbCCBookName3, lbAuthor3, lbCCBookName5, lbAuthor5 };
            fc.fromColorChange(back,back);

            Content();
            Book();
            try
            {
                string sql = "select distinct BNumber, BName, BPublisher, BAuthor, BCount, BGenre, BProduct, Barea, BISBN, BPage, BLocal, BDate, BContent, BAddDate " +
                        "from LoanList, Book " +
                        "Where LoanList.LBookNum = Book.BNumber and LoanList.LCustomerNum = " + LoginForm.number + ";";
                me.reloadForm(sql, dgvCCInfo, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("에러발생");
            }


        }

        //최근 등록된 책 3권 로드되도록

        private void Book()
        {
            db.dbConnection();
            string sql = "select BName,BAuthor from Book order by BNumber desc limit 3;";
            MySqlCommand cmd = new MySqlCommand(sql, db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            StringBuilder name = new StringBuilder();
            StringBuilder author = new StringBuilder();
            

            while (reader.Read())
            {
                string a = reader[0].ToString();
                name.Append("," + a);

                string b = reader[1].ToString();
                author.Append("," + b);
            }

            string chkName = name.ToString();
            string[] splitName = chkName.Split(',');

            string chkAuthor = author.ToString();
            string[] splitAuthor = chkAuthor.Split(',');


            lbCCBookName1.Text = splitName[1];
            lbAuthor1.Text = splitAuthor[1];

            lbCCBookName3.Text = splitName[2];
            lbAuthor3.Text = splitAuthor[2];

            lbCCBookName5.Text = splitName[3];
            lbAuthor5.Text = splitAuthor[3];

            reader.Close();
            db.conn.Close();
        }

        //최신공지사항이 로드되도록
        private void Content()
        {
            db.dbConnection();
            string sql = "select NContent from NoticeList order by NNumber desc limit 1;";
            MySqlCommand cmd = new MySqlCommand(sql, db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string content = "";

            while (reader.Read())
            {
                content = reader[0].ToString();
            }

            reader.Close();
            db.conn.Close();

            txtCCNotice.Text = content;
            txtCCNotice.Font = new Font("맑은 고딕", 40, FontStyle.Bold);

        }
    }
}
