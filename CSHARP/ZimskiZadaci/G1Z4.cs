using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z4
    {

        public static void Izvedi()
        {

            Console.WriteLine("********************************");
            Console.WriteLine("4.-PROSJEK OCJENA");

            Console.Write("Unesi broj ocjena: ");
            int brojElemenata = int.Parse(Console.ReadLine());

            int[] niz1 = new int[brojElemenata];

            Console.WriteLine("Unesite ocjene: ");
            for (int i = 0; i < brojElemenata; i++)
            {
                Console.Write("Unesite {0}. ocjenu: ", i + 1);
                niz1 [i] = int.Parse(Console.ReadLine());
            }

            int zbroj1 = 0;

            for (int i = 0; i < brojElemenata; i++)
            {

                zbroj1 += niz1[i];

            }


            double prosjek = zbroj1 / (float)brojElemenata;

            Console.WriteLine("Prosjek ocjena je:{0}", prosjek);

        }


    }
}
