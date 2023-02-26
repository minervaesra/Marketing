namespace Marketing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            //int ogrenciSayisi; 32000;
            double faizOrani =1.45;
            bool sistemeGirisYapmismi = true;
            double dolardUN = 7.55;
            double DOLARbUGUN = 7.55;

            if (dolardUN>DOLARbUGUN)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolardUN < DOLARbUGUN)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}