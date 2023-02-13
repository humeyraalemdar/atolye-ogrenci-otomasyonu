using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Atolye
{
    public partial class Admin_AtolyeGiris : Form
    {
        public Admin_AtolyeGiris()
        {
            InitializeComponent();        
        }
        private void Admin_AtolyeGiris_Load(object sender, EventArgs e) //Sayfa Yüklendiğinde Verileri Getirir
        {
            AtolyeleriGetir();
        }
        private void AtolyeleriGetir() //Datagridviewdeki Verileri Getirir
        {
            string Sorgu = "Select * from AtolyeGiris";
            DataTable Atolyeler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Atolyeler;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Atölye Adı";
            dataGridView1.Columns[2].HeaderText = "Fiyatı";
            dataGridView1.Columns[0].Width = 50;
        }
        private void BtnGoster_Click(object sender, EventArgs e) //Yenile Butonu İçin
        {
            AtolyeleriGetir();
        }
        private void BtnKaydet_Click(object sender, EventArgs e) //Kaydet Butonu İçin
        {
            if (TxtAtolyeAdi.Text == "")
            {
                MessageBox.Show("Lütfen Atölye Adını Giriniz.");
                TxtAtolyeAdi.Focus();
            }
            else if (TxtAtolyeFiyati.Text == "")
            {
                MessageBox.Show("Lütfen Atölye Fiyatını Giriniz.");
                TxtAtolyeFiyati.Focus();
            }
            string[] Parametreler = { "@AtolyeAdi", "@AtolyeFiyati" };
            string[] Degeler = { TxtAtolyeAdi.Text, TxtAtolyeFiyati.Text.Replace(",", ".") };

            bool kontrol = Yardimci.CRUD("AtolyeGirisKaydet", Parametreler, Degeler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e) //Güncelle Butonu İçin
        {     
            string[] Parametreler = {"@AtolyeAdi", "@AtolyeFiyati", "@Id" };
            string[] Degerler = {TxtAtolyeAdi.Text, TxtAtolyeFiyati.Text.Replace(",", "."), labelId.Text };
            bool kontrol = Yardimci.CRUD("AtolyeGirisGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }
        private void BtnSil_Click(object sender, EventArgs e)  //Sil Butonu İçin
        {
            string[] Parametreler = { "@Id" };
            string[] Degerler = { labelId.Text };

            DialogResult cevap;  //Silme İşlemi Kontrol Sorusu
            cevap = MessageBox.Show("Silmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            
            if (cevap == DialogResult.Yes)
            {
                bool kontrol = Yardimci.CRUD("AtolyeGirisSil", Parametreler, Degerler);

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
                MessageBox.Show("Silme İşlemi Gerçekleşmedi.","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) //Datagridviewdeki Satırları Seçer
        {
            if (dataGridView1.CurrentRow.Index > -1)
            {
                int Secilen = dataGridView1.CurrentRow.Index;
                string SecilenId = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
                labelId.Text = SecilenId.ToString();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Textboxa Yazdırır
        {
            TxtAtolyeAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtAtolyeFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e) //Temizle Butonu İçin
        {
            TxtAtolyeAdi.Clear();
            TxtAtolyeFiyati.Clear();
            labelId.Text = "";
        }
        private void BtnAra_Click(object sender, EventArgs e) //Arama Butonu İçin
        {
            string Sorgu = "Select * from AtolyeGiris where AtolyeAdi like '%" + TxtAra.Text + "%'";
            DataTable Atolyeler = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Atolyeler;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Atöyle Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Atöyle Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
    