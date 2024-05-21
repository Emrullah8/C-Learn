using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOndalıklı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FLOAT VERİ TİPİ
            //4 byte

            
            float ondalikli_sayi1 = 35.56f;

            float ondalikli_sayi2 = 12.5f;

            //DOUBLE VERİ TİPİ 
            // 8 BYTE YER KAPLAR 15 BASAMAKLI ONDALIKLI SAYILARI TUTABİLİR

            double ondalikli_sayi3 = 350.7;
            double ondalikli_sayi4 = -250.6;


            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);

            Console.WriteLine(ondalikli_sayi3);
            Console.WriteLine(ondalikli_sayi4);
            Console.ReadLine();
        }
    }
}
