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
        public static string server = "000";
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
                MessageBox.Show("DB연동에 성공하였습니다.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("DB연동에 실패하였습니다.");
            }
            finally
            {
                try
                {
                    conn.Close();
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
        }
    }
}
