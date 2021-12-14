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

        dbConnect dbSource = new dbConnect();
        public MySqlConnection conn = new MySqlConnection();

        public void dbConnection()
        {
            string connStr = "Data Source = " + dbSource.Server
                + ";Port = " + dbSource.Port
                + ";Database = " + dbSource.Database
                + ";UserID = " + dbSource.UserId
                + ";Password = " + dbSource.Password + ";";
            try
            {
                conn = new MySqlConnection(connStr + ";allow zero datetime=yes");
                conn.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("DB연동에 실패하였습니다.");
            }
        }

        // select 문 검색용
        public string dbSelectCus(string selectCmd)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand(selectCmd, conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                string result;
                while (dbReader.Read())
                {
                    string name = dbReader[0].ToString();
                    return result = name;
                }
                dbReader.Close();
                conn.Close();

                return result = "Error";
            }
            catch (Exception)
            {
                MessageBox.Show("select문에 실패하였습니다.");
                throw;
            }
        }

        public string dbSelect(string select ,string from ,string where)
        {
            try
            {
                string sql = "select " + select + " from " + from + "where " + where +";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dbReader = cmd.ExecuteReader();
                string result = "";
                while (dbReader.Read())
                {
                    result = dbReader[0].ToString();
                }
                return result;
                dbReader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void dbUpdate(string updateCmd)
        {
            try
            {
                dbConnection();
                MySqlCommand cmd = new MySqlCommand(updateCmd, conn);
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB수정에 실패하였습니다.");
            }
        }

    }
}
