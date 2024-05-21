using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İnt veri tipi -2.147.483.648 ile 2.147.483.647 arasındaki sayı değerlerini depolar
            // 4 byte yer kaplar ram bellekte

            /*
            8 bit = 1 byte
            1024 byte = 1kb
            1024 kb = 1mb
            1024 mb = 1 gb
            1024 gb = 1 tb
            1024 tb = 1 pb
            */

            int birinciDegisken = 1500000000;
            int ikinciDegisken = -50000;

            int maxdeger = int.MaxValue;
            int mindeger = int.MinValue;
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();-0,


            int a = 5;
            int b = 6;
            int c = 7;
            int sonuc = a + b + c;
            Console.WriteLine(sonuc);

            
        }
    }
}
