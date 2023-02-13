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
    public partial class AdminGirisSayfasi : Form
    {
        public AdminGirisSayfasi()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            string Sorgu = "Select  KullaniciAdi Sifre from AdminGiris where KullaniciAdi = '" + TxtKullaniciAdi.Text.Trim() + "' and Sifre = '" + TxtSifre.Text.Trim() + "'";
            DataTable Dt_Kullanici = Yardimci.VeriOku(Sorgu);

            if (Dt_Kullanici.Rows.Count > 0)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin_Giris HosGeldin = new Admin_Giris();
                HosGeldin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve/veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Şifre Gizle Göster
        {
            if (checkBox1.Checked == true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }        
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Kullanıcı İşlemlerini Açar
        {
            Admin_Yeni YeniKayit = new Admin_Yeni();
            YeniKayit.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Kullanıcı İşlemlerini Açar
        {
            Admin_Yeni YeniKayit = new Admin_Yeni();
            YeniKayit.Show();
        }

    }
}
