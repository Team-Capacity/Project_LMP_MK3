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
using LMP_Projcet.Methods;
using LMP_Projcet.Customer;
using MySql.Data.MySqlClient;

namespace LibraryMgrProgram.NonCustomerForm
{
    public partial class NonCustomerContentsForm : Form
    {
        public NonCustomerContentsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        dbTest db = new dbTest();
        FormChange fc = new FormChange();
        private void NonCustomerContentsForm_Load(object sender, EventArgs e)
        {
            Label[] back = { lbNCCNotic, lbNCCBestBook, lbNCCBookName0, lbNCCAuthor0, lbNCCBookName1, lbNCCAuthor1, lbNCCBookName3, lbNCCAuthor3, lbNCCBookName4, lbNCCAuthor4 };
            fc.fromColorChange(this);
            fc.fromColorChange(back,back);
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

            txtNCCNotice.Text = content;
            txtNCCNotice.Font = new Font("맑은 고딕", 40, FontStyle.Bold);
            Book();


        }

        private void Book()
        {
            db.dbConnection();
            string sql = "select BName,BAuthor from Book order by BNumber desc limit 4;";
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


            lbNCCBookName0.Text = splitName[1];
            lbNCCAuthor0.Text = splitAuthor[1];

            lbNCCBookName1.Text = splitName[2];
            lbNCCAuthor1.Text = splitAuthor[2];

            lbNCCBookName3.Text = splitName[3];
            lbNCCAuthor3.Text = splitAuthor[3];

            lbNCCBookName4.Text = splitName[4];
            lbNCCAuthor4.Text = splitAuthor[4];

            reader.Close();
            db.conn.Close();
        }
    }
}
