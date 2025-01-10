using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z8
    {

        public static void Izvedi()
        {

            Console.WriteLine("8.-PRETVORBA TEMPERATURE");
            Console.WriteLine("********************************");

            Console.WriteLine("Odaberi mjernu jedinicu temperature:");
            Console.WriteLine("     1. Celzij u Fahrenheit");
            Console.WriteLine("     2. Fahrenheit u Celzij");
            int odabir = int.Parse(Console.ReadLine());

            Console.Write("Unesi temperaturu: ");
            double temperatura = double.Parse(Console.ReadLine());

            double rezultat;

            if (odabir == 1)
            {
                rezultat = temperatura * 9 / 5 + 32;
                Console.WriteLine("Temperatura u °F iznosi: {0:F2}", rezultat);

            }
            else if (odabir == 2)
            {

                rezultat = (temperatura - 32) * 5 / 9;
                Console.WriteLine("Temperatura u °C iznosi: {0:F2}", rezultat);

            }
            else
            {

                Console.WriteLine("Unos nije ispravan!");

            }








        }

    }
}
