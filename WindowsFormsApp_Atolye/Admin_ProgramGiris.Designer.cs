namespace WindowsFormsApp_Atolye
{
    partial class Admin_ProgramGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_ProgramGiris));
            this.EgitmenAdiSoyadi = new System.Windows.Forms.Label();
            this.AtolyeAdi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.TxtProgramGunu = new System.Windows.Forms.TextBox();
            this.MTBoxBitis = new System.Windows.Forms.MaskedTextBox();
            this.MTBoxBaslama = new System.Windows.Forms.MaskedTextBox();
            this.ProgramGunu = new System.Windows.Forms.Label();
            this.Temizle = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.CBoxAtolye = new System.Windows.Forms.ComboBox();
            this.CBoxEgitmen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YasGrubu = new System.Windows.Forms.Label();
            this.TxtYasGrubu = new System.Windows.Forms.TextBox();
            this.ProgramSaati = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.Tarih = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EgitmenAdiSoyadi
            // 
            this.EgitmenAdiSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EgitmenAdiSoyadi.AutoSize = true;
            this.EgitmenAdiSoyadi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EgitmenAdiSoyadi.Location = new System.Drawing.Point(35, 103);
            this.EgitmenAdiSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EgitmenAdiSoyadi.Name = "EgitmenAdiSoyadi";
            this.EgitmenAdiSoyadi.Size = new System.Drawing.Size(77, 23);
            this.EgitmenAdiSoyadi.TabIndex = 22;
            this.EgitmenAdiSoyadi.Text = "Eğitmen:";
            // 
            // AtolyeAdi
            // 
            this.AtolyeAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtolyeAdi.AutoSize = true;
            this.AtolyeAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AtolyeAdi.Location = new System.Drawing.Point(35, 53);
            this.AtolyeAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtolyeAdi.Name = "AtolyeAdi";
            this.AtolyeAdi.Size = new System.Drawing.Size(62, 23);
            this.AtolyeAdi.TabIndex = 1;
            this.AtolyeAdi.Text = "Atölye:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.TxtProgramGunu);
            this.groupBox1.Controls.Add(this.MTBoxBitis);
            this.groupBox1.Controls.Add(this.MTBoxBaslama);
            this.groupBox1.Controls.Add(this.ProgramGunu);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Yenile);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.BtnGoster);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.CBoxAtolye);
            this.groupBox1.Controls.Add(this.CBoxEgitmen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.YasGrubu);
            this.groupBox1.Controls.Add(this.TxtYasGrubu);
            this.groupBox1.Controls.Add(this.ProgramSaati);
            this.groupBox1.Controls.Add(this.Fiyat);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.dateTimeTarih);
            this.groupBox1.Controls.Add(this.EgitmenAdiSoyadi);
            this.groupBox1.Controls.Add(this.AtolyeAdi);
            this.groupBox1.Controls.Add(this.Tarih);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(964, 371);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Girişi";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(708, 316);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 23);
            this.labelId.TabIndex = 59;
            this.labelId.Text = "label1";
            this.labelId.Visible = false;
            // 
            // TxtProgramGunu
            // 
            this.TxtProgramGunu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtProgramGunu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtProgramGunu.Location = new System.Drawing.Point(534, 197);
            this.TxtProgramGunu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProgramGunu.Name = "TxtProgramGunu";
            this.TxtProgramGunu.Size = new System.Drawing.Size(217, 30);
            this.TxtProgramGunu.TabIndex = 50;
            // 
            // MTBoxBitis
            // 
            this.MTBoxBitis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTBoxBitis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTBoxBitis.Location = new System.Drawing.Point(357, 252);
            this.MTBoxBitis.Mask = "00:00";
            this.MTBoxBitis.Name = "MTBoxBitis";
            this.MTBoxBitis.Size = new System.Drawing.Size(65, 30);
            this.MTBoxBitis.TabIndex = 47;
            this.MTBoxBitis.ValidatingType = typeof(System.DateTime);
            // 
            // MTBoxBaslama
            // 
            this.MTBoxBaslama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTBoxBaslama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTBoxBaslama.Location = new System.Drawing.Point(205, 252);
            this.MTBoxBaslama.Mask = "00:00";
            this.MTBoxBaslama.Name = "MTBoxBaslama";
            this.MTBoxBaslama.Size = new System.Drawing.Size(65, 30);
            this.MTBoxBaslama.TabIndex = 46;
            this.MTBoxBaslama.ValidatingType = typeof(System.DateTime);
            // 
            // ProgramGunu
            // 
            this.ProgramGunu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgramGunu.AutoSize = true;
            this.ProgramGunu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProgramGunu.Location = new System.Drawing.Point(475, 202);
            this.ProgramGunu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgramGunu.Name = "ProgramGunu";
            this.ProgramGunu.Size = new System.Drawing.Size(46, 23);
            this.ProgramGunu.TabIndex = 38;
            this.ProgramGunu.Text = "Gün:";
            // 
            // Temizle
            // 
            this.Temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temizle.AutoSize = true;
            this.Temizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(876, 105);
            this.Temizle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(66, 23);
            this.Temizle.TabIndex = 58;
            this.Temizle.Text = "Temizle";
            // 
            // Yenile
            // 
            this.Yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yenile.AutoSize = true;
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.Location = new System.Drawing.Point(876, 47);
            this.Yenile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(54, 23);
            this.Yenile.TabIndex = 57;
            this.Yenile.Text = "Yenile";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTemizle.FlatAppearance.BorderSize = 0;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(803, 100);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(53, 34);
            this.BtnTemizle.TabIndex = 56;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGoster
            // 
            this.BtnGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoster.FlatAppearance.BorderSize = 0;
            this.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoster.Image")));
            this.BtnGoster.Location = new System.Drawing.Point(803, 42);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(53, 34);
            this.BtnGoster.TabIndex = 55;
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil.Location = new System.Drawing.Point(529, 310);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 35);
            this.BtnSil.TabIndex = 54;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle.Location = new System.Drawing.Point(377, 310);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 35);
            this.BtnGuncelle.TabIndex = 53;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet.Location = new System.Drawing.Point(214, 310);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 35);
            this.BtnKaydet.TabIndex = 52;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // CBoxAtolye
            // 
            this.CBoxAtolye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxAtolye.FormattingEnabled = true;
            this.CBoxAtolye.Location = new System.Drawing.Point(205, 46);
            this.CBoxAtolye.Name = "CBoxAtolye";
            this.CBoxAtolye.Size = new System.Drawing.Size(546, 31);
            this.CBoxAtolye.TabIndex = 51;
            this.CBoxAtolye.SelectedIndexChanged += new System.EventHandler(this.CBoxAtolye_SelectedIndexChanged);
            // 
            // CBoxEgitmen
            // 
            this.CBoxEgitmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxEgitmen.FormattingEnabled = true;
            this.CBoxEgitmen.Location = new System.Drawing.Point(205, 95);
            this.CBoxEgitmen.Name = "CBoxEgitmen";
            this.CBoxEgitmen.Size = new System.Drawing.Size(546, 31);
            this.CBoxEgitmen.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(300, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 50);
            this.label6.TabIndex = 48;
            this.label6.Text = "-";
            // 
            // YasGrubu
            // 
            this.YasGrubu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YasGrubu.AutoSize = true;
            this.YasGrubu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YasGrubu.Location = new System.Drawing.Point(35, 152);
            this.YasGrubu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YasGrubu.Name = "YasGrubu";
            this.YasGrubu.Size = new System.Drawing.Size(91, 23);
            this.YasGrubu.TabIndex = 44;
            this.YasGrubu.Text = "Yaş Grubu:";
            // 
            // TxtYasGrubu
            // 
            this.TxtYasGrubu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtYasGrubu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYasGrubu.Location = new System.Drawing.Point(205, 149);
            this.TxtYasGrubu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtYasGrubu.Name = "TxtYasGrubu";
            this.TxtYasGrubu.Size = new System.Drawing.Size(546, 30);
            this.TxtYasGrubu.TabIndex = 45;
            // 
            // ProgramSaati
            // 
            this.ProgramSaati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgramSaati.AutoSize = true;
            this.ProgramSaati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProgramSaati.Location = new System.Drawing.Point(35, 252);
            this.ProgramSaati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgramSaati.Name = "ProgramSaati";
            this.ProgramSaati.Size = new System.Drawing.Size(122, 23);
            this.ProgramSaati.TabIndex = 42;
            this.ProgramSaati.Text = "Program Saati:";
            // 
            // Fiyat
            // 
            this.Fiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat.Location = new System.Drawing.Point(472, 252);
            this.Fiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(49, 23);
            this.Fiyat.TabIndex = 40;
            this.Fiyat.Text = "Fiyat:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFiyat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyat.Location = new System.Drawing.Point(534, 252);
            this.TxtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(217, 30);
            this.TxtFiyat.TabIndex = 41;
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeTarih.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTarih.Location = new System.Drawing.Point(205, 199);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(217, 30);
            this.dateTimeTarih.TabIndex = 35;
            this.dateTimeTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Tarih
            // 
            this.Tarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tarih.AutoSize = true;
            this.Tarih.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.Location = new System.Drawing.Point(35, 202);
            this.Tarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(125, 23);
            this.Tarih.TabIndex = 3;
            this.Tarih.Text = "Program Tarihi:";
            // 
            // BtnAra
            // 
            this.BtnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAra.FlatAppearance.BorderSize = 0;
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.Location = new System.Drawing.Point(651, 10);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(53, 34);
            this.BtnAra.TabIndex = 59;
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtAra
            // 
            this.TxtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAra.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.ForeColor = System.Drawing.Color.Silver;
            this.TxtAra.Location = new System.Drawing.Point(711, 11);
            this.TxtAra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(267, 30);
            this.TxtAra.TabIndex = 60;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Gün Ara";
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            this.TxtAra.Leave += new System.EventHandler(this.TxtAra_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 365);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Admin_ProgramGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_ProgramGiris";
            this.Text = "Admin_ProgramGiris";
            this.Load += new System.EventHandler(this.Admin_ProgramGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EgitmenAdiSoyadi;
        private System.Windows.Forms.Label AtolyeAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label YasGrubu;
        private System.Windows.Forms.TextBox TxtYasGrubu;
        private System.Windows.Forms.Label ProgramSaati;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label ProgramGunu;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MTBoxBitis;
        private System.Windows.Forms.MaskedTextBox MTBoxBaslama;
        private System.Windows.Forms.ComboBox CBoxEgitmen;
        private System.Windows.Forms.ComboBox CBoxAtolye;
        private System.Windows.Forms.TextBox TxtProgramGunu;
        private System.Windows.Forms.Label Temizle;
        private System.Windows.Forms.Label Yenile;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelId;
    }
}