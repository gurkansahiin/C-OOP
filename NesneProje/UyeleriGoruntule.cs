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

namespace NesneProje
{
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
            int kisiSayisi = GetKisiSayisi();
            label4.Text = kisiSayisi.ToString();
            

        }
        string tableName = "UyeTbl";
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");
        Uyeİslemleri uyeIslemleri = new Uyeİslemleri();

        private int GetKisiSayisi()
        {
            int kisiSayisi = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();

                    // SQL sorgusuyla UyeTbl tablosundaki kişi sayısını al
                    string query = "SELECT COUNT(*) FROM UyeTbl";
                    SqlCommand command = new SqlCommand(query, connection);

                    // ExecuteScalar kullanarak tek bir değer döndüren sorguyu çalıştır
                    kisiSayisi = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda burada uygun bir hata işleme mekanizması ekleyebilirsiniz
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

            return kisiSayisi;
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            string tableName = "UyeTbl";
            uyeIslemleri.UyelerMetodu(baglanti, UyeDgv, tableName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            uyeIslemleri.FiltrelemeMetodu(baglanti, UyeDgv,tableName, AraTb.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tableName = "UyeTbl";
            uyeIslemleri.UyelerMetodu(baglanti, UyeDgv,tableName);
            textboxAyarlar txt = new textboxAyarlar();
            txt.TemizleTumControls(this.Controls);
        }

        //Grafik ekranına yönlendirir
        private void button4_Click(object sender, EventArgs e)
        {
            GrafikEkrani graf = new GrafikEkrani();
            graf.Show();
            this.Hide();
        }
    }
}
