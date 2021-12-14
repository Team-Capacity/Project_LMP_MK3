using System;
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
        MouseEvent mouseEvent = new MouseEvent();
        dbTest db = new dbTest();
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

        private void AdminSuggestionForm_Load(object sender, EventArgs e)
        {
            string qdate = "";
            lvASList.FullRowSelect = true;
            db.dbConnection();

            string sql = "select * from QuestionList;";
            MySqlCommand cmd = new MySqlCommand(sql, db.conn);


            lvASList.Items.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            MessageBox.Show("2차");
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(reader["QNumber"].ToString());
                item.SubItems.Add(reader["QName"].ToString());
                item.SubItems.Add(reader["QDate"].ToString());
                item.SubItems.Add(reader["QWriter"].ToString());
                item.SubItems.Add(reader["QContent"].ToString());

                lvASList.Items.Add(item);
                MessageBox.Show("차");
            }
            reader.Close();
        }
    }
}
