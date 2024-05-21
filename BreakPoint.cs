using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakpoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Breakpoint direkt kodlama üzerinde çalıştırma demektir.
            // start yaptıktan sonra kodun başına gelip sol mousela kırmızı yapıp
            // ardından yukardaki step over (f10)a basıp değeri atayıp test edebilirsin
            int a = 5;
            int b = 6;
            int c = 7;

            int sonuc = a + b + c;

        }
    }
}
