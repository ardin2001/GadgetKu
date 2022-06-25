namespace GadgetKu.views
{
    partial class pengeluaran_form
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
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.u_harga = new System.Windows.Forms.TextBox();
            this.u_jumlah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.u_nama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.simpan = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.pengeluaran = new System.Windows.Forms.Button();
            this.pemasukan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.produk = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.u_type = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(811, 299);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(489, 14);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(29, 24);
            this.id.TabIndex = 9;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(377, 249);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 39);
            this.delete.TabIndex = 8;
            this.delete.TabStop = false;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // u_harga
            // 
            this.u_harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_harga.Location = new System.Drawing.Point(246, 197);
            this.u_harga.Name = "u_harga";
            this.u_harga.Size = new System.Drawing.Size(272, 30);
            this.u_harga.TabIndex = 5;
            this.u_harga.TextChanged += new System.EventHandler(this.u_harga_TextChanged);
            // 
            // u_jumlah
            // 
            this.u_jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_jumlah.Location = new System.Drawing.Point(246, 150);
            this.u_jumlah.Name = "u_jumlah";
            this.u_jumlah.Size = new System.Drawing.Size(272, 30);
            this.u_jumlah.TabIndex = 4;
            this.u_jumlah.TextChanged += new System.EventHandler(this.u_jumlah_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Jumlah";
            // 
            // u_nama
            // 
            this.u_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_nama.Location = new System.Drawing.Point(246, 51);
            this.u_nama.Name = "u_nama";
            this.u_nama.Size = new System.Drawing.Size(272, 30);
            this.u_nama.TabIndex = 1;
            this.u_nama.TextChanged += new System.EventHandler(this.u_nama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama Pengeluaran";
            // 
            // simpan
            // 
            this.simpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.simpan.Cursor = System.Windows.Forms.Cursors.Default;
            this.simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.Location = new System.Drawing.Point(246, 249);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(110, 39);
            this.simpan.TabIndex = 7;
            this.simpan.TabStop = false;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = false;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // harga
            // 
            this.harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.Location = new System.Drawing.Point(246, 199);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(272, 30);
            this.harga.TabIndex = 5;
            this.harga.TextChanged += new System.EventHandler(this.harga_TextChanged);
            // 
            // jumlah
            // 
            this.jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(246, 152);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(272, 30);
            this.jumlah.TabIndex = 4;
            this.jumlah.TextChanged += new System.EventHandler(this.jumlah_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Harga";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.u_type);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.u_harga);
            this.groupBox2.Controls.Add(this.u_jumlah);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.u_nama);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(917, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 320);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE  PENGELUARAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nama Pengeluaran";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(275, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(837, 334);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "READ PENGELUARAN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.simpan);
            this.groupBox1.Controls.Add(this.harga);
            this.groupBox1.Controls.Add(this.jumlah);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(275, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 320);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE PENGELUARAN";
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(246, 51);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(272, 30);
            this.nama.TabIndex = 1;
            this.nama.TextChanged += new System.EventHandler(this.nama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pengeluaran";
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
            this.button4.Location = new System.Drawing.Point(3, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 61);
            this.button4.TabIndex = 19;
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
            this.button3.Location = new System.Drawing.Point(0, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 61);
            this.button3.TabIndex = 18;
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
            this.profile.Location = new System.Drawing.Point(3, 271);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(236, 61);
            this.profile.TabIndex = 17;
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
            this.pengeluaran.Location = new System.Drawing.Point(0, 204);
            this.pengeluaran.Name = "pengeluaran";
            this.pengeluaran.Size = new System.Drawing.Size(236, 61);
            this.pengeluaran.TabIndex = 16;
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
            this.pemasukan.Location = new System.Drawing.Point(0, 137);
            this.pemasukan.Name = "pemasukan";
            this.pemasukan.Size = new System.Drawing.Size(236, 61);
            this.pemasukan.TabIndex = 15;
            this.pemasukan.Text = "Pemasukan";
            this.pemasukan.UseVisualStyleBackColor = false;
            this.pemasukan.Click += new System.EventHandler(this.pemasukan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Heavy DEMO", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "GadgetKu";
            // 
            // produk
            // 
            this.produk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.produk.FlatAppearance.BorderSize = 0;
            this.produk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.produk.Location = new System.Drawing.Point(0, 70);
            this.produk.Name = "produk";
            this.produk.Size = new System.Drawing.Size(236, 61);
            this.produk.TabIndex = 13;
            this.produk.Text = "Produk";
            this.produk.UseVisualStyleBackColor = false;
            this.produk.Click += new System.EventHandler(this.produk_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(246, 103);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(272, 30);
            this.type.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Type";
            // 
            // u_type
            // 
            this.u_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_type.Location = new System.Drawing.Point(246, 101);
            this.u_type.Name = "u_type";
            this.u_type.Size = new System.Drawing.Size(272, 30);
            this.u_type.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Type";
            // 
            // pengeluaran_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pengeluaran_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pengeluaran_form";
            this.Load += new System.EventHandler(this.pengeluaran_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox u_harga;
        private System.Windows.Forms.TextBox u_jumlah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox u_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button pengeluaran;
        private System.Windows.Forms.Button pemasukan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button produk;
        private System.Windows.Forms.TextBox u_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label9;
    }
}