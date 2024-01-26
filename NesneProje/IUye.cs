using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public  interface IUye
    {
       void UyelerMetodu(SqlConnection baglanti, DataGridView dataGridView, string tabloAdi);
       void MakePayment(SqlConnection baglanti, ComboBox AdSoyadCb, string OdemeTb, DateTimePicker PeriyotDt);
    }
}
