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
using LMP_Projcet;
using LMP_Projcet.Methods;
using MySql.Data.MySqlClient;

namespace LMP_Projcet.Customer
{
    public partial class CustomerNoticeForm : Form
    {
        public CustomerNoticeForm()
        {
            InitializeComponent();
        }

        MouseEvent mouseEvent = new MouseEvent();
        dbTest db = new dbTest();
        int i;

        private void plnCN_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnCN_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e,this);
        }

        private void plnCN_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }


        private void btnCNMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnCNMax_Click_1(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnCNClose_Click_1(object sender, EventArgs e)
        {
            CustomerOperationForm.chkShow1 = false;
            mouseEvent.ButtonClose(this);
        }





        private void plnCN_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void CustomerNoticeForm_Load(object sender, EventArgs e)
        {
            db.dbConnection();
            string sql = "select * from lmp.noticelist;";
            MySqlCommand cmd = new MySqlCommand(sql, db.conn);
        

            lvCNList.Items.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["NNumber"].ToString());
                item.SubItems.Add(reader["NName"].ToString());
                item.SubItems.Add(reader["NContent"].ToString());
                item.SubItems.Add(reader["NDate"].ToString());
                

                lvCNList.Items.Add(item);
            }
            reader.Close();





        }

     
    }
}
