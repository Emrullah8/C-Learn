using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte birinci = 5;

            byte ikinci = 25;

            byte ucuncu = 255;  //Byte 0-255 arasında değer alır

            byte maxdeger = byte.MaxValue;
            byte mindeger = byte.MinValue;
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.WriteLine(ucuncu);
            Console.WriteLine(birinci + ikinci + ucuncu);
            Console.ReadLine();

            **  Byte 0-255 arasında değer alır

            **  Short değişkeni -32768 ile +32767 arasında değerlerini depolayabilmektedir
                2 BYTE YER KAPLAR

            **  İnt veri tipi -2.147.483.648 ile 2.147.483.647 arasındaki sayı değerlerini depolar
                İNT 4 byte yer kaplar ram bellekte

            **  long veri tipi -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 arasında değer depolayabilir
                8 byte yer kaplar ram bellekte

            /*
            8 bit = 1 byte
            1024 byte = 1kb
            1024 kb = 1mb
            1024 mb = 1 gb
            1024 gb = 1 tb
            1024 tb = 1 pb
            */




        }
    }
}
