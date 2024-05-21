using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Short değişkeni -32768 ile +32767 arasında değerlerini depolayabilmektedir

            short birinciDegisken = -50;

            short ikinciDegisken = -32768;

            short ucuncuDegisken = 32767;

            short maxdeger = short.MaxValue;
            short mindeger = short.MinValue;

            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();
        }
    }
}
