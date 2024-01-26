using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    public class SporProgrami
    {

        private string Cinsiyet { get; set; }
        private string Bolge { get; set; }
        private string Sure { get; set; }
        private string Kilo { get; set; }

        public SporProgrami(string cinsiyet, string bolge, string sure, string kilo)
        {
            Cinsiyet = cinsiyet;
            Bolge = bolge;
            Sure = sure;
            Kilo = kilo;
        }

        public List<string> ProgramOlustur()
        {
            List<string> program = new List<string>();
            program.Add("Sporcu Programı:");

            program.Add($"Cinsiyet: {Cinsiyet}");
            program.Add($"Çalışılacak Bölge: {Bolge}");
            program.Add($"Gelişim Süresi: {Sure}");
            program.Add($"Kilo Aralığı: {Kilo}");


            program.AddRange(SporProgramiOlustur());

            return program;
        }

        private List<string> SporProgramiOlustur()
        {
            List<string> program = new List<string>();

            switch (Cinsiyet)
            {
                case "Bay":
                    program.AddRange(SporProgramiBay());
                    break;
                case "Bayan":
                    program.AddRange(SporProgramiBayan());
                    break;
                default:
                    program.Add("Geçersiz cinsiyet seçimi!");
                    break;
            }

            return program;
        }


        private List<string> SporProgramiBay()
        {
            List<string> program = new List<string>();

            switch (Bolge)
            {
                case "Bacak":
                    program.Add("Bay için Bacak Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika germe");
                    program.Add("- Squat: 4 set x 12 tekrar");
                    program.Add("- Deadlift: 3 set x 10 tekrar");
                    program.Add("- Leg press: 3 set x 15 tekrar");
                    break;
                case "Karın":
                    program.Add("Bay için Karın Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika karın germe");
                    program.Add("- Crunches: 4 set x 20 tekrar");
                    program.Add("- Leg raises: 3 set x 15 tekrar");
                    program.Add("- Plank: 3 set x 30 saniye");
                    break;
                case "Göğüs":
                    program.Add("Bay için Göğüs Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika göğüs germe");
                    program.Add("- Bench press: 4 set x 10 tekrar");
                    program.Add("- Dumbbell flys: 3 set x 12 tekrar");
                    program.Add("- Push-ups: 3 set x 15 tekrar");
                    break;
                case "Sırt":
                    program.Add("Bay için Sırt Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika sırt germe");
                    program.Add("- Pull-ups: 4 set x 8 tekrar");
                    program.Add("- Barbell rows: 3 set x 10 tekrar");
                    program.Add("- Lat pulldowns: 3 set x 12 tekrar");
                    break;
                case "Biceps":
                    program.Add("Bay için Biceps Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika biceps germe");
                    program.Add("- Barbell curls: 4 set x 10 tekrar");
                    program.Add("- Dumbbell hammer curls: 3 set x 12 tekrar");
                    program.Add("- Cable curls: 3 set x 15 tekrar");
                    break;
                case "Triceps":
                    program.Add("Bay için Triceps Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika triceps germe");
                    program.Add("- Close-grip bench press: 4 set x 10 tekrar");
                    program.Add("- Triceps dips: 3 set x 12 tekrar");
                    program.Add("- Triceps pushdowns: 3 set x 15 tekrar");
                    break;
                default:
                    program.Add("Geçersiz bölge seçimi!");
                    break;
            }

            switch (Sure)
            {
                case "8-10":
                    program.Add("- Dinlenme: 1 gün ara");
                    program.Add("- Programı 8-10 gün boyunca tekrar et");
                    break;
                case "10-15":
                    program.Add("- Dinlenme: 1 gün ara");
                    program.Add("- Programı 10-15 gün boyunca tekrar et");
                    break;
                case "15++":
                    program.Add("- Dinlenme: 2 gün ara");
                    program.Add("- Programı 15+ gün boyunca tekrar et");
                    break;
                default:
                    program.Add("Geçersiz süre seçimi!");
                    break;
            }
            program.AddRange(BeslenmeMenusuOlusturBay());

            return program;
        }
        private List<string> BeslenmeMenusuOlusturBay()
        {
            List<string> beslenmeMenusu = new List<string>();

            switch (Kilo)
            {
                case "50-60":
                    beslenmeMenusu.Add("Besin Takviyesi: 50-60 kilo için günlük 2 ölçek protein tozu alın.");
                    beslenmeMenusu.Add("Öğünler: Günde 5 öğün, her öğünde protein ağırlıklı beslenin.");
                    beslenmeMenusu.Add("Örnek Öğün: Izgara tavuk göğsü, buğday pilavı ve sebze.");
                    break;
                case "61-70":
                    beslenmeMenusu.Add("Besin Takviyesi: 60-70 kilo için günlük 1-2 ölçek protein tozu alın.");
                    beslenmeMenusu.Add("Öğünler: Günde 4-5 öğün, her öğünde protein ağırlıklı beslenin.");
                    beslenmeMenusu.Add("Örnek Öğün: Somon balığı, kahverengi pirinç ve salata.");
                    break;
                case "71-80":
                    beslenmeMenusu.Add("Besin Takviyesi: 70-80 kilo için günlük 1 ölçek protein tozu alın.");
                    beslenmeMenusu.Add("Öğünler: Günde 4 öğün, her öğünde dengeli bir karbonhidrat ve protein alın.");
                    beslenmeMenusu.Add("Örnek Öğün: Izgara biftek, patates ve sebze.");
                    break;
                case "81-90":
                    beslenmeMenusu.Add("Besin Takviyesi: 80-90 kilo için günlük 1 ölçek protein tozu alın, gerekirse BCAA takviyesi alın.");
                    beslenmeMenusu.Add("Öğünler: Günde 4 öğün, her öğünde protein ve karbonhidrat dengesi oluşturun.");
                    beslenmeMenusu.Add("Örnek Öğün: Kırmızı et, bulgur pilavı ve sebze.");
                    break;
                case "90++":
                    beslenmeMenusu.Add("Besin Takviyesi: 90+ kilo için günlük 1 ölçek protein tozu alın, BCAA ve kreatin takviyesi alın.");
                    beslenmeMenusu.Add("Öğünler: Günde 4 öğün, her öğünde kompleks karbonhidratlar ve yüksek protein içeren besinler tüketin.");
                    beslenmeMenusu.Add("Örnek Öğün: Ton balığı, kinoa ve sebze.");
                    break;
                default:
                    beslenmeMenusu.Add("Geçersiz kilo aralığı seçimi!");
                    break;
            }

            return beslenmeMenusu;
        }
        private List<string> BeslenmeMenusuKadın()
        {
            List<string> beslenmeMenusu = new List<string>();

            switch (Kilo)
            {
                case "50-60":
                    beslenmeMenusu.Add("Öğünler: Günde 3 ana öğün, her öğünde sebze ağırlıklı beslenin.");
                    beslenmeMenusu.Add("Örnek Öğün: Karışık yeşil salata (marul, roka, ıspanak) ve zeytinyağı ile soslanmış.");
                    break;
                case "61-70":
                    beslenmeMenusu.Add("Öğünler: Günde 3 ana öğün, sebzelerle birlikte az miktarda protein alın.");
                    beslenmeMenusu.Add("Örnek Öğün: Fırında sebze yemeği (patlıcan, kabak, biber) ve bir avuç fındık içi.");
                    break;
                case "71-80":
                    beslenmeMenusu.Add("Öğünler: Günde 2 ana öğün, her öğünde dengeli bir karbonhidrat ve sebze alın.");
                    beslenmeMenusu.Add("Örnek Öğün: Kepekli makarna ve ızgara sebzeler.");
                    break;
                case "81-90":
                    beslenmeMenusu.Add("Öğünler: Günde 2 ana öğün, her öğünde sebzelerle birlikte sağlıklı yağlar tüketin.");
                    beslenmeMenusu.Add("Örnek Öğün: Fırında balık (somon, levrek) ve zeytinyağlı sebzeler.");
                    break;
                case "90++":
                    beslenmeMenusu.Add("Öğünler: Günde 2 ana öğün, her öğünde kompleks karbonhidratlar ve sebzelerle birlikte az yağlı proteinler tüketin.");
                    beslenmeMenusu.Add("Örnek Öğün: Tavuk göğsü ızgara ve quinoa salatası.");
                    break;
                default:
                    beslenmeMenusu.Add("Geçersiz kilo aralığı seçimi!");
                    break;
            }


            return beslenmeMenusu;
        }


        private List<string> SporProgramiBayan()
        {
            List<string> program = new List<string>();

            switch (Bolge)
            {
                case "Bacak":
                    program.Add("Bayan için Bacak Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika germe");
                    program.Add("- Lunges: 4 set x 12 tekrar");
                    program.Add("- Leg curls: 3 set x 10 tekrar");
                    program.Add("- Glute bridges: 3 set x 15 tekrar");
                    break;
                case "Karın":
                    program.Add("Bayan için Karın Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika karın germe");
                    program.Add("- Bicycle crunches: 4 set x 20 tekrar");
                    program.Add("- Plank twists: 3 set x 15 tekrar");
                    program.Add("- Side plank: 3 set x 30 saniye");
                    break;
                case "Göğüs":
                    program.Add("Bayan için Göğüs Programı:");
                    program.Add("- Isınma: 10 dakika koşu, 5 dakika göğüs germe");
                    program.Add("- Chest press: 4 set x 10 tekrar");
                    program.Add("- Pec flys: 3 set x 12 tekrar");
                    program.Add("- Dumbbell pullover: 3 set x 15 tekrar");
                    break;
                case "Sırt":
                    program.Add("Bayan için Sırt Programı:");
                    program.Add("- Isınma: 10 dakika yürüyüş, 5 dakika sırt germe");
                    program.Add("- Dumbbell rows: 3 set x 10 tekrar (her kol)");
                    program.Add("- Lat pulldowns: 3 set x 12 tekrar");
                    program.Add("- Seated cable rows: 3 set x 12 tekrar");
                    break;

                case "Biceps":
                    program.Add("Bayan için Biceps Programı:");
                    program.Add("- Isınma: 10 dakika yürüyüş, 5 dakika biceps germe");
                    program.Add("- Hammer curls: 3 set x 12 tekrar");
                    program.Add("- Dumbbell curls: 3 set x 12 tekrar");
                    program.Add("- EZ bar curls: 3 set x 12 tekrar");
                    break;
                case "Triceps":
                    program.Add("Bayan için Triceps Programı:");
                    program.Add("- Isınma: 10 dakika yürüyüş, 5 dakika triceps germe");
                    program.Add("- Triceps kickbacks: 3 set x 12 tekrar");
                    program.Add("- Triceps dips: 3 set x 10-12 tekrar");
                    program.Add("- Overhead dumbbell extension: 3 set x 12 tekrar");
                    break;
                default:
                    program.Add("Geçersiz bölge seçimi!");
                    break;
            }

            switch (Sure)
            {
                case "8-10":
                    program.Add("- Dinlenme: 1 gün ara");
                    program.Add("- Programı 8-10 gün boyunca tekrar et");
                    break;
                case "10-15":
                    program.Add("- Dinlenme: 1 gün ara");
                    program.Add("- Programı 10-15 gün boyunca tekrar et");
                    break;
                case "15++":
                    program.Add("- Dinlenme: 2 gün ara");
                    program.Add("- Programı 15+ gün boyunca tekrar et");
                    break;
                default:
                    program.Add("Geçersiz süre seçimi!");
                    break;
            }
            program.AddRange(BeslenmeMenusuKadın());

            return program;
        }


    }
}
