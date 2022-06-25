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
    class CRUD_gaji : DB
    {
        public string id_karyawan { set; get; }
        public string gaji { set; get; }
        public DateTime tanggal { set; get; }
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
                cmd.CommandText = "INSERT INTO gaji_karyawan(`id_karyawan`,`gaji`,`tanggal`,`id_admin`) values(@id_karyawan,@gaji,@tanggal,1)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@id_karyawan", MySqlDbType.VarChar).Value = id_karyawan;
                cmd.Parameters.Add("@gaji", MySqlDbType.VarChar).Value = gaji;
                cmd.Parameters.Add("@tanggal", MySqlDbType.Date).Value = tanggal;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Gaji Karyawan Berhasil Dibuat.");
                conn.Close();
            }
        }
        //UPDATE
        public void update()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE gaji_karyawan SET gaji=@gaji,tanggal=@tanggal,id_admin=1 WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@gaji", MySqlDbType.VarChar).Value = gaji;
                cmd.Parameters.Add("@tanggal", MySqlDbType.Date).Value = tanggal;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Gaji Karyawan Berhasil Diubah.");
                conn.Close();
            }
        }

        //DELETE
        public void delete()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM gaji_karyawan WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Gaji Karyawan Berhasil Dihapus.");
                conn.Close();
            }
        }
        // READ
        public void read()
        {
            dt.Clear();
            string query = "SELECT gk.id,gk.id_karyawan as `id karyawan`,k.nama_karyawan as `nama karyawan`,k.posisi,k.no_hp as `no hp`,gk.gaji,gk.tanggal FROM gaji_karyawan gk join karyawan k where gk.id_karyawan = k.id";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, conn);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
