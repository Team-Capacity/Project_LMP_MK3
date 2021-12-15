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

namespace LibraryMgrProgram.CustomerForm
{
    public partial class CustomerContentsForm : Form
    {
        public CustomerContentsForm()
        {
            InitializeComponent();
        }
        MouseEvent me = new MouseEvent();
        dbTest db = new dbTest();

        private void CustomerContentsForm_Load(object sender, EventArgs e)
        {
            db.dbConnection();
            string sql = "select NContent from NoticeList order by NNumber desc limit 1;";
            

                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                string content = "";

                while(reader.Read())
                {
                content = reader[0].ToString();
                }

                 reader.Close();

                 txtCCNotice.Text = content;
                 txtCCNotice.Font = new Font("맑은 고딕", 40, FontStyle.Bold);


        }
    }
}
