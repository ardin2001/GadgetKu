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
using GadgetKu.views;

namespace GadgetKu
{
    public partial class login_form : Form
    {
        Login r = new Login();
        public login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void u_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
        public void validate()
        {
            r.username = u.Text;
            r.password = p.Text;
            bool masuk = r.read();
            if (masuk)
            {
                pemasukan_form pf = new pemasukan_form();
                pf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal login");
            }
        }
    }
}
