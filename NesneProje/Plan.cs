using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NesneProje
{
    public partial class Plan : Form
    {


        public Plan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void geriBtn_Click(object sender, EventArgs e)
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

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textboxAyarlar ayarlar = new textboxAyarlar();
            ayarlar.TemizleTumControls(this.Controls);
        }

        //private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    Graphics graphic = e.Graphics;
        //    Font font = new Font("Courier New", 12);

        //    float fontHeight = font.GetHeight();
        //    int startX = 10;
        //    int startY = 10;

        //    foreach (var item in planlamaLb.Items)
        //    {
        //        graphic.DrawString(item.ToString(), font, Brushes.Black, startX, startY);
        //        startY += (int)fontHeight + 5;
        //    }
        //}
        private void olusturBtn_Click(object sender, EventArgs e)
        {
            string cinsiyet = cinsiyettcb.SelectedItem.ToString();
            string bolge = BölgeCb.SelectedItem.ToString();
            string sure = periyotCb.SelectedItem.ToString();
            string kilo = kilocb.SelectedItem.ToString();


            SporProgrami sporProgrami = new SporProgrami(cinsiyet, bolge, sure, kilo);
            List<string> program = sporProgrami.ProgramOlustur();

            planlamaLb.Items.Clear();
            foreach (var item in program)
            {
                planlamaLb.Items.Add(item);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap objMap = new Bitmap(this.planlamaLb.Width, this.planlamaLb.Height);
            planlamaLb.DrawToBitmap(objMap, new Rectangle(0, 0, this.planlamaLb.Width, this.planlamaLb.Height));
            e.Graphics.DrawImage(objMap, 100, 150);
            e.Graphics.DrawString("Spor Programı", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }
    }
}
