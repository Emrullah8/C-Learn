using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOT_İF_ELSE_İF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen sırayla notunuzu girin");
            int birinci = Convert.ToInt32(Console.ReadLine());

            int ikinci = Convert.ToInt32(Console.ReadLine());

            int ücüncü = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci+ikinci+ücüncü)/3;

            if (sonuc>=80 && sonuc<=100)
            {
                Console.WriteLine("Notunuz: A+");
            }

            else if (sonuc>=60 && sonuc<80)
            {
                Console.WriteLine("Notunuz:B");
            }
            else if (sonuc>=40 && sonuc<60)
            {
                Console.WriteLine("Notunuz: C");
            }

            else
            {
                Console.WriteLine("Kaldınız");
            }
            Console.ReadLine();


        }
    }
}
