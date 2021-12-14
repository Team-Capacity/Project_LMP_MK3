using LibraryMgrProgram;
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
using LMP_Projcet;
using LMP_Projcet.Methods;


namespace LMP_Projcet.Customer
{
    public partial class CustomerWriteForm : Form
    {
        dbTest db = new dbTest();
        public CustomerWriteForm()
        {
            InitializeComponent();


        }

        MouseEvent mouseEvent = new MouseEvent();
        private void plnCus_MouseDown(object sender, MouseEventArgs e)
        {

            mouseEvent.PlanMouseDown(e);
        }

        private void plnCus_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnCus_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }  

     
        private void btnCWMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnCWMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnCWClose_Click(object sender, EventArgs e)
        {
            CustomerOperationForm.chkShow2 = false;
            mouseEvent.ButtonClose(this);
        }

        private void btnCusWriteOk_Click(object sender, EventArgs e)
        {

            string sql = "insert into QuestionList(QName,QWriter,QContent) values("
                    + "'" + txtCWTitle.Text + "'"
                    + ",'" + lbCWMyCusName.Text + "'"
                    + ",'" + txtCWContent.Text + "'"
                    + ");";
            db.dbUpdate(sql);
        }
      

        private void CustomerWriteForm_Load(object sender, EventArgs e)
        {
            lbCWToday.Text = DateTime.Now.ToString("yyyy/MM/dd");

            db.dbConnection();
            string thismyName = CustomerMainForm.myname;
            string myName = thismyName.Substring(0, thismyName.Length - 8);
            string sql = "select * from Customer where CName = '" + myName + "';";

            MySqlCommand cmd = new MySqlCommand(sql, db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string name = "";

            while (reader.Read())
            {
                name = reader[4].ToString();
            }

            lbCWMyCusName.Text = name;
            reader.Close();
            db.conn.Close();

        }

        private void GBCusWriteSuggest_Enter(object sender, EventArgs e)
        {

        }

        //작성중인 내용이 있을때 취소할 경우, 아무내용도 작성 안할때 취소할경우
        private void btnCWCancel_Click(object sender, EventArgs e)
        {

            if (txtCWTitle.TextLength >= 1 || txtCWContent.TextLength >= 1)
            {
                if (MessageBox.Show("현재 입력중인 내용이 있습니다. 정말로 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CustomerOperationForm.chkShow2 = false;
                    this.Close();
                }
                else
                {
                    return;
                }

            }
            else
                CustomerOperationForm.chkShow2 = false;
                this.Close();
            
          
        }

        
    }
}
