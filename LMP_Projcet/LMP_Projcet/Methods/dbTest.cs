using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using LMP_Projcet.Methods.DB;

namespace LMP_Projcet.Methods
{
    class dbTest
    {
        public string dbSelectCus(string selectCmd)
        {
            try
            {
                dbConnect connect = new dbConnect();
                connect.dbConnection();
                string selCommad = "SELECT CName FROM Customer WHERE CID = 'admin' ";
                //string selCommad = selectCmd;
                MySqlCommand cmd = new MySqlCommand(selCommad, connect.conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                string result;
                while (dbReader.Read())
                {
                    string name = dbReader["CName"] as String;
                    return result = name;
                }
                dbReader.Close();
                return result = "Error";
            }
            catch (Exception)
            {
                MessageBox.Show("select문에 실패하였습니다.");
                throw;
            }
        }


    }
}
