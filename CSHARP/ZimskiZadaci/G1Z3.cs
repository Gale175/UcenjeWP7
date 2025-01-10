using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z3
    {

        public static void Izvedi()
        {

            
            Console.WriteLine("3.-NIZOVI");
            Console.WriteLine("********************************");


            Console.Write("Unesite broj elemenata niza: ");
            int elementi = int.Parse(Console.ReadLine());

            int[] niz = new int[elementi];

            Console.WriteLine("Unesite elemente niza:");
            for (int i = 0; i < elementi; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                niz[i] = int.Parse(Console.ReadLine());
            }

            int zbroj = 0;
            for (int i = 0; i < elementi; i++) 
            { 
                zbroj += niz[i];
            }

            Console.WriteLine($"Zbroj elemenata niza je: {zbroj}");






        }

    }
}
