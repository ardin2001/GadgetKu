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
    class CRUD_karyawan : DB
    {
        public string nama { set; get; }
        public string posisi { set; get; }
        public string jk { set; get; }
        public string alamat { set; get; }
        public string hp { set; get; }
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
                cmd.CommandText = "INSERT INTO karyawan(`nama_karyawan`,`posisi`,`jenis_kelamin`,`alamat`,`no_hp`,`id_admin`) values(@nama,@posisi,@jk,@alamat,@hp,1)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@posisi", MySqlDbType.VarChar).Value = posisi;
                cmd.Parameters.Add("@jk", MySqlDbType.VarChar).Value = jk;
                cmd.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@hp", MySqlDbType.VarChar).Value = hp;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Karyawan BErhasil Dibuat.");
                conn.Close();
            }
        }
        //UPDATE
        public void update()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE karyawan SET nama_karyawan=@nama,posisi=@posisi,jenis_kelamin=@jk,alamat=@alamat,no_hp=@hp,id_admin=1 WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@posisi", MySqlDbType.VarChar).Value = posisi;
                cmd.Parameters.Add("@jk", MySqlDbType.VarChar).Value = jk;
                cmd.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@hp", MySqlDbType.VarChar).Value = hp;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Karyawan Berhasil Diubah.");
                conn.Close();
            }
        }

        //DELETE
        public void delete()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM karyawan WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Karyawan Berhasil Dihapus.");
                conn.Close();
            }
        }
        // READ
        public void read()
        {
            dt.Clear();
            string query = "SELECT id,nama_karyawan as `nama karyawan`,posisi,jenis_kelamin as `jenis kelamin`,alamat,no_hp FROM `karyawan`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, conn);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
