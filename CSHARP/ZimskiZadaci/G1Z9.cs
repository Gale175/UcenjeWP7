using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z9
    {

        public static void Izvedi() 
        {

            Console.WriteLine("9.-SORTIRANJE NIZA");
            Console.WriteLine("********************************");

            Console.Write("Unesi broj za veličinu niza: ");
            int duljina = int.Parse(Console.ReadLine());

            int[] nizBr = new int[duljina];

            Console.WriteLine("Unesi vrijednosti u niz:");
            for (int i = 0; i < duljina; i++) 
            {

                nizBr[i] = int.Parse(Console.ReadLine()) ; 
            
            }

            Array.Sort(nizBr);

            Console.Write("Sortirani niz: ");
            foreach (int broj in nizBr) 
            { 
            
                Console.Write(broj + " ");
            
            }

        }

    }
}
