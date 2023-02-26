using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 =  30   kod  yukarıdan aşağı işlyor  (main) 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] = 999      
            //int, decimal, float, double, bool = değer  tip      sayısal görüntü
            // array, class, interface = referans tip             referans alıyor
            //bellekte  stak ve heap diye 2 ala var   değer tip veri stack de yerleşir  
            //diziler array  heap de de yerleşir   sayılar 1 in referans adresi  sayılar 2 nn referans adresine eşitlenir
            //o referans numarasndaki değer değişirse referans adresinde ne varsa ona bakacağı için   yei verilere eşitlenir
            //pointer   meselesi   

        }
    }
}