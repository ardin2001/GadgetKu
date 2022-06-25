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
    public partial class gaji_form : Form
    {
        CRUD_karyawan karyawan = new CRUD_karyawan();
        CRUD_gaji crud = new CRUD_gaji();
        public gaji_form()
        {
            InitializeComponent();
            READ_KARYAWAN();
            READ();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UPDATE();
            READ();
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

        private void simpan_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();
        }

        private void tanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gaji_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_karyawan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id_karyawan.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                    id_gaji.Text = (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u_gaji.Text = (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
                    u_tanggal.Text = (dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Data null");
            }
        }

        private void u_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_pemasukan_Click(object sender, EventArgs e)
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

        private void produk_Click(object sender, EventArgs e)
        {
            produk_form produk = new produk_form();
            this.Close();
            produk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gaji_form_Load(object sender, EventArgs e)
        {

        }
        public void READ_KARYAWAN()
        {
            dataGridView1.DataSource = null;
            karyawan.read();
            dataGridView1.DataSource = karyawan.dt;
        }
        public void CREATE()
        {
            crud.gaji = gaji.Text;
            crud.id_karyawan = id_karyawan.Text;
            crud.tanggal = Convert.ToDateTime(tanggal.Text);
            crud.create();
        }
        public void UPDATE()
        {
            crud.gaji = u_gaji.Text;
            crud.tanggal = Convert.ToDateTime(u_tanggal.Text);
            crud.id = id_gaji.Text;
            crud.update();
        }
        public void READ()
        {
            dataGridView2.DataSource = null;
            crud.read();
            dataGridView2.DataSource = crud.dt;
        }
        public void DELETE()
        {
            crud.id = id_gaji.Text;
            crud.delete();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
