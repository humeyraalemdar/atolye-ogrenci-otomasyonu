using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;


namespace WindowsFormsApp_Atolye
{
    public class Yardimci
    {
        public static SqlConnection Baglan()
        {
            SqlConnection conn = new SqlConnection();
            string Baglanti = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
            conn.ConnectionString = Baglanti;
            return conn;
        }
        public static DataTable VeriOku(string sorgu)
        {
            DataTable dt = new DataTable();     
            SqlConnection conn = Baglan();
            SqlCommand Komut = new SqlCommand(sorgu, conn);
            SqlDataAdapter adapt = new SqlDataAdapter(Komut);

            try
            {
                conn.Open();
                adapt.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        } 
        public static bool CRUD(string sorgu, string[] Parametreler, string[] Degerler)
        {

            bool sonuc = false;
            SqlConnection conn = Baglan();
            SqlCommand Komut = new SqlCommand();
            Komut.Connection= conn;
            Komut.CommandType = CommandType.StoredProcedure;
            Komut.CommandText = sorgu;

            for (int i = 0; i < Parametreler.Length; i++)
            {
                Komut.Parameters.AddWithValue(Parametreler[i].ToString(), Degerler[i].ToString());
            }
            try
            {
                conn.Open();
                Komut.ExecuteNonQuery();
                conn.Close();
                sonuc = true;
            }
            catch (Exception)
            {

                sonuc= false;
            }

            return sonuc;
        }
    }
}
