using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Tipi_Dönüştürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ## İntegeri Byte Dönüştürme  ###

            /* int a = 256;
             byte b = (byte)a;

             Console.WriteLine(b);
             Console.WriteLine(b.GetType());     //system.byte yazar
             Console.ReadLine();         // ##Cevap 0 çıkar çünkü byte 0-255 arası alır 256-255=1 olsa da 0dan başlar tekrar 
            */

            // ###### String veri tipini inte dönüştüme #####

            /**/
            string sayi1 = "1";
             string sayi2 = "2";         // sayi1 + sayi2 string tipinde olduğundan 12 yazardı

             int a = int.Parse(sayi1);       // İntegere dönüştürme int.parse();
             int b = int.Parse(sayi2);
             Console.WriteLine(a + b);       // 3 yazar
             Console.ReadLine();

             // #Bunu da kullanabiliriz
/*
             int a = Convert.ToInt32(sayi1);
             int b = Convert.ToInt32(sayi2);


            /*
            // ###### İNT VERİ TİPİNİ STRİNG VERİ TİPİNE DÖNÜŞTÜRME ########
            
            int sayi1 = 5;
            int sayi2 = 10;

            string a = sayi1.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(a+b);         // 510 yazacak
            Console.ReadLine();
            */


            // ######## DOUBLE VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME ########
            /*
           double sayı = 5.51;
           int a = Convert.ToInt32(sayı);  //En yakın tam sayıya yuvarlar
           /* int a = int.Parse(sayı) da kullanılabilir 
           // sadece 5 değeri ataması için double sayı = 5.51;  Console.WriteLine((int)sayı); yazmak gerekir
           Console.WriteLine(a);
           Console.WriteLine(sayı.GetType()); 
           Console.ReadLine();
           */

            // ######### Kullanıcıdan 2 tane rakam olarak alınan string değerini inte çevirme ########
            /*
            Console.WriteLine("1.SAYIYI YAZIN");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("2.SAYIYI YAZIN");
            string sayi2 = Console.ReadLine();

            int sayi1Int = int.Parse(sayi1);
            int sayi2Int = int.Parse(sayi2);
            Console.WriteLine("İki sayının toplamı :" + (sayi1Int+sayi2Int));
            Console.ReadLine();


            
            /*  int.Parse();
             *  Convert.ToInt32();
             *  sayi1.ToString();
             *  (byte)a
             

            */
        }
    }
}
