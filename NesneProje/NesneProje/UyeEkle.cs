using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.UI.WinForms;

namespace NesneProje
{
    public partial class UyeEkle : Form
    {
        private SqlConnection baglanti;
        public UyeEkle()
        {
            InitializeComponent();
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");

        }
        TarihSeçimi tarih=new TarihSeçimi();

        DateTimePicker baslangicDatePicker = new DateTimePicker();
        DateTimePicker bitisDatePicker = new DateTimePicker();



        // SqlConnection baglanti=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



       
      
        private void UyeEkle_Load(object sender, EventArgs e)
        {
            OdemeTb.Enabled = false;
            dateTimePicker1.Value = PeriyotDt.Value.AddDays(30);

        }

    

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > PeriyotDt.Value && dateTimePicker1.Value >= PeriyotDt.Value.AddDays(30))
            {
                int gunFarki = tarih.HesaplaGunFarki(PeriyotDt, dateTimePicker1);

                OdemeTb.Text = (gunFarki * 20).ToString();
                OdemeTb.ReadOnly = true;
                OdemeTb.Enabled = false;
            }
            else
            {
                MessageBox.Show("Uygun bir tarih aralığı seçiniz");
                dateTimePicker1.Value = PeriyotDt.Value.AddDays(30); 
            }
            


        }

        private void PeriyotDt_ValueChanged(object sender, EventArgs e)
        {
            if (PeriyotDt.Value < DateTime.Now)
            {
                MessageBox.Show("Uygun bir tarih aralığı seçiniz");
                PeriyotDt.Value = DateTime.Now;

            }
            else
            {
                dateTimePicker1.Value = PeriyotDt.Value.AddDays(30);
            }
        }

        private void YasTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TelefonTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (TelefonTb.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TelefonTb_TextChange(object sender, EventArgs e)
        {
            if (TelefonTb.Text.Length > 11)
            {
                OdemeTb.Text = OdemeTb.Text.Substring(0, 11);
                OdemeTb.SelectionStart = OdemeTb.Text.Length;
                OdemeTb.SelectionLength = 0;
            }
        }

      

        private void ekleButton_Click(object sender, EventArgs e)
        {
            kaydol kaydol = new kaydol(baglanti);
            kaydol.KayitOl(AdSoaydTb.Text, TelefonTb.Text, cinsiyettcb.Text, YasTb.Text, ZamanlamaCb.Text, OdemeTb.Text, PeriyotDt.Value, dateTimePicker1.Value);

            textboxAyarlar txt = new textboxAyarlar();
            txt.TemizleTumControls(this.Controls);
            baglanti.Dispose();
        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            textboxAyarlar txt = new textboxAyarlar();
            txt.TemizleTumControls(this.Controls);
        }

        private void geriButton2_Click(object sender, EventArgs e)
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
    }
}
