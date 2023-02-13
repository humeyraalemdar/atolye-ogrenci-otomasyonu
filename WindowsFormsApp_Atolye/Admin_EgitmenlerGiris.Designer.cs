namespace WindowsFormsApp_Atolye
{
    partial class Admin_EgitmenlerGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_EgitmenlerGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.RTxtUzmanlik = new System.Windows.Forms.RichTextBox();
            this.TxtEgitmenSoyadi = new System.Windows.Forms.TextBox();
            this.EgitmenSoyadi = new System.Windows.Forms.Label();
            this.RTxtAdresi = new System.Windows.Forms.RichTextBox();
            this.EgitmenAdi = new System.Windows.Forms.Label();
            this.TxtEgitmenAdi = new System.Windows.Forms.TextBox();
            this.EgitmenAdresi = new System.Windows.Forms.Label();
            this.UzmanlikAlani = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAra = new System.Windows.Forms.Button();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Yenile);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.BtnGoster);
            this.groupBox1.Controls.Add(this.RTxtUzmanlik);
            this.groupBox1.Controls.Add(this.TxtEgitmenSoyadi);
            this.groupBox1.Controls.Add(this.EgitmenSoyadi);
            this.groupBox1.Controls.Add(this.RTxtAdresi);
            this.groupBox1.Controls.Add(this.EgitmenAdi);
            this.groupBox1.Controls.Add(this.TxtEgitmenAdi);
            this.groupBox1.Controls.Add(this.EgitmenAdresi);
            this.groupBox1.Controls.Add(this.UzmanlikAlani);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(964, 363);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eğitmen Girişi";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet.Location = new System.Drawing.Point(239, 318);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 35);
            this.BtnKaydet.TabIndex = 48;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(747, 322);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 23);
            this.labelId.TabIndex = 47;
            this.labelId.Text = "label1";
            this.labelId.Visible = false;
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil.Location = new System.Drawing.Point(575, 316);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 35);
            this.BtnSil.TabIndex = 46;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle.Location = new System.Drawing.Point(413, 316);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 35);
            this.BtnGuncelle.TabIndex = 45;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Temizle
            // 
            this.Temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temizle.AutoSize = true;
            this.Temizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(874, 104);
            this.Temizle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(66, 23);
            this.Temizle.TabIndex = 42;
            this.Temizle.Text = "Temizle";
            // 
            // Yenile
            // 
            this.Yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yenile.AutoSize = true;
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.Location = new System.Drawing.Point(874, 46);
            this.Yenile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(54, 23);
            this.Yenile.TabIndex = 41;
            this.Yenile.Text = "Yenile";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTemizle.FlatAppearance.BorderSize = 0;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(799, 98);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(53, 34);
            this.BtnTemizle.TabIndex = 40;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGoster
            // 
            this.BtnGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoster.FlatAppearance.BorderSize = 0;
            this.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoster.Image")));
            this.BtnGoster.Location = new System.Drawing.Point(799, 43);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(53, 34);
            this.BtnGoster.TabIndex = 39;
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // RTxtUzmanlik
            // 
            this.RTxtUzmanlik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTxtUzmanlik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTxtUzmanlik.Location = new System.Drawing.Point(153, 217);
            this.RTxtUzmanlik.Margin = new System.Windows.Forms.Padding(4);
            this.RTxtUzmanlik.Name = "RTxtUzmanlik";
            this.RTxtUzmanlik.Size = new System.Drawing.Size(590, 85);
            this.RTxtUzmanlik.TabIndex = 35;
            this.RTxtUzmanlik.Text = "";
            // 
            // TxtEgitmenSoyadi
            // 
            this.TxtEgitmenSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEgitmenSoyadi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEgitmenSoyadi.Location = new System.Drawing.Point(493, 45);
            this.TxtEgitmenSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEgitmenSoyadi.Name = "TxtEgitmenSoyadi";
            this.TxtEgitmenSoyadi.Size = new System.Drawing.Size(251, 30);
            this.TxtEgitmenSoyadi.TabIndex = 25;
            // 
            // EgitmenSoyadi
            // 
            this.EgitmenSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EgitmenSoyadi.AutoSize = true;
            this.EgitmenSoyadi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EgitmenSoyadi.Location = new System.Drawing.Point(421, 49);
            this.EgitmenSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EgitmenSoyadi.Name = "EgitmenSoyadi";
            this.EgitmenSoyadi.Size = new System.Drawing.Size(64, 23);
            this.EgitmenSoyadi.TabIndex = 22;
            this.EgitmenSoyadi.Text = "Soyadı:";
            // 
            // RTxtAdresi
            // 
            this.RTxtAdresi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTxtAdresi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTxtAdresi.Location = new System.Drawing.Point(150, 106);
            this.RTxtAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.RTxtAdresi.Name = "RTxtAdresi";
            this.RTxtAdresi.Size = new System.Drawing.Size(590, 84);
            this.RTxtAdresi.TabIndex = 17;
            this.RTxtAdresi.Text = "";
            // 
            // EgitmenAdi
            // 
            this.EgitmenAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EgitmenAdi.AutoSize = true;
            this.EgitmenAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EgitmenAdi.Location = new System.Drawing.Point(12, 48);
            this.EgitmenAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EgitmenAdi.Name = "EgitmenAdi";
            this.EgitmenAdi.Size = new System.Drawing.Size(39, 23);
            this.EgitmenAdi.TabIndex = 1;
            this.EgitmenAdi.Text = "Adı:";
            // 
            // TxtEgitmenAdi
            // 
            this.TxtEgitmenAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEgitmenAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEgitmenAdi.Location = new System.Drawing.Point(150, 45);
            this.TxtEgitmenAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEgitmenAdi.Name = "TxtEgitmenAdi";
            this.TxtEgitmenAdi.Size = new System.Drawing.Size(251, 30);
            this.TxtEgitmenAdi.TabIndex = 2;
            // 
            // EgitmenAdresi
            // 
            this.EgitmenAdresi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EgitmenAdresi.AutoSize = true;
            this.EgitmenAdresi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EgitmenAdresi.Location = new System.Drawing.Point(12, 106);
            this.EgitmenAdresi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EgitmenAdresi.Name = "EgitmenAdresi";
            this.EgitmenAdresi.Size = new System.Drawing.Size(61, 23);
            this.EgitmenAdresi.TabIndex = 3;
            this.EgitmenAdresi.Text = "Adresi:";
            // 
            // UzmanlikAlani
            // 
            this.UzmanlikAlani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UzmanlikAlani.AutoSize = true;
            this.UzmanlikAlani.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UzmanlikAlani.Location = new System.Drawing.Point(12, 220);
            this.UzmanlikAlani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UzmanlikAlani.Name = "UzmanlikAlani";
            this.UzmanlikAlani.Size = new System.Drawing.Size(127, 23);
            this.UzmanlikAlani.TabIndex = 5;
            this.UzmanlikAlani.Text = "Uzmanlık Alanı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(10, 423);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 365);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(956, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // BtnAra
            // 
            this.BtnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAra.FlatAppearance.BorderSize = 0;
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.Location = new System.Drawing.Point(651, 11);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(53, 34);
            this.BtnAra.TabIndex = 50;
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtAra
            // 
            this.TxtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAra.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.ForeColor = System.Drawing.Color.Silver;
            this.TxtAra.Location = new System.Drawing.Point(711, 14);
            this.TxtAra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(267, 30);
            this.TxtAra.TabIndex = 49;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Eğitmen Adı Ara";
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            this.TxtAra.Leave += new System.EventHandler(this.TxtAra_Leave);
            // 
            // Admin_EgitmenlerGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_EgitmenlerGiris";
            this.Text = "Admin_EgitmenlerGiris";
            this.Load += new System.EventHandler(this.Admin_EgitmenlerGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EgitmenSoyadi;
        private System.Windows.Forms.RichTextBox RTxtAdresi;
        private System.Windows.Forms.Label EgitmenAdi;
        private System.Windows.Forms.TextBox TxtEgitmenAdi;
        private System.Windows.Forms.Label EgitmenAdresi;
        private System.Windows.Forms.Label UzmanlikAlani;
        private System.Windows.Forms.TextBox TxtEgitmenSoyadi;
        private System.Windows.Forms.RichTextBox RTxtUzmanlik;
        private System.Windows.Forms.Label Temizle;
        private System.Windows.Forms.Label Yenile;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtAra;
    }
}