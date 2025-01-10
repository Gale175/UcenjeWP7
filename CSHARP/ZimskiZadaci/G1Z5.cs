using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z5
    {

        public static void Izvedi()
        {


            
            Console.WriteLine("5.-FIBONACCIJEV NIZ");
            Console.WriteLine("********************************");


            Console.Write("Unesi broj elemenata niza: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.Write("Fibonnacijev niz: ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(a + " ");    

                int priv = a;
                a = b;
                b = priv + b;

            }

            

        }

    }
}
