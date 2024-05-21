using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsim_Soyisim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adınızı Girin");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınızı girin");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının ismi : " + isim);
            Console.WriteLine("Kullanıcının soyismi : " + soyisim);
            Console.ReadLine();

        }
    }
}
