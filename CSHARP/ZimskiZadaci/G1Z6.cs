using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z6
    {

        public static void Izvedi() 
        {

            Console.WriteLine("6.-PREOKRET STRING");
            Console.WriteLine("********************************");

            Console.Write("Unesi riječ ili niz slova: ");
            string rijec = Console.ReadLine();

            int br = rijec.Length, c=1;

            Console.Write("Napisano unazad: ");
            for (int i = 0; i < br; i++) 
            {

                Console.Write(rijec[rijec.Length - c]);

                int temp = c;
                c = temp + 1;

            }
            


        }
    }
}
