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

        MouseEvent me = new MouseEvent();

     
        //DB쪽 내용 Datagridview쪽으로 옮겨와지게함
        private void select1()
        {
            string sql = "select * from NoticeList ORDER BY NNumber DESC;";
            me.reloadForm(sql, dgvCNList, 2);


            DataGridViewColumn column = dgvCNList.Columns[2];
            dgvCNList.Columns[0].Width = 100;
            dgvCNList.Columns[2].Width = 200;

        }

        //공지사항 들어가자마자 가장 최신 공지사항이 뜨게 함.
        private void select2()
        {
            db.dbConnection();
            string sql2 = "select NName, NContent from NoticeList order by NNumber desc limit 1;";


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

            lbCNNoticeView2.Text = name;
            lbCNNoticeView4.Text = content;
            lbCNNoticeView2.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            lbCNNoticeView4.Font = new Font("맑은 고딕", 25, FontStyle.Bold);
        }

        private void CustomerNoticeForm_Load(object sender, EventArgs e)
        {

            select1();
            select2();


        }

        private void dgvCNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Discrption();
        }

        
        public void Discrption()
        {
            try
            {
              

                // 조회부분
                DataGridViewRow row = dgvCNList.SelectedRows[0];
                lbCNNoticeView2.Text = row.Cells[1].Value.ToString();
                lbCNNoticeView4.Text = row.Cells[2].Value.ToString();
                
                lbCNNoticeView2.Font = new Font("맑은고딕", 15, FontStyle.Bold);
                lbCNNoticeView4.Font = new Font("맑은고딕", 25, FontStyle.Bold);

                dgvCNList.MultiSelect = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
         
        }

        private void btnCNListFind_Click(object sender, EventArgs e)
        {
            if (cmbCNSerList.SelectedItem.Equals("제목"))
            {
                string sql = ("select * from NoticeList where NName Like '%" + txtCNInput.Text + "%';").ToString();
                me.reloadForm(sql, dgvCNList, 2);
            }
        }
    }
}
