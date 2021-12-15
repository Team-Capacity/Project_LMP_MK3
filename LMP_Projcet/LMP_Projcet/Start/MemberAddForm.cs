using LibraryMgrProgram;
using LMP_Projcet.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet.Methods.DB;
using LMP_Projcet;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace LMP_Projcet.Start


{
    public partial class MemberAddForm : Form
    {
        int count = 0;
        dbTest db = new dbTest();
        public MemberAddForm()
        {
            InitializeComponent();
        }



        private void MemberAddForm_Load(object sender, EventArgs e)
        {

            TtMA.SetToolTip(txtMA_Name, "2~5글자 한글로만 작성해주세요");
            TtMA.SetToolTip(txtMA_Pw, "특수문자+영문자+숫자로 이루어져야 하며 8자 이상이어야 합니다.");
            TtMA.SetToolTip(txtAM_Address, "ex)서울특별시 강북구 미아동");
            TtMA.SetToolTip(txtMA_Phone, "번호중간에 - 를 입력해주세요.");

            //처음 표시되는 시간
            TtMA.InitialDelay = 100;
            //다시 표시되는 시간
            TtMA.ReshowDelay = 100;
            //생년월일 콤보박스에 값 추가
            int choice;
            for (choice = 1920; choice < 2020; choice++)
            {
                cmbMA_Year.Items.Add(choice);
            }
            



            //비밀번호 *표시로, 최대길이는 16
            txtMA_Pw.PasswordChar = '*';
            txtMA_Pw.MaxLength = 16;

            txtMA_PwCheck.PasswordChar = '*';
            txtMA_PwCheck.MaxLength = 16;




        }


        MouseEvent mouseEvent = new MouseEvent();


        private void plnMA_MouseUp(Object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void plnMA_MouseDown(Object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnMA_MouseMove(Object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnMA_Paint(object sender, PaintEventArgs e)
        {



        }

        private void btnMAMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnMAMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnMAClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
        }





        private void btnMA_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnMA_IdCheck_Click(object sender, EventArgs e)
        {
            db.dbConnection();
            string id = txtMA_Id.Text;
            string sql = "select Count(CID) as CID from Customer where CID = '" + id + "'";
            int count = 0;
            


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();

                while (dbReader.Read())
                {
                    count = Int32.Parse(dbReader["CID"].ToString());
                   
                }

                if (count == 1)
                {
                    MessageBox.Show("중복된 아이디입니다.");
                }
                else if (id.Equals(""))
                {
                    MessageBox.Show("아이디를 입력하여 주세요.");
                }
                else if (!IsValID(txtMA_Id.Text))
                {
                    MessageBox.Show("아이디는 숫자와 영어로만 구성해주세요");
                }
                else
                {
                    btnMA_Join.Enabled = true;
                    MessageBox.Show("사용가능한 아이디입니다.");
                }


                dbReader.Close();
                count++;
            }
            catch (Exception)
            {
                MessageBox.Show("select문에 실패하였습니다.");
                throw;
            }
        }


        private void btnMA_Join_Click(object sender, EventArgs e)
        {

            db.dbConnection();
            string id = txtMA_Id.Text;
            string pw = txtMA_Pw.Text;
            string passwordcheck = txtMA_PwCheck.Text;
            string name = txtMA_Name.Text;
            string PH = txtMA_Phone.Text;
            string Year = cmbMA_Year.Text;
            string Month = cmbMA_Month.Text;
            string Day = cmbMA_Day.Text;
            string Address = txtAM_Address.Text;

            
            try
            {


                if (!IsValName(txtMA_Name.Text))
                {
                    MessageBox.Show("이름을 한글로 2~5글자로 입력해주세요");
                    return;
                }

                if (!IsValidPassword(txtMA_Pw.Text))
                {
                    MessageBox.Show("비밀번호는 8글자이상, 영문, 숫자, 특수문자를 포함해야합니다.");
                    return;
                }

                if (txtMA_Pw.Text != txtMA_PwCheck.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요.");
                    return;
                }
               /* if (!IsValAddress(txtAM_Address.Text))
                {
                    MessageBox.Show("시/도 구/군 면/동으로 작성해주세요.");
                    return;
                }*/

                if (!IsValYear(cmbMA_Year.Text))
                {
                    MessageBox.Show("년도에 숫자와 4글자로입력해주세요.");
                    return;
                }

                if (!IsValMonth(cmbMA_Month.Text))
                {
                    MessageBox.Show("월 에 숫자와 2글자로입력해주세요.");
                    return;
                }

                if (!IsValDay(cmbMA_Day.Text))
                {
                    MessageBox.Show("일 에 숫자와 1~2글자로입력해주세요.");
                    return;
                }

                if (!rdbMA_Man.Checked && !rdbMA_Wom.Checked)
                {
                    MessageBox.Show("성별을 선택해주세요.");
                    return;
                }

                if (!IsValPH(txtMA_Phone.Text))
                {
                    MessageBox.Show("핸드폰번호에 - 를 입력하여 번호를 입력해주세요.");
                    return;
                }


                string gender = "";

                if (rdbMA_Man.Checked)
                {
                    gender = "남자";
                }
                else
                {
                    gender = "여성";
                }

                string sql = "insert into Customer(CID, CPW, CName, CPH, CBirth, CAddress, CGender) values("
                    + "'" + txtMA_Id.Text + "'"
                    + ",'" + txtMA_Pw.Text + "'"
                    + ",'" + txtMA_Name.Text + "'"
                    + ",'" + txtMA_Phone.Text + "'"
                    + ",'" + cmbMA_Year.Text + "" + cmbMA_Month.Text + "" + cmbMA_Day.Text + "'"
                    + ",'" + txtAM_Address.Text + "'"
                    + ",'" + gender + "'"
                    + ");";
                db.dbUpdate(sql);
                MessageBox.Show("추가되었습니다.");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("회원추가에 실패하였습니다.");
            }
        }

        private static bool IsValID(string Text)
        {
            Regex Iregex = new Regex(@"^[0-9a-zA-Z]{1,100}$");
            Match Imatch = Iregex.Match(Text);
            return Imatch.Success; 
        }
        private static bool IsValMonth(string Text)
        {
            //숫자만1~2자리
            Regex Mregex = new Regex(@"^[0-9]{1,2}$");
            Match Mmatch = Mregex.Match(Text);
            return Mmatch.Success;
        }
        private static bool IsValDay(string Text)
        {
            //숫자만 1~2자리
            Regex Dregex = new Regex(@"^[0-9]{1,2}$");
            Match Dmatch = Dregex.Match(Text);
            return Dmatch.Success;
        }
        private static bool IsValYear(string Text)
        {
            //숫자만 4자리
            Regex Yregex = new Regex(@"^[0-9]{4}$");
            Match Ymatch = Yregex.Match(Text);
            return Ymatch.Success;
        }

      /*  private static bool IsValAddress(string Text)
        {
            Regex Aregex = new Regex(@"^[\S]+(도|시)\s[\S]+(구|군)\s[\S]+(면|동)");
            Match Amatch = Aregex.Match(Text);
            return Amatch.Success;
        }*/


        private static bool IsValPH(string Text)
        {
            //숫자만 앞자리 2~3자리 주간 3~4자리 마지막 4자리 입력시 - 포함해서
            Regex Pregex = new Regex(@"^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$");
            Match Pmatch = Pregex.Match(Text);
            return Pmatch.Success;
        }
        private static bool IsValName(string Text)
        {
            //한글만 2~4자리
            Regex Nregex = new Regex(@"^[가-힣]{2,4}$");
            Match Nmatch = Nregex.Match(Text);
            return Nmatch.Success;
        }

        private static bool IsValidPassword(string Text)
        {
            //영문, 숫자, 특수문자 포함 8글자 이상
            Regex Pregex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$");
            Match Pmatch = Pregex.Match(Text);
            return Pmatch.Success;
        }
        private void MemberAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        
    }
}
