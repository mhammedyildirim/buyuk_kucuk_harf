using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyuk_kucuk_harf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir harf giriniz: ");
            var harf = Convert.ToChar((Console.ReadLine()));

            if (harf >= 65 && harf <= 90)
            {
                Console.WriteLine("Girilen harf büyüktür.");
            }
            else if (harf >= 97 && harf <= 122) {

                Console.WriteLine("Girilen harf küçüktür.");

            }
            Console.ReadKey();
        }
    }
}
