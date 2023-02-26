using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)  //methot   buyuk harfle yazılır  "Ekle()"  ()  norml parantez varsa metot calısıyordur
            // neyi eklemek istediğini metada söylemen lazım - parametre
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :"+ urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi" + urunAdi);
        }
    }
}
