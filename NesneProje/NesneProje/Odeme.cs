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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        string tableName = "OdemeTbl";
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");
        Uyeİslemleri uyeIslemleri = new Uyeİslemleri();





        //resetleme
        private void button2_Click(object sender, EventArgs e)
        {
            textboxAyarlar txt = new textboxAyarlar();
            txt.TemizleTumControls(this.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Odeme_Load(object sender, EventArgs e)
        {
            

            uyeIslemleri.FillName(baglanti,AdSoyadCb);
            uyeIslemleri.UyelerMetodu(baglanti,OdemeDgv, tableName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           string Odeme = OdemeTb.Text;
            uyeIslemleri.MakePayment(baglanti, AdSoyadCb,Odeme , PeriyotDt);
            

            uyeIslemleri.UyelerMetodu(baglanti, OdemeDgv, tableName);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Arama Kısmının Yapılacağı yer
        private void button5_Click(object sender, EventArgs e)
        {
            string metin = AraTb.Text;
            uyeIslemleri.FiltrelemeMetodu(baglanti,OdemeDgv,tableName,metin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tableName = "OdemeTbl";

            uyeIslemleri.UyelerMetodu(baglanti, OdemeDgv, tableName);
            AraTb.Text = "";
        }

        private void OdemeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
