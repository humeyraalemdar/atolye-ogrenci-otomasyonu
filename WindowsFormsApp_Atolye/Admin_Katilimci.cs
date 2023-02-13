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
    public partial class Admin_Katilimci : Form
    {
        public Admin_Katilimci()
        {
            InitializeComponent();
        }
        private void Admin_Katilimci_Load(object sender, EventArgs e)
        {
            KatilimcilariGetir();
        }
        private void KatilimcilariGetir() //Datagridviewdeki Verileri Getirir
        {
            string Sorgu = "Select * from KatilimciGiris";
            DataTable Katilimcilar = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Katilimcilar;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Katılımcı Adı";
            dataGridView1.Columns[2].HeaderText = "Katılımcı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Veli Adı";
            dataGridView1.Columns[4].HeaderText = "Veli Soyadı";
            dataGridView1.Columns[5].HeaderText = "Telefon";
            dataGridView1.Columns[6].HeaderText = "Adres";
            dataGridView1.Columns[7].HeaderText = "Mail";
            dataGridView1.Columns[0].Width = 50;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKatilimciAdi.Text == "")
            {
                MessageBox.Show("Lütfen Katılımcı Adını Giriniz.");
                TxtKatilimciAdi.Focus();
            }
            else if (TxtKatilimciSoyadi.Text == "")
            {
                MessageBox.Show("Lütfen Katılımcı Soyadını Giriniz.");
                TxtKatilimciSoyadi.Focus();
            }
            else if (TxtVeliAdi.Text == "")
            {
                MessageBox.Show("Lütfen Veli Adını Giriniz.");
                TxtVeliAdi.Focus();
            }
            else if (TxtVeliSoyadi.Text == "")
            {
                MessageBox.Show("Lütfen Veli Soyadını Giriniz.");
                TxtVeliSoyadi.Focus();
            }
            else if (MTxtTelefon.Text.Replace("(   )    -", "") == "")
            {
                MessageBox.Show("Lütfen Telefon Numarası Giriniz.");
                MTxtTelefon.Focus();
            }
            else
            {
                string[] Parametreler = { "@KatilimciAdi", "@KatilimciSoyadi", "@VeliAdi", "@VeliSoyadi", "@KatilimciTelefon", "@KatilimciAdresi", "@KatilimciMaili" };
                string[] Degeler = { TxtKatilimciAdi.Text, TxtKatilimciSoyadi.Text, TxtVeliAdi.Text, TxtVeliSoyadi.Text, MTxtTelefon.Text, RTxtAdresi.Text, TxtMail.Text };

                bool kontrol = Yardimci.CRUD("KatilimciGirisKaydet", Parametreler, Degeler);
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
            string[] Parametreler = { "@KatilimciAdi", "@KatilimciSoyadi", "@VeliAdi", "@VeliSoyadi", "@KatilimciTelefon", "@KatilimciAdresi", "@KatilimciMaili", "@Id" };
            string[] Degerler = { TxtKatilimciAdi.Text.ToString(), TxtKatilimciSoyadi.Text.ToString(), TxtVeliAdi.Text.ToString(), TxtVeliSoyadi.Text.ToString(), MTxtTelefon.Text.ToString(), RTxtAdresi.Text.ToString(), TxtMail.Text.ToString(), labelId.Text };
            bool kontrol = Yardimci.CRUD("KatilimciGirisGuncelle", Parametreler, Degerler);
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
                bool kontrol = Yardimci.CRUD("KatilimciGirisSil", Parametreler, Degerler);

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
            TxtKatilimciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtKatilimciSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtVeliAdi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtVeliSoyadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MTxtTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            RTxtAdresi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();          
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            KatilimcilariGetir();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtKatilimciAdi.Clear();
            TxtKatilimciSoyadi.Clear();
            TxtVeliAdi.Clear();
            TxtVeliSoyadi.Clear();
            MTxtTelefon.Clear();
            RTxtAdresi.Clear();
            TxtMail.Clear();
            labelId.Text = "";
        }
        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from KatilimciGiris where KatilimciAdi like '%" + TxtAra.Text + "%'";
            DataTable Katilimci = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Katilimci;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Katılımcı Adı Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }
        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Katılımcı Adı Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
