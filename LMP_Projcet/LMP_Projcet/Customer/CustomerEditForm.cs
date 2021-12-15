using LibraryMgrProgram;
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
using System.Globalization;
using System.Text.RegularExpressions;

namespace LMP_Projcet.Customer
{
    public partial class CustomerEditForm : Form
    {
        

        public CustomerEditForm()
        {
            InitializeComponent();
           
        }
     
        MouseEvent mouseEvent = new MouseEvent();
        dbTest db = new dbTest();
        CustomerMyInfomationForm cmi = new CustomerMyInfomationForm();
        FormChange fc = new FormChange();
        LoginForm lf = new LoginForm();

        //회원탈퇴
        private void btnCusDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말로 탈퇴 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                db.dbConnection();
                
            
                try
                {
                  
                

                    string sql = "delete from lmp.customer where CNumber = " + LoginForm.number + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                    MySqlCommand mc = new MySqlCommand(sql, db.conn);
                    MySqlDataReader reader;

                    reader = mc.ExecuteReader();
                  

                

                    MessageBox.Show("탈퇴가 성공적으로 완료가 되었습니다.");
                    reader.Close();

                    this.Close();
                    Application.Restart();


                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
          
            }
           
        }


        //개인정보 수정 취소 -> 메인화면 개인정보뜬 화면으로 이동
        private void btnCusEditCancel_Click(object sender, EventArgs e)
        {
            CustomerMyInfomationForm.chkShow = false;
            this.Close();
        }
       
        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
          
            db.dbConnection();
          

            string thismyName = CustomerMainForm.myname;
            string myName = thismyName.Substring(0, thismyName.Length - 8);
            string sql = "select * from lmp.Customer where CName = '" + myName + "';";

            MySqlCommand cmd = new MySqlCommand(sql, db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            int number = 0;
            string name = "";
            string ph = "";
            string birth = "";
            string address = "";
            string rank = "";
            string gender = "";
            string memo = "";
            string pw = "";
         

            while (reader.Read())
            {
                number = Int32.Parse(reader[0].ToString());
                rank = reader[1].ToString();
                pw = reader[3].ToString();
                name = reader[4].ToString();
                ph = reader[6].ToString();
                birth = reader[7].ToString();
                address = reader[8].ToString(); 
                memo = reader[11].ToString();
            }

            reader.Close();

          
            lbCEMyNum.Text = number.ToString();
            txtCEMyName.Text = name;
            txtCEHPView.Text = ph;
  
            txtCEMyBirth.Text = birth;
            txtCEMemoView.Text = memo;
            txtCEMyAddrView.Text = address;
            txtCEPW.Text = pw;
            lbCERankView.Text = rank;


            /*
            if (rank.Equals('3'))
            {

            }
            */
        }

        private void btnCEMin_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMinSize(this);
        }

        private void btnCEMax_Click(object sender, EventArgs e)
        {
            mouseEvent.FormMaxSize(this);
        }

        private void btnCEClose_Click(object sender, EventArgs e)
        {
            CustomerMyInfomationForm.chkShow = false;
            mouseEvent.ButtonClose(this);
        }

        private void plnCE_MouseDown(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseDown(e);
        }

        private void plnCE_MouseMove(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseMove(e, this);
        }

        private void plnCE_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEvent.PlanMouseUp();
        }

        private void plnCM_Paint(object sender, PaintEventArgs e)
        {

        }

        //버튼 클릭시 사진 불러오기
        //@"D:w" -> 불러올 초기 위치
        private void btnCELoad_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:w";

            dialog.Filter = "모든파일(*.*)|*.*";
            dialog.RestoreDirectory = true;

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                image_file = dialog.FileName;
                picCMICustomerImg.Image = Bitmap.FromFile(image_file);
                picCMICustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (result == DialogResult.Cancel)
            {
                return;


            }

        }

      
        public void btnCESave_Click(object sender, EventArgs e)
        {

            DateTime csbirth = Convert.ToDateTime(txtCEMyBirth.Text);
        

            db.dbConnection();
            string Query2 = "Update customer set CName = '" + txtCEMyName.Text
                    + "', CPH = '" + txtCEHPView.Text
                    + "', CPW = '" + txtCEPW.Text
                    + "', CBirth = '" + csbirth.Year  + "/" + csbirth.Month +  "/" + csbirth.Day 
                    + "', CAddress = '" + txtCEMyAddrView.Text 
                    + "', CMemo = '" + txtCEMemoView.Text + "'"
                    + "   where CName = '" + LoginForm.name +  "';";
           
            try
            {

                MySqlCommand SelectCommand = new MySqlCommand(Query2, db.conn);
                MySqlDataReader reader;
                reader = SelectCommand.ExecuteReader();
                MessageBox.Show("수정이 완료되었습니다.");            
                reader.Close();

                this.Close();
                Application.Restart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
        private void btnCE_PW_OK_Click(object sender, EventArgs e)
        {

            if (!IsValidPassword(txtCEPW.Text))
            {
                MessageBox.Show("비밀번호는 8글자이상, 영문, 숫자, 특수문자를 포함해야합니다.");
                return;
            }

            else
            {
                MessageBox.Show("비밀번호가 성공적으로 변경이 되었습니다.");
                
            }
        }

        //비밀번호 조건 함수
      private static bool IsValidPassword(string Text)
        {
            //영문, 숫자, 특수문자 포함 8글자 이상
            Regex Pregex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$");
            Match Pmatch = Pregex.Match(Text);
            return Pmatch.Success;
        }

        private void isChecked(bool Checked)
        {
            if (Checked)
            {
                txtCEPW.PasswordChar = '*';
                txtCEPW.MaxLength = 16;

            }
            else
            {
                txtCEPW.PasswordChar = default(char);
                txtCEPW.MaxLength = 16;
             
            }
        }

        private void chkCESecretPW_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(chkCESecretPW.Checked);
        }
    }
}

