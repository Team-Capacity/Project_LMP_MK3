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
            string sql = "select * from Customer where CName = '" + name + "'" + "and CBirth = '" + bir + "'" + "and CPH = '" + ph + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    string serName = dbReader["CName"] as String;
                    string serBir = dbReader["CBirth"] as String;
                    string serPh = dbReader["CPH"] as String;
                    string result = dbReader["CID"] as String;

                    if (name.Equals(serName) && bir.Equals(serBir) && ph.Equals(serPh))
                    {
                        MessageBox.Show("아이디 : " + result);
                    }
                }
                dbReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("select문에 실패하였습니다.");
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
    }
}
