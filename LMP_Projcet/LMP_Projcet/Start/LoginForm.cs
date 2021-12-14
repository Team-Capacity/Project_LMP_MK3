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
using LMP_Projcet.Start;
using MySql.Data.MySqlClient;

namespace LMP_Projcet
{


    public partial class LoginForm : Form
    {

        FormChange formChange = new FormChange();
        MouseEvent mouseEvent = new MouseEvent();
        dbTest db = new dbTest();
        public static string name = "";

        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLFNonLogin_Click(object sender, EventArgs e)
        {
            NonCustomerMainForm ncmf = new NonCustomerMainForm();
            ncmf.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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

        private void labLFSearch_Click(object sender, EventArgs e)
        {
            IDPWSearchForm serchf = new IDPWSearchForm();
            formChange.ChangeF(this, serchf);
        }

        private void labLFAddMem_Click(object sender, EventArgs e)
        {
            MemberAddForm MA = new MemberAddForm();
            formChange.ChangeF(this, MA);
        }

        private void txtLFID_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpLogLogin_Enter(object sender, EventArgs e)
        {

        }

    
        private void btnLFLogin_Click(object sender, EventArgs e)
        {
          
            db.dbConnection();
            string id = txtLFID.Text;
            string password = txtLFPW.Text;
            string sql = "select CRank, CName from Customer where CID = '" + id + "'" + "and CPW = '" + password + "';";
            string rank = "";

            try
            {
                if(txtLFID.Text == "")
                {
                    MessageBox.Show("아이디를 입력해주세요.");
                    return;
                }

                if (txtLFPW.Text == "")
                {
                    MessageBox.Show("비밀번호를 입력해주세요.");
                    return;
                }
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                
                while (dbReader.Read())
                {
                    rank = dbReader["CRank"] as String;
                    name = dbReader["CName"] as String;
                }
                if (rank.Equals("M"))
                {
                    AdminMainForm amf = new AdminMainForm();
                    formChange.ChangeF(this, amf);

                }
                else if (rank.Equals("N"))
                {
                    AdminMainForm amf = new AdminMainForm();
                    formChange.ChangeF(this, amf);
                }
                else if (rank.Equals("1") || rank.Equals("2") || rank.Equals("3"))
                {
                    CustomerMainForm cmf = new CustomerMainForm();
                    formChange.ChangeF(this, cmf);
                }
                else if (rank.Equals("F"))
                {
                    MessageBox.Show("블랙리스트에 선정된 회원이므로 접속이 제한되었습니다.");
                }
                else
                {
                    MessageBox.Show("존재하지않은 회원입니다.");
                }
                dbReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("select문에 실패하였습니다.");
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}