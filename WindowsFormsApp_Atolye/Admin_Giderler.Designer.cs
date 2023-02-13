namespace WindowsFormsApp_Atolye
{
    partial class Admin_Giderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Giderler));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimeGiderTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnKaydet2 = new System.Windows.Forms.Button();
            this.CBoxMasraf = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelId2 = new System.Windows.Forms.Label();
            this.BtnSil2 = new System.Windows.Forms.Button();
            this.BtnGuncelle2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.TxtMasraf = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.KatilimciAdi = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(482, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 197);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Masraflar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(481, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dateTimeGiderTarih);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.BtnKaydet2);
            this.groupBox3.Controls.Add(this.CBoxMasraf);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.labelId2);
            this.groupBox3.Controls.Add(this.BtnSil2);
            this.groupBox3.Controls.Add(this.BtnGuncelle2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.BtnTemizle);
            this.groupBox3.Controls.Add(this.BtnGoster);
            this.groupBox3.Controls.Add(this.TxtTutar);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(11, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(964, 262);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giderler";
            // 
            // dateTimeGiderTarih
            // 
            this.dateTimeGiderTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeGiderTarih.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeGiderTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeGiderTarih.Location = new System.Drawing.Point(137, 85);
            this.dateTimeGiderTarih.Name = "dateTimeGiderTarih";
            this.dateTimeGiderTarih.Size = new System.Drawing.Size(607, 30);
            this.dateTimeGiderTarih.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "Masraf Adı:";
            // 
            // BtnKaydet2
            // 
            this.BtnKaydet2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet2.Location = new System.Drawing.Point(237, 212);
            this.BtnKaydet2.Name = "BtnKaydet2";
            this.BtnKaydet2.Size = new System.Drawing.Size(105, 35);
            this.BtnKaydet2.TabIndex = 67;
            this.BtnKaydet2.Text = "Kaydet";
            this.BtnKaydet2.UseVisualStyleBackColor = false;
            this.BtnKaydet2.Click += new System.EventHandler(this.BtnKaydet2_Click);
            // 
            // CBoxMasraf
            // 
            this.CBoxMasraf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxMasraf.FormattingEnabled = true;
            this.CBoxMasraf.Location = new System.Drawing.Point(137, 34);
            this.CBoxMasraf.Name = "CBoxMasraf";
            this.CBoxMasraf.Size = new System.Drawing.Size(608, 31);
            this.CBoxMasraf.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tarih:";
            // 
            // labelId2
            // 
            this.labelId2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId2.AutoSize = true;
            this.labelId2.Location = new System.Drawing.Point(727, 220);
            this.labelId2.Name = "labelId2";
            this.labelId2.Size = new System.Drawing.Size(55, 23);
            this.labelId2.TabIndex = 53;
            this.labelId2.Text = "label2";
            this.labelId2.Visible = false;
            // 
            // BtnSil2
            // 
            this.BtnSil2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil2.Location = new System.Drawing.Point(574, 211);
            this.BtnSil2.Name = "BtnSil2";
            this.BtnSil2.Size = new System.Drawing.Size(105, 35);
            this.BtnSil2.TabIndex = 52;
            this.BtnSil2.Text = "Sil";
            this.BtnSil2.UseVisualStyleBackColor = false;
            this.BtnSil2.Click += new System.EventHandler(this.BtnSil2_Click);
            // 
            // BtnGuncelle2
            // 
            this.BtnGuncelle2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle2.Location = new System.Drawing.Point(410, 211);
            this.BtnGuncelle2.Name = "BtnGuncelle2";
            this.BtnGuncelle2.Size = new System.Drawing.Size(105, 35);
            this.BtnGuncelle2.TabIndex = 51;
            this.BtnGuncelle2.Text = "Güncelle";
            this.BtnGuncelle2.UseVisualStyleBackColor = false;
            this.BtnGuncelle2.Click += new System.EventHandler(this.BtnGuncelle2_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(875, 104);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 50;
            this.label13.Text = "Temizle";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(875, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 23);
            this.label14.TabIndex = 49;
            this.label14.Text = "Yenile";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTemizle.FlatAppearance.BorderSize = 0;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(800, 98);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(53, 34);
            this.BtnTemizle.TabIndex = 48;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGoster
            // 
            this.BtnGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoster.FlatAppearance.BorderSize = 0;
            this.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoster.Image")));
            this.BtnGoster.Location = new System.Drawing.Point(800, 43);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(53, 34);
            this.BtnGoster.TabIndex = 47;
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTutar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTutar.Location = new System.Drawing.Point(136, 133);
            this.TxtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(608, 30);
            this.TxtTutar.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 140);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 23);
            this.label16.TabIndex = 5;
            this.label16.Text = "Tutar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 522);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 264);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 28);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(956, 228);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.TxtMasraf);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.KatilimciAdi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(460, 197);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraflar";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(398, 168);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 23);
            this.labelId.TabIndex = 62;
            this.labelId.Text = "label1";
            this.labelId.Visible = false;
            // 
            // TxtMasraf
            // 
            this.TxtMasraf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMasraf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMasraf.Location = new System.Drawing.Point(138, 48);
            this.TxtMasraf.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMasraf.Name = "TxtMasraf";
            this.TxtMasraf.Size = new System.Drawing.Size(300, 30);
            this.TxtMasraf.TabIndex = 61;
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil.Location = new System.Drawing.Point(299, 123);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(84, 35);
            this.BtnSil.TabIndex = 60;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle.Location = new System.Drawing.Point(188, 123);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(92, 35);
            this.BtnGuncelle.TabIndex = 59;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet.Location = new System.Drawing.Point(76, 123);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(90, 35);
            this.BtnKaydet.TabIndex = 54;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // KatilimciAdi
            // 
            this.KatilimciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KatilimciAdi.AutoSize = true;
            this.KatilimciAdi.Location = new System.Drawing.Point(17, 51);
            this.KatilimciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KatilimciAdi.Name = "KatilimciAdi";
            this.KatilimciAdi.Size = new System.Drawing.Size(95, 23);
            this.KatilimciAdi.TabIndex = 1;
            this.KatilimciAdi.Text = "Masraf Adı:";
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
            this.BtnAra.TabIndex = 73;
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
            this.TxtAra.TabIndex = 74;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Tutar Ara";
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            this.TxtAra.Leave += new System.EventHandler(this.TxtAra_Leave);
            // 
            // Admin_Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_Giderler";
            this.Text = "Admin_Giderler";
            this.Load += new System.EventHandler(this.Admin_Giderler_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKaydet2;
        private System.Windows.Forms.ComboBox CBoxMasraf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelId2;
        private System.Windows.Forms.Button BtnSil2;
        private System.Windows.Forms.Button BtnGuncelle2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label KatilimciAdi;
        private System.Windows.Forms.TextBox TxtMasraf;
        private System.Windows.Forms.DateTimePicker dateTimeGiderTarih;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Label labelId;
    }
}