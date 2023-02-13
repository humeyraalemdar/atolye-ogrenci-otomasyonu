namespace WindowsFormsApp_Atolye
{
    partial class Admin_DersPaket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_DersPaket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtPaketFiyati = new System.Windows.Forms.TextBox();
            this.PaketAdi = new System.Windows.Forms.Label();
            this.TxtPaketAdi = new System.Windows.Forms.TextBox();
            this.PaketFiyati = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Yenile);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.BtnGoster);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtPaketFiyati);
            this.groupBox1.Controls.Add(this.PaketAdi);
            this.groupBox1.Controls.Add(this.TxtPaketAdi);
            this.groupBox1.Controls.Add(this.PaketFiyati);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(964, 270);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Paketleri";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(740, 193);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 23);
            this.labelId.TabIndex = 42;
            this.labelId.Text = "label1";
            this.labelId.Visible = false;
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil.Location = new System.Drawing.Point(553, 187);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 35);
            this.BtnSil.TabIndex = 41;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle.Location = new System.Drawing.Point(399, 187);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 35);
            this.BtnGuncelle.TabIndex = 40;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Temizle
            // 
            this.Temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temizle.AutoSize = true;
            this.Temizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(890, 115);
            this.Temizle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(66, 23);
            this.Temizle.TabIndex = 38;
            this.Temizle.Text = "Temizle";
            // 
            // Yenile
            // 
            this.Yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yenile.AutoSize = true;
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.Location = new System.Drawing.Point(890, 57);
            this.Yenile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(54, 23);
            this.Yenile.TabIndex = 37;
            this.Yenile.Text = "Yenile";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTemizle.FlatAppearance.BorderSize = 0;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(815, 109);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(53, 34);
            this.BtnTemizle.TabIndex = 36;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGoster
            // 
            this.BtnGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoster.FlatAppearance.BorderSize = 0;
            this.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoster.Image")));
            this.BtnGoster.Location = new System.Drawing.Point(815, 54);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(53, 34);
            this.BtnGoster.TabIndex = 35;
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet.Location = new System.Drawing.Point(238, 187);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 35);
            this.BtnKaydet.TabIndex = 27;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtPaketFiyati
            // 
            this.TxtPaketFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPaketFiyati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPaketFiyati.Location = new System.Drawing.Point(184, 112);
            this.TxtPaketFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPaketFiyati.Name = "TxtPaketFiyati";
            this.TxtPaketFiyati.Size = new System.Drawing.Size(582, 30);
            this.TxtPaketFiyati.TabIndex = 14;
            // 
            // PaketAdi
            // 
            this.PaketAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaketAdi.AutoSize = true;
            this.PaketAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaketAdi.Location = new System.Drawing.Point(22, 61);
            this.PaketAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaketAdi.Name = "PaketAdi";
            this.PaketAdi.Size = new System.Drawing.Size(128, 23);
            this.PaketAdi.TabIndex = 1;
            this.PaketAdi.Text = "Ders Paketi Adı:";
            // 
            // TxtPaketAdi
            // 
            this.TxtPaketAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPaketAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPaketAdi.Location = new System.Drawing.Point(184, 54);
            this.TxtPaketAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPaketAdi.Name = "TxtPaketAdi";
            this.TxtPaketAdi.Size = new System.Drawing.Size(582, 30);
            this.TxtPaketAdi.TabIndex = 2;
            // 
            // PaketFiyati
            // 
            this.PaketFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaketFiyati.AutoSize = true;
            this.PaketFiyati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaketFiyati.Location = new System.Drawing.Point(22, 119);
            this.PaketFiyati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaketFiyati.Name = "PaketFiyati";
            this.PaketFiyati.Size = new System.Drawing.Size(53, 23);
            this.PaketFiyati.TabIndex = 3;
            this.PaketFiyati.Text = "Fiyatı:";
            // 
            // TxtAra
            // 
            this.TxtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAra.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.ForeColor = System.Drawing.Color.Silver;
            this.TxtAra.Location = new System.Drawing.Point(712, 14);
            this.TxtAra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(267, 30);
            this.TxtAra.TabIndex = 34;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Paket Adı Ara";
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            this.TxtAra.Leave += new System.EventHandler(this.TxtAra_Leave);
            // 
            // BtnAra
            // 
            this.BtnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAra.FlatAppearance.BorderSize = 0;
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.Location = new System.Drawing.Point(652, 11);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(53, 34);
            this.BtnAra.TabIndex = 39;
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 420);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 367);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // Admin_DersPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_DersPaket";
            this.Text = "Admin_DersPaket";
            this.Load += new System.EventHandler(this.Admin_DersPaket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtPaketFiyati;
        private System.Windows.Forms.Label PaketAdi;
        private System.Windows.Forms.TextBox TxtPaketAdi;
        private System.Windows.Forms.Label PaketFiyati;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Label Temizle;
        private System.Windows.Forms.Label Yenile;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}