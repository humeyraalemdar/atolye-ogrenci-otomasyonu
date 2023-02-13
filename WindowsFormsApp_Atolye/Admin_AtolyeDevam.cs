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
    public partial class Admin_AtolyeDevam : Form
    {
        public Admin_AtolyeDevam()
        {
            InitializeComponent();
        }

        private void Admin_AtolyeDevam_Load(object sender, EventArgs e) //Sayfa Yüklendiğinde Verileri Getirir
        {
            DevamDurumuGetir();
            KatilimciGetir();
            AtolyeleriGetir();
        }
        private void BtnGoster_Click(object sender, EventArgs e) //Yenile Butonu İçin
        {
            DevamDurumuGetir();
        }
        private void DevamDurumuGetir() //Datagridviewdeki Verileri Getirir
        {
            string Sorgu = "Select * from AtolyeDevam";
            DataTable Devam = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Devam;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Katılımcı No";
            dataGridView1.Columns[2].HeaderText = "Atölye No";
            dataGridView1.Columns[3].HeaderText = "Kurs Tarihi";
            dataGridView1.Columns[4].HeaderText = "Devam Durumu";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[4].ReadOnly = true;
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

        private void BtnKaydet_Click(object sender, EventArgs e) //Kaydet Butonu İçin

        {
            if (CBoxKatilimci.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Katılımcı Seçiniz.");
                CBoxKatilimci.Focus();
            }
            else if (CBoxAtolye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Atölye Seçiniz.");
                CBoxAtolye.Focus();
            }
            else if (rBGeldi.Checked == false && rBGelmedi.Checked == false)
            {
                MessageBox.Show("Lütfen Devam Durumu Seçiniz.");
            }
            else
            {
                int DevamDurum;
                if (rBGeldi.Checked == true)
                {
                    DevamDurum = 1;
                }
                else
                {
                    DevamDurum = 0;
                    rBGelmedi.Checked = false;
                }
                string[] Parametreler = { "@KatilimciId", "@AtolyeId", "@KursTarihi", "@DevamDurumu" };
                string[] Degeler = { CBoxKatilimci.SelectedValue.ToString(), CBoxAtolye.SelectedValue.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), Convert.ToString(DevamDurum) };

                bool kontrol = Yardimci.CRUD("AtolyeDevamKaydet", Parametreler, Degeler);
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

        private void BtnGuncelle_Click(object sender, EventArgs e) //Güncelle Butonu İçin
        {
            int DevamDurum;
            if (rBGeldi.Checked == true)
            {
                DevamDurum = 1;
            }
            else
            {
                DevamDurum = 0;
                rBGelmedi.Checked = false;
            }
            string[] Parametreler = { "@KatilimciId", "@AtolyeId", "@KursTarihi", "@DevamDurumu", "@Id" };
            string[] Degerler = { CBoxKatilimci.SelectedValue.ToString(), CBoxAtolye.SelectedValue.ToString(), dateTimeTarih.Value.Date.ToString("yyyy-MM-dd"), Convert.ToString(DevamDurum), labelId.Text };
            bool kontrol = Yardimci.CRUD("AtolyeDevamGuncelle", Parametreler, Degerler);
            if (kontrol)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                bool kontrol = Yardimci.CRUD("AtolyeDevamSil", Parametreler, Degerler);

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
            CBoxKatilimci.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CBoxAtolye.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimeTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int DevamDurum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            if (DevamDurum == 1)
            {
                rBGeldi.Checked = true;
            }
            else
            {
                rBGelmedi.Checked = true;
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e) //Temizle Butonu İçin
        {
            CBoxKatilimci.SelectedIndex = -1;
            CBoxAtolye.SelectedIndex = -1;
            dateTimeTarih.Value = DateTime.Today;
            rBGeldi.Checked = false;
            rBGelmedi.Checked = false;
            labelId.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e) //Arama Butonu İçin
        {
            string Sorgu = "Select * from AtolyeDevam where KatilimciId like '%" + TxtAra.Text + "%'";
            DataTable Katilimci = Yardimci.VeriOku(Sorgu);
            dataGridView1.DataSource = Katilimci;
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if (TxtAra.Text == "Katılımcı No Ara")
            {
                TxtAra.Text = "";
                TxtAra.ForeColor = Color.Black;
            }
        }

        private void TxtAra_Leave(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {
                TxtAra.Text = "Katılımcı No Ara";
                TxtAra.ForeColor = Color.Silver;
            }
        }
    }
}
