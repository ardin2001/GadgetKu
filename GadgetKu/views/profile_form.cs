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
    public partial class profile_form : Form
    {
        CRUD_profile crud = new CRUD_profile();
        public profile_form()
        {
            InitializeComponent();
            READ();
        }

        private void u_password_TextChanged(object sender, EventArgs e)
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void u_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void produk_Click(object sender, EventArgs e)
        {
            produk_form produk = new produk_form();
            this.Close();
            produk.Show();
        }

        private void u_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpan_Click(object sender, EventArgs e)
        {
            UPDATE();
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
                    u_username.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    u_password.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    u_email.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Data null");
            }
        }

        private void profile_form_Load(object sender, EventArgs e)
        {

        }
        public void UPDATE()
        {
            crud.username = u_username.Text;
            crud.password = u_password.Text;
            crud.email = u_email.Text;
            crud.id = id.Text;
            crud.update();
        }
        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.read();
            dataGridView1.DataSource = crud.dt;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
