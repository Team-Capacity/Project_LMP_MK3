using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LMP_Projcet.Methods
{
    class dbTest
    {
        public static string server = "192.168.0.24";
        public static string port = "3306";
        public static string database = "LibaryProgram_DB";
        public static string userId = "LMP";
        public static string password = "LMP1234";
        MySqlConnection conn;

        public void dbConnection()
        {
            string connStr = 
                "Data Source = " + server
                +";Port = " + port
                +";Database = " + database
                +";User ID = " + userId 
                +";Password = " + password + ";";
            try
            { 
                conn = new MySqlConnection(connStr);
                conn.Open();
                //MessageBox.Show("DB연동에 성공하였습니다.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("DB연동에 실패하였습니다.");
            }
        }


        public string dbSelectCus(string selectCmd)
        {
            try
            {
                string selCommad = "SELECT CusName FROM Customer WHERE CusID = 'admin' ";
                //string selCommad = selectCmd;
                MySqlCommand cmd = new MySqlCommand(selCommad, conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                string result;
                while (dbReader.Read())
                {
                    string name = dbReader["CusName"] as String;
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
