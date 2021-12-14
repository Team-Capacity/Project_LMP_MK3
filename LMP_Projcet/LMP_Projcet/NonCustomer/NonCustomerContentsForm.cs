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
        private void NonCustomerContentsForm_Load(object sender, EventArgs e)
        {

            db.dbConnection();
            string sql = "select NContent from lmp.noticelist order by NNumber desc limit 1;";


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
            
        }
    }
}
