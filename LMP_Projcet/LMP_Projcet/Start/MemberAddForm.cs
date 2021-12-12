﻿using LibraryMgrProgram;
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

            TootMA.SetToolTip(txtMA_Pw, "특수문자+영문자+숫자로 이루어져야 하며 8자 이상이어야 합니다.");

            //생년월일 콤보박스에 값 추가
            int choice;
            for (choice = 1980; choice < 2100; choice++)
            {
                cmbMA_Year.Items.Add(choice);
            }


            for (choice = 1; choice < 13; choice++)
            {
                cmbMA_Month.Items.Add(choice);
            }

            for (choice = 1; choice < 32; choice++)
            {
                cmbMA_Day.Items.Add(choice);
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
            this.Close();
            new LoginForm().Show();
        }

        private void btnMA_IdCheck_Click(object sender, EventArgs e)
        {
            db.dbConnection();
            string id = txtMA_Id.Text;
            string sql = "select Count(CID) as CID from Customer where CID = '" + id + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();

                while (dbReader.Read())
                {
                    int count = Int32.Parse(dbReader["CID"].ToString());

                    if (count == 1)
                    {
                        MessageBox.Show("중복된 아이디입니다.");
                    }
                    else
                    {
                        MessageBox.Show("사용가능한 아이디입니다.");
                    }
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


            if (count == 0)
            {
                MessageBox.Show("중복확인버튼을 눌러주세요.");
                return;
            }

            try {
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
                if (!IsValYear(cmbMA_Year.Text))
                {
                    MessageBox.Show("년도에 숫자와 4글자로입력해주세요");
                    return;
                }

                if (!IsValMonth(cmbMA_Month.Text))
                {
                    MessageBox.Show("월 에 숫자와 2글자로입력해주세요");
                    return;
                }

                if (!IsValDay(cmbMA_Day.Text)) {
                    MessageBox.Show("일 에 숫자와 1~2글자로입력해주세요");
                    return;
                }

                if (!rdbMA_Man.Checked && !rdbMA_Wom.Checked)
                {
                    MessageBox.Show("성별을 선택해주세요.");
                    return;
                }

                if (!IsValPH(txtMA_Phone.Text))
                {
                    MessageBox.Show("핸드폰번호에 - 를 입력하여 번호를입력해주세요");
                    return;
                }



                string sql = "insert into Customer(CID, CPW, CName, CPH, CBirth, CAddress, CRank, CGender) values("
                + ",'" + txtMA_Id.Text + "'"
                + ",'" + txtMA_Pw.Text + "'"
                + ",'" + txtMA_Name.Text + "'"
                + "," + txtMA_Phone.Text + "'"
                + ",'" + cmbMA_Year + "/" + cmbMA_Month + "/" + cmbMA_Day + "'"
                + ",'"
                + ",'" +'3'
                + ",'" + grpcMA_Sex +"'";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();

               
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공적으로 추가 되었습니다.");
                    db.conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("DB수정에 실패하였습니다.");
            }
        }
        public static bool IsValMonth(string Text)
        {
            //숫자만1~2자리
            Regex Mregex = new Regex(@"^[0-9]{1,2}$");
            Match Mmatch = Mregex.Match(Text);
            return Mmatch.Success;
        }
        public static bool IsValDay(string Text)
        {
            //숫자만 1~2자리
            Regex Dregex = new Regex(@"^[0-9]{1,2}$");
            Match Dmatch = Dregex.Match(Text);
            return Dmatch.Success;
        }
        public static bool IsValYear(string Text)
        {
            //숫자만 4자리
            Regex Yregex = new Regex(@"^[0-9]{4}$");
            Match Ymatch = Yregex.Match(Text);
            return Ymatch.Success;
        }

        public static bool IsValPH(string Text)
        {
            //숫자만 앞자리 2~3자리 주간 3~4자리 마지막 4자리 입력시 - 포함해서
            Regex Pregex = new Regex(@"^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$");
            Match Pmatch = Pregex.Match(Text);
            return Pmatch.Success;
        }
        public static bool IsValName(string Text)
        {
            //한글만 2~5자리
            Regex Nregex = new Regex(@"^[가-힣]{2,5}$");
            Match Nmatch = Nregex.Match(Text);
            return Nmatch.Success;
        }

        public static bool IsValidPassword(string Text)
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
