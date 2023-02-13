using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Atolye
{
    public partial class Admin_Siparis : Form
    {
        public Admin_Siparis()
        {
            InitializeComponent();
        }
        private void Admin_Siparis_Load(object sender, EventArgs e)
        {
            KatilimciGetir();
            PaketGetir();
            AtolyeleriGetir();
            SiparisGetir();
            TabloGetir();
            SiparisDataGetir();
        }
        private void TabloGetir() //Datagridview2deki Siparis Paketleri Verilerini Getirir
        {
            string Sorgu = "Select * from SiparisSatirlari";
            DataTable Tablo = Yardimci.VeriOku(Sorgu);
            dataGridView2.DataSource = Tablo;
            dataGridView2.Columns[0].HeaderText = "Sipariş Paketi No";
            dataGridView2.Columns[1].HeaderText = "Sipariş No";
            dataGridView2.Columns[2].HeaderText = "Paket No";
            dataGridView2.Columns[3].HeaderText = "Atölye No";
            dataGridView2.Columns[4].HeaderText = "Birim Fiyatı";
            dataGridView2.Columns[5].HeaderText = "Ders Saati";
            dataGridView2.Columns[6].HeaderText = "İndirim Oranı";
            dataGridView2.Columns[7].HeaderText = "Tutar";
            dataGridView2.Columns[0].Width = 50;
        }
        private void SiparisDataGetir() //Datagridviewdeki Sipariş Verilerini Getirir
        {
            string Sorgu = "Select * from SiparisGiris";
            DataTable Siparisler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Siparisler;
            dataGridView1.Columns[0].HeaderText = "Sipariş No";
            dataGridView1.Columns[1].HeaderText = "Katılımcı No";
            dataGridView1.Columns[2].HeaderText = "Tarih";
            dataGridView1.Columns[0].Width = 50;
        }
        private void KatilimciGetir() //ComboBox'a Katılımcı İsimlerini Getirir
        {
            string Sorgu = "SELECT [Id], ([KatilimciAdi] + ' ' + [KatilimciSoyadi]) AS [AdSoyad] FROM [KatilimciGiris]  WHERE [Id]=Id";
            DataTable KatilimciTablo = Yardimci.VeriOku(Sorgu);
            if (KatilimciTablo.Rows.Count > 0)
            {
                CBoxKatilimci.DisplayMember = "AdSoyad";
                CBoxKatilimci.ValueMember = "Id";
                CBoxKatilimci.DataSource = KatilimciTablo;
                CBoxKatilimci.SelectedIndex = -1;
            }
        }
        private void PaketGetir() //ComboBox'a Ders Paketleri İsimlerini Getirir
        {
            string Sorgu = "Select * from DersPaketleri ";
            DataTable PaketTablo = Yardimci.VeriOku(Sorgu);
            if (PaketTablo.Rows.Count > 0)
            {
                CBoxPaket.DisplayMember = "PaketAdi";
                CBoxPaket.ValueMember = "Id";
                CBoxPaket.DataSource = PaketTablo;
                CBoxPaket.SelectedIndex = -1;
            }

        }
        private void SiparisGetir() //ComboBox'a Siparis İsimlerini Getirir
        {
            string Sorgu = "Select * from SiparisGiris ";
            DataTable SiparisTablo = Yardimci.VeriOku(Sorgu);
            if (SiparisTablo.Rows.Count > 0)
            {
                CBoxSiparis.DisplayMember = "Id";
                CBoxSiparis.ValueMember = "Id";
                CBoxSiparis.DataSource = SiparisTablo;
                CBoxSiparis.SelectedIndex = -1;
            }
        }


        private void AtolyeleriGetir() //ComboBox'a Atölye İsimlerini Getirir
        {
            string Sorgu = "Select * from AtolyeGiris ";
            //Sorgu += " where Id = " + CBoxAtolye.SelectedValue.ToString();
            DataTable AtolyeTablo = Yardimci.VeriOku(Sorgu);
            if (AtolyeTablo.Rows.Count > 0)
            {
                CBoxAtolye.DisplayMember = "AtolyeAdi";
                CBoxAtolye.ValueMember = "Id";
                CBoxAtolye.DataSource = AtolyeTablo;
                CBoxAtolye.SelectedIndex = -1;
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e) //Kaydet Butonu İçin
        {
            if (CBoxKatilimci.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Katılımcı Seçiniz.");
                CBoxKatilimci.Focus();
            }
            else
            {
                string[] Parametreler = { "@KatilimciId", "@Tarih" };
                string[] Degeler = { CBoxKatilimci.SelectedValue.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd") };

                bool kontrol = Yardimci.CRUD("SiparisGirisKaydet", Parametreler, Degeler);
                if (kontrol)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SiparisDataGetir();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e) //Guncelle Butonu İçin
        {
            string[] Parametreler = { "@KatilimciId", "@Tarih", "@Id" };
            string[] Degerler = { CBoxKatilimci.SelectedValue.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), labelId.Text };
            bool kontrol = Yardimci.CRUD("SiparisGirisGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SiparisDataGetir();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSil_Click(object sender, EventArgs e) //Sil Butonu İçin
        {
            string[] Parametreler = { "@Id" };
            string[] Degerler = { labelId.Text };

            DialogResult cevap;  //Silme İşlemi Kontrol Sorusu
            cevap = MessageBox.Show("Silmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);

            if (cevap == DialogResult.Yes)
            {
                bool kontrol = Yardimci.CRUD("SiparisGirisSil", Parametreler, Degerler);

                if (kontrol)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SiparisDataGetir();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silme İşlemi Gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) //Datagridviewdeki Satırları Secer
        {
            if (dataGridView1.CurrentRow.Index > -1)
            {
                int Secilen = dataGridView1.CurrentRow.Index;
                string SecilenId = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
                labelId.Text = SecilenId.ToString();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CBoxKatilimci.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimeTarih.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e) //2. Kaydet Butonu İçin
        {
            if (CBoxSiparis.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Sipariş No Seçiniz.");
                CBoxSiparis.Focus();
            }
            else if (CBoxPaket.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Paket No Seçiniz.");
                CBoxPaket.Focus();
            }
            else if (CBoxAtolye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Atölye Seçiniz.");
                CBoxAtolye.Focus();
            }
            else if (TxtDersSaati.Text == "")
            {
                MessageBox.Show("Lütfen Ders Saati Giriniz.");
                TxtDersSaati.Focus();
            }
            else if (TxtIndirim.Text == "")
            {
                MessageBox.Show("Lütfen İndirim Oranı Giriniz.");
                TxtIndirim.Focus();
            }
            else
            {
                string[] Parametreler = { "@SiparisId", "@PaketId", "@AtolyeId", "@BirimFiyat", "@DersSaati", "@IndirimOrani", "@Tutar" };
                string[] Degeler = { CBoxSiparis.SelectedValue.ToString(), CBoxPaket.SelectedValue.ToString(), CBoxAtolye.SelectedValue.ToString(), TxtFiyat.Text.Replace(",", "."), TxtDersSaati.Text.Replace(",", "."), TxtIndirim.Text.Replace(",", "."), TxtTutar.Text.Replace(",", ".") };

                bool kontrol = Yardimci.CRUD("SiparisSatirlariKaydet", Parametreler, Degeler);
                if (kontrol)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnGuncelle2_Click(object sender, EventArgs e)
        {
            string[] Parametreler = { "@SiparisId", "@PaketId", "AtolyeId", "@BirimFiyat", "@DersSaati", "@IndirimOrani", "@Tutar", "@Id" };
            string[] Degerler = { CBoxSiparis.SelectedValue.ToString(), CBoxPaket.SelectedValue.ToString(), CBoxAtolye.SelectedValue.ToString(), TxtFiyat.Text.Replace(",", "."), TxtDersSaati.Text.Replace(",", "."), TxtIndirim.Text.Replace(",", "."), TxtTutar.Text.Replace(",", "."), labelId2.Text };
            bool kontrol = Yardimci.CRUD("SiparisSatirlariGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnSil2_Click(object sender, EventArgs e)
        {
            string[] Parametreler = { "@Id" };
            string[] Degerler = { labelId2.Text };

            DialogResult cevap;  //Silme İşlemi Kontrol Sorusu
            cevap = MessageBox.Show("Silmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);

            if (cevap == DialogResult.Yes)
            {
                bool kontrol = Yardimci.CRUD("SiparisSatirlariSil", Parametreler, Degerler);

                if (kontrol)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silme İşlemi Gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CBoxAtolye_SelectedIndexChanged(object sender, EventArgs e) //Atölye Seçimine Göre Veri Tabanındaki Fiyatını Getirir
        {
            if (CBoxAtolye.SelectedIndex>0)
            {
                string Sorgu = "Select AtolyeFiyati from AtolyeGiris where Id = " + CBoxAtolye.SelectedValue.ToString();
                DataTable Fiyat = Yardimci.VeriOku(Sorgu);
                TxtFiyat.Text = Fiyat.Rows[0]["AtolyeFiyati"].ToString();

            }           
        }

        private void BtnTutar_Click(object sender, EventArgs e) //Tutar Hesaplama Butonu
        {
            double fiyat;
            double tutar;
            fiyat = Convert.ToDouble(TxtFiyat.Text) * Convert.ToDouble(TxtDersSaati.Text);
            tutar = fiyat - (fiyat * Convert.ToDouble(TxtIndirim.Text)/100);
            TxtTutar.Text = tutar.ToString();   
        }

        
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index > -1)
            {
                int Secilen = dataGridView2.CurrentRow.Index;
                string SecilenId = dataGridView2.Rows[Secilen].Cells[0].Value.ToString();
                labelId2.Text = SecilenId.ToString();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CBoxSiparis.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            CBoxPaket.SelectedValue = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            CBoxAtolye.SelectedValue = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            TxtDersSaati.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            TxtIndirim.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            TxtTutar.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();        
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            TabloGetir();
            SiparisDataGetir();
            SiparisGetir();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CBoxKatilimci.SelectedIndex = -1;
            dateTimeTarih.Value = DateTime.Today;
            CBoxSiparis.SelectedIndex = -1;
            CBoxPaket.SelectedIndex = -1;
            CBoxAtolye.SelectedIndex = -1;
            TxtFiyat.Clear();
            TxtDersSaati.Clear();
            TxtIndirim.Clear();
            TxtTutar.Clear();
            labelId.Text = "";
            labelId2.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from SiparisSatirlari where SiparisId like '%" + TxtAra.Text + "%'";
            DataTable Siparis = Yardimci.VeriOku(Sorgu);
            dataGridView2.DataSource = Siparis;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Sipariş No Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Sipariş No Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
