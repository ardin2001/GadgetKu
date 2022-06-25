using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GadgetKu.models
{
    class Login : DB
    {
        public string username { set; get; }
        public string password { set; get; }


        public bool read()
        {
            conn.Open();
            MySqlDataReader rd;
            bool check = false;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "select * from admin where username=@username and password=@password";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    return true;
                }
                conn.Close();
            }
            return check;
        }

    }
}
