using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Atolye
{
    public partial class Admin_Giderler : Form
    {
        public Admin_Giderler()
        {
            InitializeComponent();
        }
        private void Admin_Giderler_Load(object sender, EventArgs e)
        {
            MasrafDataGetir();
            MasraflariGetir();
            GiderDataGetir();
        }
        private void MasrafDataGetir() //Datagridviewdeki Masraf Verilerini Getirir
        {
            string Sorgu = "Select * from Masraflar";
            DataTable Masraflar = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Masraflar;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Masraf Adı";
            dataGridView1.Columns[0].Width = 50;
        }
        private void MasraflariGetir() //ComboBox'a Masraf İsimlerini Getirir
        {
            string Sorgu = "Select * from Masraflar ";
            DataTable MasrafTablo = Yardimci.VeriOku(Sorgu);
            if (MasrafTablo.Rows.Count > 0)
            {
                CBoxMasraf.DisplayMember = "MasrafAdi";
                CBoxMasraf.ValueMember = "Id";
                CBoxMasraf.DataSource = MasrafTablo;
                CBoxMasraf.SelectedIndex = -1;
            }
        }
        private void GiderDataGetir() //Datagridview2deki Gider Verilerini Getirir
        {
            string Sorgu = "Select * from Giderler";
            DataTable Giderler = Yardimci.VeriOku(Sorgu);
            dataGridView2.DataSource = Giderler;
            dataGridView2.Columns[0].HeaderText = "No";
            dataGridView2.Columns[1].HeaderText = "Masraf No";
            dataGridView2.Columns[2].HeaderText = "Tarih";
            dataGridView2.Columns[3].HeaderText = "Tutar";
            dataGridView2.Columns[0].Width = 50;
        }

        private void BtnKaydet_Click(object sender, EventArgs e) //Masraf Kaydet Butonu İçin
        {
            if (TxtMasraf.Text == "")
            {
                MessageBox.Show("Lütfen Masraf Adını Giriniz.");
                TxtMasraf.Focus();
            }
            else
            {
                string[] Parametreler = { "@MasrafAdi" };
                string[] Degeler = { TxtMasraf.Text.ToString() };

                bool kontrol = Yardimci.CRUD("MasraflarKaydet", Parametreler, Degeler);
                if (kontrol)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MasrafDataGetir();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e) //Masraf Güncelle Butonu İçin
        {
            string[] Parametreler = { "@MasrafAdi", "@Id" };
            string[] Degerler = { TxtMasraf.Text, labelId.Text };
            bool kontrol = Yardimci.CRUD("MasraflarGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MasrafDataGetir();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSil_Click(object sender, EventArgs e) //Masraf Sil Butonu İçin
        {
            string[] Parametreler = { "@Id" };
            string[] Degerler = { labelId.Text };

            DialogResult cevap;  //Silme İşlemi Kontrol Sorusu
            cevap = MessageBox.Show("Silmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);

            if (cevap == DialogResult.Yes)
            {
                bool kontrol = Yardimci.CRUD("MasraflarSil", Parametreler, Degerler);

                if (kontrol)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MasrafDataGetir();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) //Masraf Datagridviewdeki Satırları Seçer
        {
            if (dataGridView1.CurrentRow.Index > -1)
            {
                int Secilen = dataGridView1.CurrentRow.Index;
                string SecilenId = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
                labelId.Text = SecilenId.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Masraf Textboxa Yazdırır
        {
            TxtMasraf.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e) //Gider Kaydet Butonu İçin
        {
            if (CBoxMasraf.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Masraf Adı Seçiniz.");
                CBoxMasraf.Focus();
            }
            else if (TxtTutar.Text == "")
            {
                MessageBox.Show("Lütfen Tutar Giriniz.");
                TxtTutar.Focus();
            }
            else
            {
                string[] Parametreler = { "@MasrafId", "@Tarih", "@Tutar" };
                string[] Degeler = { CBoxMasraf.SelectedValue.ToString(), dateTimeGiderTarih.Value.Date.ToString("yyyy-MM-dd"), TxtTutar.Text.ToString() };

                bool kontrol = Yardimci.CRUD("GiderlerKaydet", Parametreler, Degeler);
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

        private void BtnGuncelle2_Click(object sender, EventArgs e) //Gider Guncelle Butonu İçin
        {
            string[] Parametreler = { "@MasrafId", "@Tarih", "@Tutar", "@Id" };
            string[] Degerler = { CBoxMasraf.SelectedValue.ToString(), dateTimeGiderTarih.Value.Date.ToString("yyyy-MM-dd"), TxtTutar.Text.Replace(",", "."), labelId2.Text };
            bool kontrol = Yardimci.CRUD("GiderlerGuncelle", Parametreler, Degerler);
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
                bool kontrol = Yardimci.CRUD("MasraflarSil", Parametreler, Degerler);

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

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Giderleri Alanlara Yazdırır
        {
            CBoxMasraf.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            dateTimeGiderTarih.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            TxtTutar.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e) // Datagridview2deki Satırları Seçer
        {
            if (dataGridView2.CurrentRow.Index > -1)
            {
                int Secilen = dataGridView2.CurrentRow.Index;
                string SecilenId = dataGridView2.Rows[Secilen].Cells[0].Value.ToString();
                labelId2.Text = SecilenId.ToString();
            }
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CBoxMasraf.SelectedIndex = -1;
            dateTimeGiderTarih.Value = DateTime.Today;
            TxtTutar.Clear();
            TxtMasraf.Clear();
            labelId.Text = "";
            labelId2.Text = "";
        }
        private void BtnGoster_Click(object sender, EventArgs e)
        {
            GiderDataGetir();
            MasrafDataGetir();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from Giderler where Tutar like '%" + TxtAra.Text + "%'";
            DataTable Tutar = Yardimci.VeriOku(Sorgu);
            dataGridView2.DataSource = Tutar;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Tutar Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Tutar Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
