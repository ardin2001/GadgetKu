namespace GadgetKu.views
{
    partial class profile_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.Label();
            this.simpan = new System.Windows.Forms.Button();
            this.u_email = new System.Windows.Forms.TextBox();
            this.u_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.u_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.pengeluaran = new System.Windows.Forms.Button();
            this.pemasukan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.produk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 72);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(549, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(29, 24);
            this.id.TabIndex = 9;
            this.id.Text = "ID";
            // 
            // simpan
            // 
            this.simpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.Location = new System.Drawing.Point(192, 207);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(110, 39);
            this.simpan.TabIndex = 7;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = false;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // u_email
            // 
            this.u_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_email.Location = new System.Drawing.Point(192, 156);
            this.u_email.Name = "u_email";
            this.u_email.Size = new System.Drawing.Size(386, 30);
            this.u_email.TabIndex = 5;
            this.u_email.TextChanged += new System.EventHandler(this.u_email_TextChanged);
            // 
            // u_password
            // 
            this.u_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_password.Location = new System.Drawing.Point(192, 109);
            this.u_password.Name = "u_password";
            this.u_password.Size = new System.Drawing.Size(386, 30);
            this.u_password.TabIndex = 4;
            this.u_password.TextChanged += new System.EventHandler(this.u_password_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // u_username
            // 
            this.u_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_username.Location = new System.Drawing.Point(192, 60);
            this.u_username.Name = "u_username";
            this.u_username.Size = new System.Drawing.Size(386, 30);
            this.u_username.TabIndex = 1;
            this.u_username.TextChanged += new System.EventHandler(this.u_username_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(505, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(833, 101);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "READ RPOFILE";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.Controls.Add(this.simpan);
            this.groupBox2.Controls.Add(this.u_email);
            this.groupBox2.Controls.Add(this.u_password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.u_username);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 279);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE PROFILE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(234, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1688, 64);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profile";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Red;
            this.logout.Location = new System.Drawing.Point(0, 810);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(236, 61);
            this.logout.TabIndex = 10;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.pengeluaran);
            this.panel1.Controls.Add(this.pemasukan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.produk);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1084);
            this.panel1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(3, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 61);
            this.button4.TabIndex = 26;
            this.button4.Text = "Gaji Karyawan";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(0, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 61);
            this.button3.TabIndex = 25;
            this.button3.Text = "Karyawan";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.profile.FlatAppearance.BorderSize = 0;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profile.Location = new System.Drawing.Point(3, 272);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(236, 61);
            this.profile.TabIndex = 24;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // pengeluaran
            // 
            this.pengeluaran.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pengeluaran.FlatAppearance.BorderSize = 0;
            this.pengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaran.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pengeluaran.Location = new System.Drawing.Point(0, 205);
            this.pengeluaran.Name = "pengeluaran";
            this.pengeluaran.Size = new System.Drawing.Size(236, 61);
            this.pengeluaran.TabIndex = 23;
            this.pengeluaran.Text = "Pengeluaran";
            this.pengeluaran.UseVisualStyleBackColor = false;
            this.pengeluaran.Click += new System.EventHandler(this.pengeluaran_Click);
            // 
            // pemasukan
            // 
            this.pemasukan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pemasukan.FlatAppearance.BorderSize = 0;
            this.pemasukan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pemasukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pemasukan.Location = new System.Drawing.Point(0, 138);
            this.pemasukan.Name = "pemasukan";
            this.pemasukan.Size = new System.Drawing.Size(236, 61);
            this.pemasukan.TabIndex = 22;
            this.pemasukan.Text = "Pemasukan";
            this.pemasukan.UseVisualStyleBackColor = false;
            this.pemasukan.Click += new System.EventHandler(this.pemasukan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Heavy DEMO", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "GadgetKu";
            // 
            // produk
            // 
            this.produk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.produk.FlatAppearance.BorderSize = 0;
            this.produk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.produk.Location = new System.Drawing.Point(0, 71);
            this.produk.Name = "produk";
            this.produk.Size = new System.Drawing.Size(236, 61);
            this.produk.TabIndex = 20;
            this.produk.Text = "Produk";
            this.produk.UseVisualStyleBackColor = false;
            this.produk.Click += new System.EventHandler(this.produk_Click);
            // 
            // profile_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profile_form";
            this.Load += new System.EventHandler(this.profile_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox u_email;
        private System.Windows.Forms.TextBox u_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox u_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button pengeluaran;
        private System.Windows.Forms.Button pemasukan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button produk;
    }
}