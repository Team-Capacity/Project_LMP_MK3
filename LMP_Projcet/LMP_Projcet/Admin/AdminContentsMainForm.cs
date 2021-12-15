﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMP_Projcet.Methods;
using MySql.Data.MySqlClient;

namespace LibraryMgrProgram.AdminForm
{
    public partial class AdminContentsMainForm : Form
    {
        FormChange fc = new FormChange();
        dbTest db = new dbTest();
        public AdminContentsMainForm()
        {
            InitializeComponent();
        }

        private void AdminContentsMainForm_Load(object sender, EventArgs e)
        {
            Label[] back = { lbACMNotic, lbACMBestBook, label2 , lbACMBookName0 , lbACMAuthor0 , lbACMBookName1, lbACMAuthor1 , lbACMBookName2, lbACMAuthor2 };
            fc.fromColorChange(back, back);
            fc.fromColorChange(this);
            Book();
        }
        private void Book()
        {
            db.dbConnection();
            string sql = "select BName,BAuthor from Book order by BNumber desc limit 3;";
            MySqlCommand cmd = new MySqlCommand(sql, db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            StringBuilder name = new StringBuilder();
            StringBuilder author = new StringBuilder();


            while (reader.Read())
            {
                string a = reader[0].ToString();
                name.Append("," + a);

                string b = reader[1].ToString();
                author.Append("," + b);
            }

            string chkName = name.ToString();
            string[] splitName = chkName.Split(',');

            string chkAuthor = author.ToString();
            string[] splitAuthor = chkAuthor.Split(',');


            lbACMBookName0.Text = splitName[1];
            lbACMAuthor0.Text = splitAuthor[1];

            lbACMBookName1.Text = splitName[2];
            lbACMAuthor1.Text = splitAuthor[2];

            lbACMBookName2.Text = splitName[3];
            lbACMAuthor2.Text = splitAuthor[3];

            reader.Close();
            db.conn.Close();
        }

    }
}
