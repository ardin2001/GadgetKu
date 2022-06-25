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
    class CRUD_pemasukan : DB
    {
        public string nama { set; get; }
        public string type { set; get; }
        public string jumlah { set; get; }
        public string harga { set; get; }
        public string id { set; get; }

        // READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        // CREATE
        public void create()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO pemasukan(`nama_pemasukan`,`type`,`jumlah`,`harga`,`id_admin`) values(@nama,@type,@jumlah,@harga,1)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@jumlah", MySqlDbType.VarChar).Value = jumlah;
                cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data pemasukan berhasil dibuat.");
                conn.Close();
            }
        }
        //UPDATE
        public void update()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE pemasukan SET nama_pemasukan=@nama,type=@type,jumlah=@jumlah,harga=@harga,id_admin=1 WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@jumlah", MySqlDbType.VarChar).Value = jumlah;
                cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data pemasukan berhasil diubah.");
                conn.Close();
            }
        }

        //DELETE
        public void delete()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM pemasukan WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data pemasukan berhasil dihapus.");
                conn.Close();
            }
        }
        // READ
        public void read()
        {
            dt.Clear();
            string query = "select id,nama_pemasukan as `nama pemasukan`,type,jumlah,harga from pemasukan";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, conn);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}