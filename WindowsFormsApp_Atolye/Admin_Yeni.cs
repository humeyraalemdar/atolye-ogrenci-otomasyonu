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
    public partial class Admin_Yeni : Form
    {
        public Admin_Yeni()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e) //Yeni Kullanıcı Ekler
        {
            if (TxtKullaniciAdi.Text.Trim() != "") //Kullanıcı Adı Kontrolü Yapar
            {
                string Sorgu = "Select * from AdminGiris";
                DataTable Kullanici = Yardimci.VeriOku(Sorgu);

                bool kayitvaryok = false;

                for (int i = 0; i < Kullanici.Columns.Count; i++)
                {
                    if (Kullanici.Rows[0]["KullaniciAdi"].ToString() == TxtKullaniciAdi.Text.Trim())
                    {
                        kayitvaryok = true;
                        MessageBox.Show("Kullanıcı Adı Daha Önce Alınmış.");
                        TxtKullaniciAdi.Focus();
                        break;
                    }
                }
                if (kayitvaryok == false)
                {
                    if (TxtSifre.Text.Trim() == TxtSifreTekrar.Text.Trim())
                    {
                        if (TxtKullaniciAdi.Text.Trim() == "")
                        {
                            MessageBox.Show("Kullanıcı Adı Boş Geçilemez.");
                            TxtKullaniciAdi.Focus();
                        }
                        else if (TxtSifre.Text.Trim() == "")
                        {
                            MessageBox.Show("Şifre Alanı Boş Geçilemez");
                            TxtSifre.Focus();
                        }
                        string[] Parametreler = { "@KullaniciAdi", "@Sifre" };
                        string[] Degeler = { TxtKullaniciAdi.Text.Trim().ToString(), TxtSifre.Text.Trim().ToString() };

                        bool kontrol = Yardimci.CRUD("AdminGirisKaydet", Parametreler, Degeler);
                        if (kontrol)
                        {
                            MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Şifre Gizle Göster
        {
            if (checkBox1.Checked == true)
            {
                TxtSifre.UseSystemPasswordChar = false;
                TxtSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
                TxtSifreTekrar.UseSystemPasswordChar = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e) //Şifre Güncelleme İşlemi Yapar
        {
            if (TxtKullaniciAdi.Text != "")
            {
                string Sorgu = "Select * from AdminGiris";
                DataTable Kullanici = Yardimci.VeriOku(Sorgu);
                labelId.Text = Kullanici.Rows[0]["Id"].ToString();
                if (TxtKullaniciAdi.Text.Trim() == (string)Kullanici.Rows[0]["KullaniciAdi"])
                {
                    if (TxtSifre.Text.Trim() == TxtSifreTekrar.Text.Trim())
                    {
                        string[] Parametreler = { "@KullaniciAdi", "Sifre", "@Id" };
                        string[] Degerler = { TxtKullaniciAdi.Text.Trim().ToString(), TxtSifre.Text.Trim().ToString(), labelId.Text };
                        bool kontrol = Yardimci.CRUD("AdminGirisGuncelle", Parametreler, Degerler);
                        if (kontrol)
                        {
                            MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("'" + TxtKullaniciAdi.Text + "'" + " Adında Kullanıcı Bulunamadı. İşlem Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }
    }
}
