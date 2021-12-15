using LibraryMgrProgram;
using LMP_Projcet.Methods;
using LMP_Projcet.Methods.DB;
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


namespace LMP_Projcet.Customer
{
    public partial class CustomerMyInfomationForm : Form
    {
        
        public CustomerMyInfomationForm()
        {
            InitializeComponent();
        }

        FormChange fc = new FormChange();
        dbTest db = new dbTest();


        private void update()
        {

        }


        private void CustomerMyInfomationForm_Load(object sender, EventArgs e)
        {
            fc.fromColorChange(this);
            Label[] l = { lbCMIInfo, lbCMIRank , lbCMIRankView , lbCMINum , lbCMINumView , lbCMIMyName , lbCMIName, lbCMIHP , lbCMIHPView , lbCMIMan , lbCMISex , lbCMICount , lbCMICountView , lbCMIBirth, lbCMIMyBirth, lbCMIMemo, lbCMIAddrView, lbCMIAddr, lbCMICustomerState };
            fc.fromColorChange(GBCusEdit);
            fc.fromColorChange(l, l);
         
                db.dbConnection();
                string thismyName = CustomerMainForm.myname;    
                string myName = thismyName.Substring(0, thismyName.Length - 8);
                string sql = "select * from Customer where CName = '" + myName + "';";

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
                int loancnt = 0;
             

                while (reader.Read())
                {
                    number = Int32.Parse(reader[0].ToString());
                    rank = reader[1].ToString();
                    name = reader[4].ToString();
                    loancnt = Int32.Parse(reader[5].ToString());
                    ph = reader[7].ToString();
                    birth = reader[8].ToString();
                    address = reader[9].ToString();
                    gender = reader[11].ToString();
                    memo = reader[12].ToString();
                }
                reader.Close();


                lbCMINumView.Text = number.ToString();
                lbCMIMyName.Text = name;
                lbCMIHPView.Text = ph;
                lbCMIMan.Text = gender;
                lbCMICountView.Text = loancnt.ToString();
                lbCMIMyBirth.Text = birth;
                lbCMIMemoView.Text = memo;
                lbCMIAddrView.Text = address;
                lbCMIRankView.Text = rank;

            /* 사진으로 구현할 예정이었으나 힘들듯
                if (rank.Equals('3'))
                {

                }
            */
      



        }
   
        public static bool chkShow = false;
        private void btnCMIEdit_Click(object sender, EventArgs e)
        {

        
            if (!chkShow)
            {
                CustomerEditForm ce = new CustomerEditForm();
                ce.Show();
                chkShow = true;
            }
            else
            {
                return;
            }
        
        }

        private void lbCMIMyEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbCMIMyBirth_Click(object sender, EventArgs e)
        {

        }

        private void lbCMIBirth_Click(object sender, EventArgs e)
        {

        }

    }
}
