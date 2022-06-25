using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GadgetKu.models;

namespace GadgetKu.views
{
    public partial class pemasukan_form : Form
    {
        CRUD_pemasukan masuk = new CRUD_pemasukan();
        CRUD_produk prod = new CRUD_produk();
        public pemasukan_form()
        {
            InitializeComponent();
            READ();
            READ_PRODUK();
        }

        private void pemasukan_form_Load(object sender, EventArgs e)
        {

        }

        private void produk_Click(object sender, EventArgs e)
        {
            produk_form produk = new produk_form();
            this.Close();
            produk.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            karyawan_form karyawan = new karyawan_form();
            this.Close();
            karyawan.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            profile_form profile = new profile_form();
            this.Close();
            profile.Show();
        }

        private void pengeluaran_Click(object sender, EventArgs e)
        {
            pengeluaran_form pengeluaran = new pengeluaran_form();
            this.Close();
            pengeluaran.Show();
        }

        private void pemasukan_Click(object sender, EventArgs e)
        {
            pemasukan_form pemasukan = new pemasukan_form();
            this.Close();
            pemasukan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }

        private void id_barang_Click(object sender, EventArgs e)
        {

        }

        private void nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpan_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id_barang.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    nama.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    type.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    harga.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Data null");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id_pemasukan.Text = (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u_nama.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                    u_type.Text = (dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                    u_jumlah.Text = (dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                    u_harga.Text = (dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Data null");
            }
        }

        private void id_pemasukan_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void u_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UPDATE();
            READ();
        }
        public void CREATE()
        {
            masuk.nama = nama.Text;
            masuk.type = type.Text;
            masuk.jumlah = jumlah.Text;
            masuk.harga = harga.Text;
            masuk.create();
        }
        public void UPDATE()
        {
            masuk.nama = u_nama.Text;
            masuk.type = u_type.Text;
            masuk.jumlah = u_jumlah.Text;
            masuk.harga = u_harga.Text;
            masuk.id = id_pemasukan.Text;
            masuk.update();
        }
        public void READ()
        {
            dataGridView2.DataSource = null;
            masuk.read();
            dataGridView2.DataSource = masuk.dt;
        }
        public void DELETE()
        {
            masuk.id = id_pemasukan.Text;
            masuk.delete();
        }
        public void READ_PRODUK()
        {
            dataGridView1.DataSource = null;
            prod.read();
            dataGridView1.DataSource = prod.dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gaji_form gaji = new gaji_form();
            this.Close();
            gaji.Show();
        }
    }
}
