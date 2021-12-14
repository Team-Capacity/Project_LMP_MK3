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
using LMP_Projcet;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace LibraryMgrProgram
{
    public partial class IDPWSearchForm : Form
    {
        dbTest db = new dbTest();
        MouseEvent mouseEvent = new MouseEvent();
        public IDPWSearchForm()
        {
            InitializeComponent();
        }

        private void btnSerOK_Click(object sender, EventArgs e)
        {

            db.dbConnection();
            string name = txtSerName.Text;
            string bir = txtSerBir.Text;
            string ph = txtSerPH.Text;
            string sql = "select * from Customer where CName = '" + name + "' and CBirth = '" + bir + "' and CPH = '" + ph + "';";
            string result = "";
            if (txtSerName.Text == "")
            {
                MessageBox.Show("이름 입력해주세요.");
                return;
            }else if (!IsValSePH(txtSerPH.Text))
            {
                MessageBox.Show("번호중간에 - 를 입력하여 번호를 입력해주세요. ex)010-0000-0000");
                return;
            }else if (!IsValSeBir(txtSerBir.Text))
            {
                MessageBox.Show("예시에 맞게작성해주세요. ex)990717");
                return;
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    result = dbReader["CID"] as String;
                }
                if (result.Equals(""))
                {
                    MessageBox.Show("노데이터");
                }
                else
                {
                    MessageBox.Show("아이디 : " + result);
                }
                dbReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("존재하지 않는 회원입니다.");
                throw;
            }
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

        private void btnLFClose_Click(object sender, EventArgs e)
        {
            mouseEvent.ButtonClose(this);
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnSerPwOK_Click(object sender, EventArgs e)
        {
            if (txtSerID.Text == "" && txtSerPwName.Text == "" && txtSerPwBir.Text == "")
            {
                MessageBox.Show("입력해주세요.");
            }

            else if (txtSerID.Text == "" || txtSerPwName.Text == "" || txtSerPwBir.Text == "")
            {
                MessageBox.Show("입력 칸 중 빈칸이있습니다.");
            }
        }
        public static bool IsValSeBir(string Text)
        {

            Regex SBregex = new Regex(@"^[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|[1,2][0-9]|3[0,1])$");
            Match SBmatch = SBregex.Match(Text);
            return SBmatch.Success;
        }
        public static bool IsValSePH(string Text)
        {
            //숫자만 앞자리 2~3자리 주간 3~4자리 마지막 4자리 입력시 - 포함해서
            Regex SPregex = new Regex(@"^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$");
            Match SPmatch = SPregex.Match(Text);
            return SPmatch.Success;
        }
    }
}
