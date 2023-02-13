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
    public partial class Admin_DersPaket : Form
    {
        public Admin_DersPaket()
        {
            InitializeComponent();
        }
        private void Admin_DersPaket_Load(object sender, EventArgs e)
        {
            PaketleriGetir();
        }
        private void PaketleriGetir() //Datagridviewdeki Verileri Getirir
        {
            string Sorgu = "Select * from DersPaketleri";
            DataTable Paketler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Paketler;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Paket Adı";
            dataGridView1.Columns[2].HeaderText = "Fiyatı";
            dataGridView1.Columns[0].Width = 50;
        }
        private void BtnGoster_Click(object sender, EventArgs e)
        {
            PaketleriGetir();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtPaketAdi.Text == "")
            {
                MessageBox.Show("Lütfen Ders Paketi Adını Giriniz.");
                TxtPaketAdi.Focus();
            }
            else if (TxtPaketFiyati.Text == "")
            {
                MessageBox.Show("Lütfen Ders Paketi Fiyatını Giriniz.");
                TxtPaketFiyati.Focus();
            }
            string[] Parametreler = { "@PaketAdi", "@PaketFiyati" };
            string[] Degeler = { TxtPaketAdi.Text, TxtPaketFiyati.Text.Replace(",", ".") };

            bool kontrol = Yardimci.CRUD("DersPaketleriKaydet", Parametreler, Degeler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string[] Parametreler = { "@PaketAdi", "@PaketFiyati", "@Id" };
            string[] Degerler = { TxtPaketAdi.Text, TxtPaketFiyati.Text.Replace(",", "."), labelId.Text };
            bool kontrol = Yardimci.CRUD("DersPaketleriGuncelle", Parametreler, Degerler);
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
                bool kontrol = Yardimci.CRUD("DersPaketleriSil", Parametreler, Degerler);

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
            TxtPaketAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtPaketFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtPaketAdi.Clear();
            TxtPaketFiyati.Clear();
            labelId.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from DersPaketleri where PaketAdi like '%" + TxtAra.Text + "%'";
            DataTable Paketler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource =Paketler;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Paket Adı Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Paket Adı Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
