using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public class TarihSeçimi
    {

        public int HesaplaGunFarki(DateTimePicker baslangicDatePicker, DateTimePicker bitisDatePicker)
        {
            DateTime baslangicTarih = baslangicDatePicker.Value.Date;
            DateTime bitisTarih = bitisDatePicker.Value.Date;

            TimeSpan gunFarki = bitisTarih - baslangicTarih;
            int gunSayisi = (int)gunFarki.TotalDays;

            return gunSayisi;
        }
    }
        
}
