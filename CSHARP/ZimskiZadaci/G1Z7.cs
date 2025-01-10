using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z7
    {

        public static void Izvedi() 
        {

            Console.WriteLine("7.-BROJANJE SAMOGLASNIKA");
            Console.WriteLine("********************************");

            Console.Write("Unesi riječ ili niz slova: ");
            string r = Console.ReadLine();

            int brSamog = 0;
            string samoglasnici = "aeiouAEIOU";

            
            foreach (char znak in r) 
            {

                if (samoglasnici.Contains(znak)) 
                { 
                
                    brSamog++;
                
                }
            
            }
            Console.WriteLine("Broj samoglasnika je:{0}", brSamog);

        }

    }
}
