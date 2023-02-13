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
    public partial class Admin_ProgramGiris : Form
    {
        public Admin_ProgramGiris()
        {
            InitializeComponent();
        }
        private void Admin_ProgramGiris_Load(object sender, EventArgs e)
        {
            EgitmenleriGetir();
            AtolyeleriGetir();
            ProgramlariGetir();
        }

        private void ProgramlariGetir()
        {
            string Sorgu = "Select * from ProgramGiris";
            DataTable Programlar = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Programlar;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Atölye No";
            dataGridView1.Columns[2].HeaderText = "Eğitmen No";
            dataGridView1.Columns[3].HeaderText = "Yaş Grubu";
            dataGridView1.Columns[4].HeaderText = "Program Tarihi";
            dataGridView1.Columns[5].HeaderText = "Gün";
            dataGridView1.Columns[6].HeaderText = "Başlama Saati";
            dataGridView1.Columns[7].HeaderText = "Bitiş Saati";
            dataGridView1.Columns[8].HeaderText = "Fiyat";
            dataGridView1.Columns[0].Width = 50;

        }
        private void EgitmenleriGetir() //ComboBox'a Eğitmen İsimlerini Getirir
        {
            string Sorgu = "SELECT [Id], ([EgitmenAdi] + ' ' + [EgitmenSoyadi]) AS [AdSoyad] FROM [EgitmenGiris]  WHERE [Id]=Id";
            DataTable EgitmenTablo = Yardimci.VeriOku(Sorgu);
            if (EgitmenTablo.Rows.Count > 0)
            {
                CBoxEgitmen.DisplayMember = "AdSoyad";
                CBoxEgitmen.ValueMember = "Id";
                CBoxEgitmen.DataSource = EgitmenTablo;
                CBoxEgitmen.SelectedIndex = -1;
            }
        }
        private void AtolyeleriGetir() //ComboBox'a Atölye İsimlerini Getirir
        {
            string Sorgu = "Select * from AtolyeGiris ";
            DataTable AtolyeTablo = Yardimci.VeriOku(Sorgu);
            if (AtolyeTablo.Rows.Count > 0)
            {
                CBoxAtolye.DisplayMember = "AtolyeAdi";
                CBoxAtolye.ValueMember = "Id";
                CBoxAtolye.DataSource = AtolyeTablo;
                CBoxAtolye.SelectedIndex = -1;
            }      
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //Tarih Seçimine Göre Gün Gelir
        {
            TxtProgramGunu.Text = dateTimeTarih.Value.DayOfWeek.ToString();
        }

        private void CBoxAtolye_SelectedIndexChanged(object sender, EventArgs e) //Atölye Seçimine Göre Veri Tabanındaki Fiyatını Getirir
        {
            if (CBoxAtolye.SelectedIndex > 0)
            {
                string Sorgu = "Select AtolyeFiyati from AtolyeGiris where Id = " + CBoxAtolye.SelectedValue.ToString();
                DataTable Fiyat = Yardimci.VeriOku(Sorgu);
                TxtFiyat.Text = Fiyat.Rows[0]["AtolyeFiyati"].ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (CBoxAtolye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Atölye Seçiniz.");
                CBoxAtolye.Focus();
            }
            else if (CBoxEgitmen.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Eğitmen Seçiniz.");
                CBoxEgitmen.Focus();
            }
            else if (TxtYasGrubu.Text == "")
            {
                MessageBox.Show("Lütfen Yaş Grubunu Giriniz.");
                TxtYasGrubu.Focus();
            }
            else if (TxtProgramGunu.Text == "")
            {
                MessageBox.Show("Lütfen Tarih Seçiniz.");
                TxtProgramGunu.Focus();
            }
            else if (MTBoxBaslama.Text == "" || MTBoxBitis.Text == "")
            {
                MessageBox.Show("Lütfen Program Saatlerini Giriniz.");
                MTBoxBaslama.Focus();
            }
            string[] Parametreler = { "@AtolyeId", "@EgitmenId", "@YasGrubu", "@ProgramTarihi", "Günü", "@BaslamaSaati", "BitisSaati", "@Fiyati" };
            string[] Degeler = { CBoxAtolye.SelectedValue.ToString(), CBoxEgitmen.SelectedValue.ToString(), TxtYasGrubu.Text.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), TxtProgramGunu.Text.ToString(), MTBoxBaslama.Text.ToString(), MTBoxBitis.Text.ToString(), TxtFiyat.Text.Replace(",", ".") };

            bool kontrol = Yardimci.CRUD("ProgramGirisKaydet", Parametreler, Degeler);
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
            string[] Parametreler = { "@AtolyeId", "EgitmenId", "@YasGrubu", "@ProgramTarihi", "Günü", "@BaslamaSaati", "BitisSaati", "@Fiyati", "@Id" };
            string[] Degerler = { CBoxAtolye.SelectedValue.ToString(), CBoxEgitmen.SelectedValue.ToString(), TxtYasGrubu.Text.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), TxtProgramGunu.Text.ToString(), MTBoxBaslama.Text.ToString(), MTBoxBitis.Text.ToString(), TxtFiyat.Text.Replace(",", "."), labelId.Text };
            bool kontrol = Yardimci.CRUD("ProgramGirisGuncelle", Parametreler, Degerler);
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
                bool kontrol = Yardimci.CRUD("ProgramGirisSil", Parametreler, Degerler);

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
            CBoxAtolye.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CBoxEgitmen.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtYasGrubu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimeTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtProgramGunu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            MTBoxBaslama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            MTBoxBitis.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TxtFiyat.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CBoxAtolye.SelectedIndex = -1;
            CBoxEgitmen.SelectedIndex = -1;
            TxtYasGrubu.Clear();
            dateTimeTarih.Value = DateTime.Today;
            TxtProgramGunu.Clear();
            MTBoxBaslama.Clear();
            MTBoxBitis.Clear();
            TxtFiyat.Clear();
            labelId.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select * from ProgramGiris where Günü like '%" + TxtAra.Text + "%'";
            DataTable Program = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Program;
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            ProgramlariGetir();
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Gün Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Gün Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
    
}
