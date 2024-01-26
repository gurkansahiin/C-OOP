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

    public partial class Login : Form
    {
        string baglanti = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            KullanTb.Focus();
        }

     
      

        private void GirisButton_Click(object sender, EventArgs e)
        {
            Giris login = new Giris();
            login.Login(KullanTb.Text, Sifreetb.Text, baglanti);

        }

        private void DuyurularButton_Click(object sender, EventArgs e)
        {
            Duyurular duyuru = new Duyurular();
            duyuru.Show();
            this.Hide();
        }

      
    }
}
