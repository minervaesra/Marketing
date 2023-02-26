using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            //strig[] meyveler = new string[] {"elma", "karpuz" };

            Urun urun1 = new Urun();   // yeni bir  class tanımladık  Urun class ına bir  class tanımladık

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };  //dizi bu array   data veri kaynagından yani class a kayıtlı veri kaynagı sql  gibi

            //tip güvenli veri tipi vardır c#   ve  java da  o yüzden veri tipi yazılır  veri tipini  var   da yazsak olur

            foreach (Urun urun in urunler)  //burdaki "urun"herhangi bir ad olabilir  süslü parantezler ürün sayısı kadar döner
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...........");
            }

            Console.WriteLine("------------METOTLAR--------------");

            //İNSTANCE -  CLASS örneği oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);  //  sepermanager için ekle  metodunu cagırdık
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}


//metotlar tekrar tekrar kullanılabilirliği sağlar