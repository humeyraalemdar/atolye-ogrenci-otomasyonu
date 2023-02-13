using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp_Atolye
{
    public partial class Admin_Tahsilat : Form
    {
        public Admin_Tahsilat()
        {
            InitializeComponent();
        }
        private void Admin_Tahsilat_Load(object sender, EventArgs e) //Sayfa Yüklendiğinde Verileri Getirir
        {
            KatilimcilariGetir();
            TahsilatlariGetir();
        }
        private void KatilimcilariGetir() //ComboBox'a Katilimci İsimlerini Getirir
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
        private void TahsilatlariGetir() //Datagridviewdeki Verileri Getirir
        {
            string Sorgu = "Select * from Tahsilat";
            DataTable Tahsilatlar = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Tahsilatlar;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Katılımcı No";
            dataGridView1.Columns[2].HeaderText = "Tarih";
            dataGridView1.Columns[3].HeaderText = "Tutar";
            dataGridView1.Columns[0].Width = 50;
        }

        private void BtnKaydet_Click(object sender, EventArgs e) //Kaydet Butonu için
        {
            if (CBoxKatilimci.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Katılımcı Seçiniz.");
                CBoxKatilimci.Focus();
            }
            else if (TxtTutar.Text == "")
            {
                MessageBox.Show("Lütfen Tahsilat Tutarını Giriniz.");
                TxtTutar.Focus();
            }
            else
            {
                string[] Parametreler = { "@KatilimciId", "@Tarih", "@Tutar" };
                string[] Degeler = { CBoxKatilimci.SelectedValue.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), TxtTutar.Text };

                bool kontrol = Yardimci.CRUD("TahsilatKaydet", Parametreler, Degeler);
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string[] Parametreler = { "@KatilimciId", "@Tarih", "@Tutar", "@Id" };
            string[] Degerler = { CBoxKatilimci.SelectedValue.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), TxtTutar.Text.Replace(",", "."), labelId.Text };
            bool kontrol = Yardimci.CRUD("TahsilatGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string[] Parametreler = { "@Id" };
            string[] Degerler = { labelId.Text };

            DialogResult cevap;  //Silme İşlemi Kontrol Sorusu
            cevap = MessageBox.Show("Silmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);

            if (cevap == DialogResult.Yes)
            {
                bool kontrol = Yardimci.CRUD("TahsilatSil", Parametreler, Degerler);

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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
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
            TxtTutar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            TahsilatlariGetir();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CBoxKatilimci.SelectedIndex = -1;
            dateTimeTarih.Value = DateTime.Today;
            TxtTutar.Clear();
            labelId.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from Tahsilat where Tutar like '%" + TxtAra.Text + "%'";
            DataTable Tahsilat = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Tahsilat;
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
