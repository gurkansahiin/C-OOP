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
    public class Uyeİslemleri
    {

        //Üyeleri Görüntüleme
        public void UyelerMetodu(SqlConnection baglanti, DataGridView dataGridView, string tabloAdi)
        {
            baglanti.Open();
            string query = $"SELECT * FROM {tabloAdi}"; // Tablo adını sorguya ekliyoruz
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0]; // DataGridView'e veri ataması yapıldı
            baglanti.Close();
        }



        //Filtreleme methodu

        public void FiltrelemeMetodu(SqlConnection baglanti, DataGridView dataGridView, string tabloAdi, string arananMetin)
        {
            try
            {
                baglanti.Open();
                string columnName = (tabloAdi == "UyeTbl") ? "UAdsoyad" : "konu";
                string query = $"SELECT * FROM {tabloAdi} WHERE {columnName} = @arananMetin";

                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@arananMetin", arananMetin);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView.DataSource = ds.Tables[0]; // DataGridView'e filtrelenmiş veri ataması yapıldı
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda yapılacak işlemler
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close(); // Bağlantı kapatılır
                }
            }
        }



       

        public void FillName(SqlConnection baglanti, ComboBox AdSoyadCb)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UAdSoyad from UyeTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UAdSoyad", typeof(string));
            dt.Load(rdr);
            AdSoyadCb.ValueMember = "UAdSoyad";
            AdSoyadCb.DataSource = dt;
            baglanti.Close();
        }

        // Ödeme yapma metod
        public void MakePayment(SqlConnection baglanti, ComboBox AdSoyadCb, string OdemeTb, DateTimePicker PeriyotDt)
        {
            if (AdSoyadCb.Text == "" || OdemeTb == "")
            {
                MessageBox.Show("Eksik Bilgi veya hatalı bilgi ");
            }
            else
            {
                string periyot = PeriyotDt.Value.Month.ToString() + PeriyotDt.Value.Year.ToString();
                baglanti.Open();

                // UyeTbl tablosundan ilgili kullanıcının ödeme bilgilerini al
                SqlDataAdapter uyeDataAdapter = new SqlDataAdapter("SELECT UOdeme, UAciklama FROM UyeTbl WHERE UAdSoyad = '" + AdSoyadCb.SelectedValue.ToString() + "'", baglanti);
                DataTable uyeDataTable = new DataTable();
                uyeDataAdapter.Fill(uyeDataTable);

                if (uyeDataTable.Rows.Count > 0)
                {
                    decimal odenenMiktar = Convert.ToDecimal(OdemeTb);
                    decimal mevcutBorc = Convert.ToDecimal(uyeDataTable.Rows[0]["UOdeme"]);

                    // Ödeme yapılabilir durumu kontrol etme ve ödeme işlemlerini gerçekleştirme
                    if (mevcutBorc > 0 && odenenMiktar <= mevcutBorc)
                    {
                        decimal kalanBorc = mevcutBorc - odenenMiktar;
                        string updateQuery = "";

                        if (kalanBorc == 0)
                        {
                            updateQuery = "UPDATE UyeTbl SET UOdeme = 0, UAciklama = 'Ödeme Yapıldı' WHERE UAdSoyad = '" + AdSoyadCb.SelectedValue.ToString() + "'";
                        }
                        else
                        {
                            updateQuery = "UPDATE UyeTbl SET UOdeme = " + kalanBorc.ToString() + ", UAciklama = 'Ödenen Miktar: " + OdemeTb + " - Ödemesi Devam Ediyor' WHERE UAdSoyad = '" + AdSoyadCb.SelectedValue.ToString() + "'";
                        }

                        SqlCommand updateKomut = new SqlCommand(updateQuery, baglanti);
                        updateKomut.ExecuteNonQuery();
                        string query = "insert into OdemeTbl values('" + periyot + "','" + AdSoyadCb.SelectedValue.ToString() + "','" + OdemeTb + "')";
                        SqlCommand komut = new SqlCommand(query, baglanti);
                        komut.ExecuteNonQuery();
                        

                        MessageBox.Show("Ödeme Başarıyla Yapıldı");
                    }
                    else
                    {
                        MessageBox.Show("Ödeme yapmak için geçersiz miktar veya borç yok.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }

                baglanti.Close();
            }
        }

        //Duyuru Ekleme

        public void DuyuruEkle(SqlConnection baglanti, DateTimePicker tarihPicker, TextBox konuTextBox, RichTextBox aciklamaRichTextBox)
        {
            try
            {
                baglanti.Open();

                
                string query = "INSERT INTO Duyurular (tarih, konu, aciklama) VALUES (@tarih, @konu, @aciklama)";

               
                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
             
                    cmd.Parameters.AddWithValue("@tarih", tarihPicker.Value);
                    cmd.Parameters.AddWithValue("@konu", konuTextBox.Text);
                    cmd.Parameters.AddWithValue("@aciklama", aciklamaRichTextBox.Text);

            
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Duyuru başarıyla eklendi.");
                       
                    }
                    else
                    {
                        MessageBox.Show("Duyuru eklenirken bir hata oluştu.");
                      
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close(); 
                }
            }
        }


    }
}
