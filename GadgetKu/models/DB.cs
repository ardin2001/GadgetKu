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
    class DB
    {
        public MySqlConnection conn;
        public DB()
        {
            string host = "localhost";
            string db = "gadgetku";
            string user = "root";
            string pw = "";
            string constring = "datasource =" + host + "; database =" + db + "; port =" + 3306 + "; username =" + user + "; pw =" + pw + "; SslMode=none";
            conn = new MySqlConnection(constring);
        }
    }

}