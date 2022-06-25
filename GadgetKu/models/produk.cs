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
    class CRUD_produk : DB
    {
        public string nama { set; get; }
        public string harga { set; get; }
        public string type { set; get; }
        public string id { set; get; }
        public string idadmin { set; get; }

        // READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        // CREATE
        public void create()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO produk(`nama_produk`,`type`,`harga`,`id_admin`) values(@nama,@type,@harga,1)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produk berhasil dibuat.");
                conn.Close();
            }
        }
        //UPDATE
        public void update()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE produk SET nama_produk=@nama,type=@type,harga=@harga,id_admin=1 WHERE id_produk=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produk berhasil diubah.");
                conn.Close();
            }
        }

        //DELETE
        public void delete()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM produk WHERE id_produk=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produk berhasil dihapus.");
                conn.Close();
            }
        }
        // READ
        public void read()
        {
            dt.Clear();
            string query = "SELECT id_produk as id,nama_produk as `nama produk`,type,harga FROM `produk`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, conn);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
