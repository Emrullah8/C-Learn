using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;

            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçin");
            Console.WriteLine(" 1 Bakiye Görüntüleme \n 2 Para Cekme \n 3 Para Yatırma \n q Çıkış");
            string secim = Console.ReadLine();

            if (secim =="1")
            {
                Console.WriteLine("Bakiyeniz :"+ bakiye);
            }
            else if (secim =="2")
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Girin:");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                
                if (cekilecek_tutar > bakiye)
                {
                    Console.WriteLine("Bakiye Yetersiz");
                }
                else
                {
                    Console.WriteLine(" Para Çekilmiştir \n Kalan Tutar :"+ (bakiye-cekilecek_tutar));
                }

            }
            else if (secim =="3")
            {
                Console.WriteLine("Eklemek İstediğiniz Tutarı Girin:");
                int eklenecek_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Para Eklenmiştir \n Bakiyeniz :"+ (eklenecek_tutar + bakiye));
            }

            else if (secim =="q")
            {
                Console.WriteLine("Atmden Çıkış Yapılıyor..");
                Console.WriteLine(" Çıkış Yapıldı \n İyi Günler.");
            }
            else
            {
                Console.WriteLine("Yanlış tuşa bastınız.");

            }
            Console.ReadLine();





        }
    }
}
