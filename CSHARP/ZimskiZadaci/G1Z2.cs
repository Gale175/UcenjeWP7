using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z2
    {
        public static void Izvedi() 
        
        {

            Console.WriteLine("********************************");
            Console.WriteLine("2.-VRSTA BROJA");

            double c;
            Console.Write(" Unesi broj: ");
            c = Double.Parse(Console.ReadLine());

            if (c == 0)
            {

                Console.WriteLine("Unešeni broj je 0.");


            }
            else
            {

                Console.WriteLine("Unešeni broj je {0}!", c > 0 ? "pozitivan" : "negativan");

            }


        }

    }
}
