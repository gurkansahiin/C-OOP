using Bunifu.UI.WinForms.Helpers.Transitions;
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
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        DateTime originalValue;
        DateTime bitis;
        DateTime baslangic;
        DateTime ikinciSutunDegeri;
        int odemee;
        object value;

        TarihSeçimi tarih = new TarihSeçimi();
        string tableName = "UyeTbl";
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");
        UyeGuncelleSil uyeGuncelleSil;

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeGuncelleSil = new UyeGuncelleSil(baglanti);
            
            uyeGuncelleSil.UyelerMetodu(baglanti, UyeDgv, tableName );
            OdemeTb.Enabled = false;
            PeriyotDt.Enabled = false;
            originalValue = dateTimePicker1.Value;
        }

        int key = 0;


        //Data griddeki verileri textboxlara aktarmak için
        private void UyeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır seçildiğinden emin olmak için
            {
                DataGridViewRow selectedRow = UyeDgv.Rows[e.RowIndex];

                key = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                AdSoyadTb.Text = selectedRow.Cells[1].Value.ToString();
                TelefonTb.Text = selectedRow.Cells[2].Value.ToString();
                CinsiyetCb.Text = selectedRow.Cells[3].Value.ToString();
                YasTb.Text = selectedRow.Cells[4].Value.ToString();
                OdemeTb.Text = selectedRow.Cells["UOdeme"].Value.ToString();
                 odemee = Convert.ToInt32(selectedRow.Cells[5].Value);

                ZamanlamaCb.Text = selectedRow.Cells[6].Value.ToString();

                if (selectedRow.Cells[7].Value is DateTime periyotDate)
                {
                    
                    PeriyotDt.Value = periyotDate;
                    PeriyotDt.Format = DateTimePickerFormat.Short;

                }

                if (selectedRow.Cells[8].Value is DateTime dateTimePickerDate)
                {

                    dateTimePicker1.Value = dateTimePickerDate;
                    dateTimePicker1.Format = DateTimePickerFormat.Short;
                }



        
                


            }
             baslangic = PeriyotDt.Value; // orginal değerinden originalDate'e atama yapılması
             bitis = dateTimePicker1.Value;

            OdemeTb.Text=odemee.ToString();
        }

        //çıkış
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Textboxları temizleme
        private void button2_Click(object sender, EventArgs e)
        {
            textboxAyarlar txt = new textboxAyarlar();
            txt.TemizleTumControls(this.Controls);
        }

         //Anasayfaya yönlendirme
        private void button4_Click(object sender, EventArgs e)
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

        // Sil için Yazılan
        private void button3_Click(object sender, EventArgs e)
        {
            uyeGuncelleSil.Sil(key, UyeDgv,tableName);
        }

        // Güncelleme İçin Yapılan
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime periyotTarih = PeriyotDt.Value;
            DateTime dateTimePickerTarih = dateTimePicker1.Value;
            uyeGuncelleSil.Guncelle(key, AdSoyadTb.Text, TelefonTb.Text, CinsiyetCb.Text, YasTb.Text, ZamanlamaCb.Text, OdemeTb.Text, UyeDgv, periyotTarih, dateTimePickerTarih);
        }

      

        private void PeriyotDt_ValueChanged(object sender, EventArgs e)
        {
           
                if (dateTimePicker1.Value > PeriyotDt.Value)
                {
                    int gunFarki = tarih.HesaplaGunFarki(PeriyotDt, dateTimePicker1);
                    dateTimePicker1.Value = PeriyotDt.Value.AddDays(30);
                    OdemeTb.Text = (gunFarki * 20).ToString();
                }
                else
                {
                    MessageBox.Show("Uygun bir tarih aralığı seçiniz");
                    DateTime dateTimePickerDate = (DateTime)UyeDgv.SelectedRows[0].Cells[8].Value;
                    dateTimePicker1.Text = dateTimePickerDate.ToString("dd.MM.yyyy");
                }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
                if (dateTimePicker1.Value > PeriyotDt.Value)
                {
                    if ((dateTimePicker1.Value - PeriyotDt.Value).TotalDays < 30)
                    {
                        MessageBox.Show("Minimum 30 günlük spor yapabilirsiniz..");
                        dateTimePicker1.Value = PeriyotDt.Value.AddDays(30);
                        int gunFarki = tarih.HesaplaGunFarki(PeriyotDt, dateTimePicker1);
                    }
                    else
                    {
                        int gunFarki = tarih.HesaplaGunFarki(PeriyotDt, dateTimePicker1);
                        OdemeTb.Text = (gunFarki * 20).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Uygun bir tarih aralığı seçiniz");
                    DateTime dateTimePickerDate = (DateTime)UyeDgv.SelectedRows[0].Cells[8].Value;
                    dateTimePicker1.Text = dateTimePickerDate.ToString("dd.MM.yyyy");
                }
            
        }

     

        private void dateTimePicker1_MouseEnter_1(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled) // DateTimePicker etkinse
            {
                if (dateTimePicker1.Value > PeriyotDt.Value)
                {
                    if ((dateTimePicker1.Value - PeriyotDt.Value).TotalDays < 30)
                    {
                        MessageBox.Show("Minimum 30 günlük spor yapabilirsiniz..");
                        dateTimePicker1.Value = PeriyotDt.Value.AddDays(30);
                        int gunFarki = tarih.HesaplaGunFarki(PeriyotDt, dateTimePicker1);
                    }
                    else
                    {
                        TimeSpan gunFarki = bitis - baslangic;
                        int eskiGunSayisi = (int)gunFarki.TotalDays;

                        int yeniGunSayisi = tarih.HesaplaGunFarki(PeriyotDt, dateTimePicker1);
                        int asilSonuc = (yeniGunSayisi - eskiGunSayisi) * 20;

                        int cevap = odemee + asilSonuc;
                        

                        OdemeTb.Text = cevap.ToString();
                    }
                }
            }
        }

    }





}
