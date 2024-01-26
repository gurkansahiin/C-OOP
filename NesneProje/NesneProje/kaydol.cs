using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public class kaydol
    {

        private SqlConnection baglanti;

        public kaydol(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
        }

        public int HesaplaGunSayisi(DateTimePicker baslangicDateTimePicker, DateTimePicker bitisDateTimePicker)
        {
            // DateTimePicker'lardan tarihleri al
            DateTime baslangicTarihi = baslangicDateTimePicker.Value;
            DateTime bitisTarihi = bitisDateTimePicker.Value;

            // Tarihler arasındaki gün farkını hesapla
            //timespan  Genellikle zaman ölçümleri ve süre hesaplamaları için kullanılır.
            TimeSpan gunFarki = bitisTarihi.Date - baslangicTarihi.Date;
            int gunSayisi = (int)gunFarki.TotalDays;

            return gunSayisi;
        }

        public void KayitOl(string adSoyad, string telefon, string cinsiyet, string yas, string zamanlama, string odeme, DateTime baslangic, DateTime bitis)
        {
            try
            {
                if (adSoyad == "" || telefon == "" || odeme == "" || yas == "")
                {
                    MessageBox.Show("Eksik Bilgi");
                }
                else
                {
                    baglanti.Open();
                    string query = "INSERT INTO UyeTbl (UAdSoyad, Utelefon, Ucinsiyet, UYas, UZamanlama, UOdeme, UBaslangic, UBitis,UAciklama) VALUES (@AdSoyad, @Telefon, @Cinsiyet, @Yas, @Zamanlama, @Odeme, @Baslangic, @Bitis,@Aciklama)";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@AdSoyad", adSoyad);
                    komut.Parameters.AddWithValue("@Telefon", telefon);
                    komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                    komut.Parameters.AddWithValue("@Yas", yas);
                    komut.Parameters.AddWithValue("@Zamanlama", zamanlama);
                    komut.Parameters.AddWithValue("@Odeme", odeme);
                    komut.Parameters.AddWithValue("@Baslangic", baslangic);
                    komut.Parameters.AddWithValue("@Bitis", bitis);
                    komut.Parameters.AddWithValue("@Aciklama", "Ödeme Yapılmadı");
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla Eklendi");
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}

