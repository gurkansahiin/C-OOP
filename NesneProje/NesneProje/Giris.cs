using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    //Trigger sınıfından kalıtım alıyor 
 
    public class Giris:trigger
    {
        public void Login(string username, string password,string baglanti)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (username == "admin" && password == "123456")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                PerformDatabaseAction(baglanti);
                // Bu formun gizlenmesi veya kapatılması, sizin uygulamanızın ihtiyaçlarına bağlı olarak ayarlanabilir.
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler hatalı");
            }
        }
    }
}
