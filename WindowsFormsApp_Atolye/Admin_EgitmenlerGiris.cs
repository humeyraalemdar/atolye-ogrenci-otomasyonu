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
    public partial class Admin_EgitmenlerGiris : Form
    {
        public Admin_EgitmenlerGiris()
        {
            InitializeComponent();
        }
        private void Admin_EgitmenlerGiris_Load(object sender, EventArgs e)
        {
            EgitmenleriGetir();
        }
        private void EgitmenleriGetir() //Datagridviewdeki Verileri Getirir
        {
            string Sorgu = "Select * from EgitmenGiris";
            DataTable Egitmenler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Egitmenler;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Eğitmen Adı";
            dataGridView1.Columns[2].HeaderText = "Eğitmen Soyadı";
            dataGridView1.Columns[3].HeaderText = "Adresi";
            dataGridView1.Columns[4].HeaderText = "Uzmanlık Alanı";
            dataGridView1.Columns[0].Width = 50;
        }
        private void BtnGoster_Click(object sender, EventArgs e)
        {
            EgitmenleriGetir();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtEgitmenAdi.Text == "")
            {
                MessageBox.Show("Lütfen Eğitmen Adını Giriniz.");
                TxtEgitmenAdi.Focus();
            }
            else if (TxtEgitmenSoyadi.Text == "")
            {
                MessageBox.Show("Lütfen Eğitmen Soyadını Giriniz.");
                TxtEgitmenSoyadi.Focus();
            }
            else if (RTxtAdresi.Text == "")
            {
                MessageBox.Show("Lütfen Eğitmen Adresini Giriniz.");
                RTxtAdresi.Focus();
            }
            else if (RTxtUzmanlik.Text == "")
            {
                MessageBox.Show("Lütfen Uzmanlık Alanı Giriniz.");
                RTxtUzmanlik.Focus();
            }
            else
            {
                string[] Parametreler = { "@EgitmenAdi", "@EgitmenSoyadi", "@EgitmenAdresi", "@UzmanlikAlani" };
                string[] Degeler = { TxtEgitmenAdi.Text, TxtEgitmenSoyadi.Text, RTxtAdresi.Text, RTxtUzmanlik.Text };

                bool kontrol = Yardimci.CRUD("EgitmenGirisKaydet", Parametreler, Degeler);
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
            string[] Parametreler = { "@EgitmenAdi", "@EgitmenSoyadi", "@EgitmenAdresi", "@UzmanlikAlani", "@Id" };
            string[] Degerler = { TxtEgitmenAdi.Text, TxtEgitmenSoyadi.Text, RTxtAdresi.Text, RTxtUzmanlik.Text, labelId.Text };
            bool kontrol = Yardimci.CRUD("EgitmenGirisGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TxtEgitmenAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtEgitmenSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            RTxtAdresi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            RTxtUzmanlik.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string[] Parametreler = { "@Id" };
            string[] Degerler = { labelId.Text };

            DialogResult cevap;  //Silme İşlemi Kontrol Sorusu
            cevap = MessageBox.Show("Silmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);

            if (cevap == DialogResult.Yes)
            {
                bool kontrol = Yardimci.CRUD("EgitmenGirisSil", Parametreler, Degerler);

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
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtEgitmenAdi.Clear();
            TxtEgitmenSoyadi.Clear();
            RTxtAdresi.Clear();
            RTxtUzmanlik.Clear();
            labelId.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from EgitmenGiris where EgitmenAdi like '%" + TxtAra.Text + "%'";
            DataTable Paketler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Paketler;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Eğitmen Adı Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Eğitmen Adı Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
