namespace WindowsFormsApp_Atolye
{
    partial class Admin_AtolyeGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AtolyeGiris));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Temizle = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtAtolyeFiyati = new System.Windows.Forms.TextBox();
            this.AtolyeAdi = new System.Windows.Forms.Label();
            this.TxtAtolyeAdi = new System.Windows.Forms.TextBox();
            this.AtolyeFiyati = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 422);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 365);
            this.groupBox2.TabIndex = 25;
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
            // TxtAra
            // 
            this.TxtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAra.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.ForeColor = System.Drawing.Color.Silver;
            this.TxtAra.Location = new System.Drawing.Point(710, 12);
            this.TxtAra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(267, 30);
            this.TxtAra.TabIndex = 33;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Atöyle Ara";
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
            this.BtnAra.Location = new System.Drawing.Point(650, 11);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(53, 34);
            this.BtnAra.TabIndex = 33;
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Yenile);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.BtnGoster);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtAtolyeFiyati);
            this.groupBox1.Controls.Add(this.AtolyeAdi);
            this.groupBox1.Controls.Add(this.TxtAtolyeAdi);
            this.groupBox1.Controls.Add(this.AtolyeFiyati);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(960, 265);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atölye Girişi";
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
            // TxtAtolyeFiyati
            // 
            this.TxtAtolyeFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAtolyeFiyati.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAtolyeFiyati.Location = new System.Drawing.Point(184, 111);
            this.TxtAtolyeFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAtolyeFiyati.Name = "TxtAtolyeFiyati";
            this.TxtAtolyeFiyati.Size = new System.Drawing.Size(582, 30);
            this.TxtAtolyeFiyati.TabIndex = 14;
            // 
            // AtolyeAdi
            // 
            this.AtolyeAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtolyeAdi.AutoSize = true;
            this.AtolyeAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AtolyeAdi.Location = new System.Drawing.Point(22, 59);
            this.AtolyeAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtolyeAdi.Name = "AtolyeAdi";
            this.AtolyeAdi.Size = new System.Drawing.Size(116, 23);
            this.AtolyeAdi.TabIndex = 1;
            this.AtolyeAdi.Text = "Atölyenin Adı:";
            // 
            // TxtAtolyeAdi
            // 
            this.TxtAtolyeAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAtolyeAdi.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAtolyeAdi.Location = new System.Drawing.Point(184, 53);
            this.TxtAtolyeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAtolyeAdi.Name = "TxtAtolyeAdi";
            this.TxtAtolyeAdi.Size = new System.Drawing.Size(582, 30);
            this.TxtAtolyeAdi.TabIndex = 2;
            // 
            // AtolyeFiyati
            // 
            this.AtolyeFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtolyeFiyati.AutoSize = true;
            this.AtolyeFiyati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AtolyeFiyati.Location = new System.Drawing.Point(22, 117);
            this.AtolyeFiyati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtolyeFiyati.Name = "AtolyeFiyati";
            this.AtolyeFiyati.Size = new System.Drawing.Size(53, 23);
            this.AtolyeFiyati.TabIndex = 3;
            this.AtolyeFiyati.Text = "Fiyatı:";
            // 
            // Admin_AtolyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(1008, 880);
            this.Name = "Admin_AtolyeGiris";
            this.Text = "Admin_AtolyeGiris";
            this.Load += new System.EventHandler(this.Admin_AtolyeGiris_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Temizle;
        private System.Windows.Forms.Label Yenile;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtAtolyeFiyati;
        private System.Windows.Forms.Label AtolyeAdi;
        private System.Windows.Forms.TextBox TxtAtolyeAdi;
        private System.Windows.Forms.Label AtolyeFiyati;
    }
}