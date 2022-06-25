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
    public partial class produk_form : Form
    {
        CRUD_produk crud = new CRUD_produk();
        public produk_form()
        {
            InitializeComponent();
            READ();
        }

        private void produk_form_Load(object sender, EventArgs e)
        {

        }

        private void u_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void pemasukan_Click(object sender, EventArgs e)
        {
            pemasukan_form pemasukan = new pemasukan_form();
            this.Close();
            pemasukan.Show();
        }

        private void pengeluaran_Click(object sender, EventArgs e)
        {
            pengeluaran_form pengeluaran = new pengeluaran_form();
            this.Close();
            pengeluaran.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            profile_form profile = new profile_form();
            this.Close();
            profile.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            karyawan_form karyawan = new karyawan_form();
            this.Close();
            karyawan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gaji_form gaji = new gaji_form();
            this.Close();
            gaji.Show();
        }

        private void nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void type_TextChanged(object sender, EventArgs e)
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
                    id.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u_nama.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    u_type.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    u_harga.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Data null");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UPDATE();
            READ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }

        private void u_harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void produk_Click(object sender, EventArgs e)
        {
            produk_form produk = new produk_form();
            this.Close();
            produk.Show();
        }

        private void u_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }
        public void CREATE()
        {
            crud.nama = nama.Text;
            crud.type = type.Text;
            crud.harga = harga.Text;
            crud.create();
        }
        public void UPDATE()
        {
            crud.nama = u_nama.Text;
            crud.type = u_type.Text;
            crud.harga = u_harga.Text;
            crud.id = id.Text;
            crud.update();
        }
        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.read();
            dataGridView1.DataSource = crud.dt;
        }
        public void DELETE()
        {
            crud.id = id.Text;
            crud.delete();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
