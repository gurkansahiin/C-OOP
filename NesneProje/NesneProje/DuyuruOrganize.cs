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
using System.Windows.Input;

namespace NesneProje
{
    public partial class DuyuruOrganize : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");
        Uyeİslemleri islem = new Uyeİslemleri();
        string tableName = "Duyurular";
        UyeGuncelleSil uyeGuncelleSil;
        public DuyuruOrganize()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DuyuruOrganize_Load(object sender, EventArgs e)
        {
            uyeGuncelleSil = new UyeGuncelleSil(baglanti);
            islem.UyelerMetodu(baglanti,dataGridView1, tableName);
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

        //Uygulamadan Çıkış
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        
       


        //filtreleme
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            islem.FiltrelemeMetodu(baglanti, dataGridView1, tableName, AraTb.Text);
        }

        //yenileme
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            islem.UyelerMetodu(baglanti, dataGridView1, tableName);
        }

        //silme
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (key != 0)
            {
                uyeGuncelleSil.Sil(key, dataGridView1, tableName);
                // After deletion, reset the key to 0 or any default value
                key = 0;
            }
            else
            {
                MessageBox.Show("Lütfen silinecek öğeyi seçin."); // Show a message indicating no item selected
            }
        }


        //Resetleme
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            textboxAyarlar txt = new textboxAyarlar();
            txt.TemizleTumControls(this.Controls);
        }
        //Ekleme
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            islem.DuyuruEkle(baglanti, bunifuDatePicker1, konutb, richTextBox1);
            islem.UyelerMetodu(baglanti, dataGridView1, tableName);

        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır seçildiğinden emin olmak için
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                key = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            }
        }
    }
}
