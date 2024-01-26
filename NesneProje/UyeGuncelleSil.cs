using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public class UyeGuncelleSil : Uyeİslemleri
    {
        //Uyeİslemleri sınıfından KALITIM aldım

        SqlConnection baglanti;

        public UyeGuncelleSil(SqlConnection conn)
        {
            baglanti = conn;
        }

        public void Sil(int key, DataGridView dataGridView, string tableName)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Öğeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = $"delete from {tableName} where Uid = {key}";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Silindi");

                    baglanti.Close();
                 
                    UyelerMetodu( baglanti,dataGridView, tableName); // UyelerMetodu, verilerin yeniden yüklenmesi için çağrıldı
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void Guncelle(int key, string adSoyad, string telefon, string cinsiyet, string yas, string zamanlama, string odeme, DataGridView dataGridView,DateTime baslangic,DateTime bitis)
        {
            if (key == 0 || adSoyad == "" || telefon == "" || odeme == "" || yas == "" || zamanlama == "" || cinsiyet == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();

                    string query = "UPDATE UyeTbl SET UAdSoyad=@AdSoyad, Utelefon=@Telefon, Ucinsiyet=@Cinsiyet, UYas=@Yas, UZamanlama=@Zamanlama,UBaslangic=@Baslangic,UBitis=@Bitis, UOdeme=@Odeme WHERE Uid=@Uid";
                    SqlCommand komut = new SqlCommand(query, baglanti);

                    komut.Parameters.AddWithValue("@AdSoyad", adSoyad);
                    komut.Parameters.AddWithValue("@Telefon", telefon);
                    komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                    komut.Parameters.AddWithValue("@Yas", yas);
                    komut.Parameters.AddWithValue("@Zamanlama", zamanlama);
                    komut.Parameters.AddWithValue("@Baslangic", baslangic);
                    komut.Parameters.AddWithValue("@Bitis", bitis);
                    komut.Parameters.AddWithValue("@Odeme", odeme);
                    komut.Parameters.AddWithValue("@Uid", key);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Güncellendi");
                    baglanti.Close();
                    string tableName = "UyeTbl";
                    UyelerMetodu(baglanti, dataGridView, tableName); // UyelerMetodu, verilerin yeniden yüklenmesi için çağrıldı
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
