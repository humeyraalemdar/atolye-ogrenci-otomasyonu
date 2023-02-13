using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp_Atolye
{
    public partial class Admin_Giris : Form
    {
        public Admin_Giris()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign() //Admin_Giris Menusu Ilk Hali
        {
            PanelAtolyelerSubMenu.Visible= false;
            PanelKursSubMenu.Visible= false;
            PanelHesaplamaSubMenu.Visible= false;
        }

        private void SubMenuGoster(Panel subMenu)  // Sub Menu Gosterme Metodu
        {          
            if (subMenu.Visible == false)
            {
                CustomizeDesign();
                subMenu.Visible = true;

            }
            else 
            {
                subMenu.Visible = false;
            }
        }
        private void BtnAtolyeler_Click(object sender, EventArgs e) // Atolyeler Butonu ve Sub Menu
        {
            SubMenuGoster(PanelAtolyelerSubMenu);
            BtnChangeColor(BtnAtolyeler, 245, 183, 177);
        }
        private void BtnEgitmenler_Click(object sender, EventArgs e) // Egitmenler Butonu
        {
            CustomizeDesign();
            BtnChangeColor(BtnEgitmenler, 210, 180, 222);
            OpenChildForm(new Admin_EgitmenlerGiris());
            PanelUstMenu.BackColor = Color.FromArgb(244, 236, 247);
            PanelTxt.Text = "Eğitmenler";

        }
        private void BtnProgramlar_Click(object sender, EventArgs e) // Programlar Butonu
        {
            CustomizeDesign();
            BtnChangeColor(BtnProgramlar, 174, 214, 241);
            OpenChildForm(new Admin_ProgramGiris());
            PanelUstMenu.BackColor = Color.FromArgb(235, 245, 251);
            PanelTxt.Text = "Programlar";
        }
        private void BtnKursKatilim_Click(object sender, EventArgs e) // Kurs Katilim Butonu ve Sub Menu
        {
            SubMenuGoster(PanelKursSubMenu);
            BtnChangeColor(BtnKursKatilim, 163, 228, 215);
        }
        private void BtnSiparisler_Click(object sender, EventArgs e) // Siparisler Butonu
        {
            CustomizeDesign();
            BtnChangeColor(BtnSiparisler, 249, 231, 159);
            PanelUstMenu.BackColor = Color.FromArgb(254, 249, 231);
            PanelTxt.Text = "Siparişler";
            OpenChildForm(new Admin_Siparis());
        }
        private void BtnHesaplamalar_Click(object sender, EventArgs e) // Hesaplamalar Butonu ve Sub Menu
        {
            SubMenuGoster(PanelHesaplamaSubMenu);
            BtnChangeColor(BtnHesaplamalar, 245, 203, 167);
        }
        
        private void BtnCikis_Click(object sender, EventArgs e) //Cıkıs Butonu Kontrolu
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin misiniz?", "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }         
        }
        private void BtnChangeColor(object sender, int r, int g, int b) //Buton Renk Degistirme Metodu
        {

            foreach (Control panelButton in PanelMenu.Controls)
            {
                panelButton.BackColor= Color.Gainsboro;
                PanelAtolyelerSubMenu.BackColor = Color.WhiteSmoke;
                PanelKursSubMenu.BackColor = Color.WhiteSmoke;
                PanelHesaplamaSubMenu.BackColor = Color.WhiteSmoke;

            }
            Control click = (Control)sender;
            click.BackColor= Color.FromArgb(r, g, b);
        }

        private Form activeForm = null; // Child Form Metodu Olusturmak Icin

        private void OpenChildForm(Form childForm) // Child Form Metodu
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnAtolyeEkle_Click(object sender, EventArgs e) // Atolyeler Butonu
        {
            OpenChildForm(new Admin_AtolyeGiris());
            PanelUstMenu.BackColor = Color.FromArgb(253, 237, 236);
            PanelTxt.Text = "Atölyeler";
        }

        private void BtnDersPaket_Click(object sender, EventArgs e) // Ders Paketleri Butonu
        {
            OpenChildForm(new Admin_DersPaket());
            PanelUstMenu.BackColor = Color.FromArgb(253, 237, 236);
            PanelTxt.Text = "Ders Paketleri";
        }

        private void BtnKatilimciBilgi_Click(object sender, EventArgs e) // Katilimci Bilgileri Butonu
        {
            OpenChildForm(new Admin_Katilimci());
            PanelUstMenu.BackColor = Color.FromArgb(232, 248, 245);
            PanelTxt.Text = "Katılımcı Bilgileri";
        }

        private void BtnDevamDurumu_Click(object sender, EventArgs e) // Devam Durumu Butonu
        {
            OpenChildForm(new Admin_AtolyeDevam());
            PanelUstMenu.BackColor = Color.FromArgb(232, 248, 245);
            PanelTxt.Text = "Devam Durumu";
        }

        private void BtnTahsilat_Click(object sender, EventArgs e) // Tahsilat Butonu
        {
            OpenChildForm(new Admin_Tahsilat());
            PanelUstMenu.BackColor = Color.FromArgb(253, 242, 233);
            PanelTxt.Text = "Tahsilat";
        }

        private void BtnGiderler_Click(object sender, EventArgs e) // Giderler Butonu
        {
            OpenChildForm(new Admin_Giderler());
            PanelUstMenu.BackColor = Color.FromArgb(253, 242, 233);
            PanelTxt.Text = "Giderler";
        }
        private void Admin_Giris_Load(object sender, EventArgs e) 
        {
            AlinanKurs();
            SiparisSayi();
            Kazanc();
            Kurslar();
            Katilimcilar();
        }
        private void Katilimcilar() //Katılımcı Sayısı İçin
        {
            string Sorgu = "SELECT COUNT (*) FROM KatilimciGiris;";
            DataTable Katilimci = Yardimci.VeriOku(Sorgu);
            label5.Text = Katilimci.Rows[0][0].ToString();
        }
        private void Kurslar() //Kurs Sayısı İçin
        {
            string Sorgu = "SELECT COUNT(*) FROM AtolyeGiris;";
            DataTable Kurslar = Yardimci.VeriOku(Sorgu);
            label3.Text = Kurslar.Rows[0][0].ToString();
        }
        private void Kazanc() //Toplam Kazanç İçin
        {
            string Sorgu = "SELECT SUM(Tutar) FROM Tahsilat";
            DataTable Kazanc = Yardimci.VeriOku(Sorgu);
            label9.Text = string.Format("{0:C}", decimal.Parse(Kazanc.Rows[0][0].ToString()));
        }

        private void AlinanKurs() //Alınan Kursların Daire Grafiği
        {
            string Sorgu = "Select AtolyeId, Count(SiparisId) as SiparisSayisi from SiparisSatirlari Group By AtolyeId Order By SiparisSayisi DESC";
            DataTable Kurs = Yardimci.VeriOku(Sorgu);
            chart2.DataSource =Kurs;
            chart2.Series[0].XValueMember = "AtolyeId";
            chart2.Series[0].YValueMembers = "SiparisSayisi";
        }

        private void SiparisSayi() //Siparis Sayısı Tablosu
        {
            string Sorgu = "SELECT DATEPART(YEAR, Tarih) AS Yil, DATEPART(MONTH, Tarih) AS Ay, COUNT(*) AS SiparisSayisi FROM [Atolye].[dbo].[SiparisGiris] GROUP BY DATEPART(YEAR, Tarih),  DATEPART(MONTH, Tarih) ORDER BY Yil DESC, Ay DESC";
            DataTable Siparis = Yardimci.VeriOku(Sorgu);

            // Verileri hazır hale getirme
            List<DateTime> Tarihler = new List<DateTime>();
            List<int> SiparisSayilari = new List<int>();
            foreach (DataRow satir in Siparis.Rows)
            {
                int yil = Convert.ToInt32(satir["Yil"]);
                int ay = Convert.ToInt32(satir["Ay"]);
                int siparisSayisi = Convert.ToInt32(satir["SiparisSayisi"]);
                Tarihler.Add(new DateTime(yil, ay, 1));
                SiparisSayilari.Add(siparisSayisi);

                // Verileri grafikte görüntüleme
                chart1.Series.Clear();
                Series series = chart1.Series.Add("SiparisSayisi");
                //series.XValueType = ChartValueType.DateTime;
                series.Points.DataBindXY(Tarihler, SiparisSayilari);
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM-yyyy";
            }

        }
        private void BtnDBoard_Click(object sender, EventArgs e) //Ana Sayfa Butonu
        {
            this.Close();
            Admin_Giris form = new Admin_Giris();
            form.Show();
        }
    }
}
