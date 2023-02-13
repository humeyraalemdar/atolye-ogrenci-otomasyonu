namespace WindowsFormsApp_Atolye
{
    partial class Admin_Tahsilat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Tahsilat));
            this.BtnAra = new System.Windows.Forms.Button();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AtolyeFiyati = new System.Windows.Forms.Label();
            this.AtolyeAdi = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Label();
            this.Temizle = new System.Windows.Forms.Label();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.CBoxKatilimci = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tarih = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnAra.TabIndex = 36;
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
            this.TxtAra.TabIndex = 37;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Tutar Ara";
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            this.TxtAra.Leave += new System.EventHandler(this.TxtAra_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 418);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 365);
            this.groupBox2.TabIndex = 35;
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
            // AtolyeFiyati
            // 
            this.AtolyeFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtolyeFiyati.AutoSize = true;
            this.AtolyeFiyati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AtolyeFiyati.Location = new System.Drawing.Point(22, 157);
            this.AtolyeFiyati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtolyeFiyati.Name = "AtolyeFiyati";
            this.AtolyeFiyati.Size = new System.Drawing.Size(54, 23);
            this.AtolyeFiyati.TabIndex = 3;
            this.AtolyeFiyati.Text = "Tutar:";
            // 
            // AtolyeAdi
            // 
            this.AtolyeAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtolyeAdi.AutoSize = true;
            this.AtolyeAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AtolyeAdi.Location = new System.Drawing.Point(22, 99);
            this.AtolyeAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtolyeAdi.Name = "AtolyeAdi";
            this.AtolyeAdi.Size = new System.Drawing.Size(165, 23);
            this.AtolyeAdi.TabIndex = 1;
            this.AtolyeAdi.Text = "Katılımcı Adı-Soyadı:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTutar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTutar.Location = new System.Drawing.Point(213, 151);
            this.TxtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(553, 30);
            this.TxtTutar.TabIndex = 14;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet.Location = new System.Drawing.Point(222, 200);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 35);
            this.BtnKaydet.TabIndex = 27;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle.Location = new System.Drawing.Point(385, 200);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 35);
            this.BtnGuncelle.TabIndex = 28;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil.Location = new System.Drawing.Point(537, 200);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 35);
            this.BtnSil.TabIndex = 29;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGoster
            // 
            this.BtnGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoster.FlatAppearance.BorderSize = 0;
            this.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoster.Image")));
            this.BtnGoster.Location = new System.Drawing.Point(813, 54);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(53, 34);
            this.BtnGoster.TabIndex = 30;
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(724, 206);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 23);
            this.labelId.TabIndex = 31;
            this.labelId.Text = "label1";
            this.labelId.Visible = false;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTemizle.FlatAppearance.BorderSize = 0;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(813, 112);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(53, 34);
            this.BtnTemizle.TabIndex = 32;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // Yenile
            // 
            this.Yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yenile.AutoSize = true;
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.Location = new System.Drawing.Point(886, 59);
            this.Yenile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(54, 23);
            this.Yenile.TabIndex = 33;
            this.Yenile.Text = "Yenile";
            // 
            // Temizle
            // 
            this.Temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temizle.AutoSize = true;
            this.Temizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(886, 117);
            this.Temizle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(66, 23);
            this.Temizle.TabIndex = 34;
            this.Temizle.Text = "Temizle";
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeTarih.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTarih.Location = new System.Drawing.Point(213, 39);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(553, 30);
            this.dateTimeTarih.TabIndex = 60;
            // 
            // CBoxKatilimci
            // 
            this.CBoxKatilimci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxKatilimci.FormattingEnabled = true;
            this.CBoxKatilimci.Location = new System.Drawing.Point(213, 91);
            this.CBoxKatilimci.Margin = new System.Windows.Forms.Padding(4);
            this.CBoxKatilimci.Name = "CBoxKatilimci";
            this.CBoxKatilimci.Size = new System.Drawing.Size(553, 31);
            this.CBoxKatilimci.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.CBoxKatilimci);
            this.groupBox1.Controls.Add(this.dateTimeTarih);
            this.groupBox1.Controls.Add(this.Tarih);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Yenile);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.BtnGoster);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.AtolyeAdi);
            this.groupBox1.Controls.Add(this.AtolyeFiyati);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(960, 265);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahsilat Girişi";
            // 
            // Tarih
            // 
            this.Tarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tarih.AutoSize = true;
            this.Tarih.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.Location = new System.Drawing.Point(22, 39);
            this.Tarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(115, 23);
            this.Tarih.TabIndex = 59;
            this.Tarih.Text = "Tahsilat Tarihi:";
            // 
            // Admin_Tahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox2);
            this.Name = "Admin_Tahsilat";
            this.Text = "Admin_Tahsilat";
            this.Load += new System.EventHandler(this.Admin_Tahsilat_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AtolyeFiyati;
        private System.Windows.Forms.Label AtolyeAdi;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label Yenile;
        private System.Windows.Forms.Label Temizle;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.ComboBox CBoxKatilimci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Tarih;
    }
}