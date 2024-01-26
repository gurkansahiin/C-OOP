using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public interface IDigerİslemler
    {
         void FiltrelemeMetodu(SqlConnection baglanti, DataGridView dataGridView, string tabloAdi, string arananMetin);
        void FillName(SqlConnection baglanti, ComboBox AdSoyadCb);
        void DuyuruEkle(SqlConnection baglanti, DateTimePicker tarihPicker, TextBox konuTextBox, RichTextBox aciklamaRichTextBox);

    }
}
