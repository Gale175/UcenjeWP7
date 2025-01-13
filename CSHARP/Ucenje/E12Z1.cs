using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z1
    {

        public static void Izvedi()
        {

            //Console.WriteLine("Dobro");

            int suma = 0;
            for (int i = 0; i < 100; i++)
            {

                suma += i;

            }
            Console.WriteLine(suma);

            Console.WriteLine("********************************************");

           // brojac = 0;
            //for (int i = 0; i <= 100; brojac += i; i++);
            //Console.WriteLine(brojac);




            //
            suma = 0;
            int b = 0;

            while (b < 100) 
            {

                suma += b++;
            
            }

            Console.WriteLine(suma);
            
            
            
            //
            Console.WriteLine("********************************************");

            suma = 0; b = 0;

            do
            {


                suma += ++b;

            } while (b < 100);

            Console.WriteLine(suma);


            //
            Console.WriteLine("********************************************");
            int[] niz = new int[100];

            for (int i = 0; i < 100; i++) 
            { 
            
                niz[i] = i+1 ;
            
            
            }


            Console.WriteLine(string.Join(",", niz));  // dodaje zareze u nizu, možemo staviti i samo razmak

            suma = 0;

            foreach (int broj in niz) 
            {

                suma += broj;
            
            
            }

            Console.WriteLine(suma);














        }



    }
}
