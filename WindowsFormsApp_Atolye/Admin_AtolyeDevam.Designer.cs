namespace WindowsFormsApp_Atolye
{
    partial class Admin_AtolyeDevam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AtolyeDevam));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.CBoxKatilimci = new System.Windows.Forms.ComboBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.rBGelmedi = new System.Windows.Forms.RadioButton();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.rBGeldi = new System.Windows.Forms.RadioButton();
            this.Temizle = new System.Windows.Forms.Label();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.Yenile = new System.Windows.Forms.Label();
            this.Tarih = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.CBoxAtolye = new System.Windows.Forms.ComboBox();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.KatilimciAdiSoyadi = new System.Windows.Forms.Label();
            this.KatıldıgıAtolye = new System.Windows.Forms.Label();
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
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.CBoxKatilimci);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.rBGelmedi);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.rBGeldi);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.dateTimeTarih);
            this.groupBox1.Controls.Add(this.Yenile);
            this.groupBox1.Controls.Add(this.Tarih);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.CBoxAtolye);
            this.groupBox1.Controls.Add(this.BtnGoster);
            this.groupBox1.Controls.Add(this.KatilimciAdiSoyadi);
            this.groupBox1.Controls.Add(this.KatıldıgıAtolye);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(964, 373);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atölye Devam Durumu";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnKaydet.Location = new System.Drawing.Point(250, 296);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 35);
            this.BtnKaydet.TabIndex = 56;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Devam Durumu:";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(746, 302);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 23);
            this.labelId.TabIndex = 55;
            this.labelId.Text = "label1";
            this.labelId.Visible = false;
            // 
            // CBoxKatilimci
            // 
            this.CBoxKatilimci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxKatilimci.FormattingEnabled = true;
            this.CBoxKatilimci.Location = new System.Drawing.Point(250, 50);
            this.CBoxKatilimci.Margin = new System.Windows.Forms.Padding(4);
            this.CBoxKatilimci.Name = "CBoxKatilimci";
            this.CBoxKatilimci.Size = new System.Drawing.Size(490, 31);
            this.CBoxKatilimci.TabIndex = 32;
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSil.Location = new System.Drawing.Point(574, 296);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 35);
            this.BtnSil.TabIndex = 54;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // rBGelmedi
            // 
            this.rBGelmedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBGelmedi.AutoSize = true;
            this.rBGelmedi.Location = new System.Drawing.Point(405, 229);
            this.rBGelmedi.Name = "rBGelmedi";
            this.rBGelmedi.Size = new System.Drawing.Size(94, 27);
            this.rBGelmedi.TabIndex = 31;
            this.rBGelmedi.TabStop = true;
            this.rBGelmedi.Text = "Gelmedi";
            this.rBGelmedi.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnGuncelle.Location = new System.Drawing.Point(412, 296);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 35);
            this.BtnGuncelle.TabIndex = 53;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // rBGeldi
            // 
            this.rBGeldi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBGeldi.AutoSize = true;
            this.rBGeldi.Location = new System.Drawing.Point(250, 229);
            this.rBGeldi.Name = "rBGeldi";
            this.rBGeldi.Size = new System.Drawing.Size(70, 27);
            this.rBGeldi.TabIndex = 30;
            this.rBGeldi.TabStop = true;
            this.rBGeldi.Text = "Geldi";
            this.rBGeldi.UseVisualStyleBackColor = true;
            // 
            // Temizle
            // 
            this.Temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temizle.AutoSize = true;
            this.Temizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(873, 117);
            this.Temizle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(66, 23);
            this.Temizle.TabIndex = 52;
            this.Temizle.Text = "Temizle";
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeTarih.Location = new System.Drawing.Point(250, 173);
            this.dateTimeTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(490, 30);
            this.dateTimeTarih.TabIndex = 29;
            // 
            // Yenile
            // 
            this.Yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yenile.AutoSize = true;
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.Location = new System.Drawing.Point(873, 59);
            this.Yenile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(54, 23);
            this.Yenile.TabIndex = 51;
            this.Yenile.Text = "Yenile";
            // 
            // Tarih
            // 
            this.Tarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tarih.AutoSize = true;
            this.Tarih.Location = new System.Drawing.Point(71, 173);
            this.Tarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(50, 23);
            this.Tarih.TabIndex = 28;
            this.Tarih.Text = "Tarih:";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTemizle.FlatAppearance.BorderSize = 0;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(798, 111);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(53, 34);
            this.BtnTemizle.TabIndex = 50;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // CBoxAtolye
            // 
            this.CBoxAtolye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxAtolye.FormattingEnabled = true;
            this.CBoxAtolye.Location = new System.Drawing.Point(250, 107);
            this.CBoxAtolye.Margin = new System.Windows.Forms.Padding(4);
            this.CBoxAtolye.Name = "CBoxAtolye";
            this.CBoxAtolye.Size = new System.Drawing.Size(490, 31);
            this.CBoxAtolye.TabIndex = 27;
            // 
            // BtnGoster
            // 
            this.BtnGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoster.FlatAppearance.BorderSize = 0;
            this.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoster.Image")));
            this.BtnGoster.Location = new System.Drawing.Point(798, 56);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(53, 34);
            this.BtnGoster.TabIndex = 49;
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // KatilimciAdiSoyadi
            // 
            this.KatilimciAdiSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KatilimciAdiSoyadi.AutoSize = true;
            this.KatilimciAdiSoyadi.Location = new System.Drawing.Point(69, 53);
            this.KatilimciAdiSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KatilimciAdiSoyadi.Name = "KatilimciAdiSoyadi";
            this.KatilimciAdiSoyadi.Size = new System.Drawing.Size(163, 23);
            this.KatilimciAdiSoyadi.TabIndex = 1;
            this.KatilimciAdiSoyadi.Text = "Katılımcı Adı Soyadı:";
            // 
            // KatıldıgıAtolye
            // 
            this.KatıldıgıAtolye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KatıldıgıAtolye.AutoSize = true;
            this.KatıldıgıAtolye.Location = new System.Drawing.Point(69, 110);
            this.KatıldıgıAtolye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KatıldıgıAtolye.Name = "KatıldıgıAtolye";
            this.KatıldıgıAtolye.Size = new System.Drawing.Size(128, 23);
            this.KatıldıgıAtolye.TabIndex = 13;
            this.KatıldıgıAtolye.Text = "Katıldığı Atölye:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 473);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(964, 314);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 275);
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
            this.BtnAra.Location = new System.Drawing.Point(650, 10);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(53, 34);
            this.BtnAra.TabIndex = 58;
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtAra
            // 
            this.TxtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAra.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.ForeColor = System.Drawing.Color.Silver;
            this.TxtAra.Location = new System.Drawing.Point(710, 13);
            this.TxtAra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(267, 30);
            this.TxtAra.TabIndex = 57;
            this.TxtAra.Tag = "";
            this.TxtAra.Text = "Katılımcı No Ara";
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            this.TxtAra.Leave += new System.EventHandler(this.TxtAra_Leave);
            // 
            // Admin_AtolyeDevam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(990, 833);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_AtolyeDevam";
            this.Text = "Admin_AtolyeDevam";
            this.Load += new System.EventHandler(this.Admin_AtolyeDevam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBoxAtolye;
        private System.Windows.Forms.Label KatilimciAdiSoyadi;
        private System.Windows.Forms.Label KatıldıgıAtolye;
        private System.Windows.Forms.RadioButton rBGelmedi;
        private System.Windows.Forms.RadioButton rBGeldi;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.ComboBox CBoxKatilimci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label Temizle;
        private System.Windows.Forms.Label Yenile;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtAra;
    }
}