using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ucenje
{
    internal class Z1
    {

        public static void Izvedi()
        {

            Console.WriteLine("********************************");
            Console.WriteLine("1.-POVRŠINA PRAVOKUTNIKA");


            int d, s;
            Console.Write(" Unesi duljinu stranice pravoktunika: ");
            d = int.Parse(Console.ReadLine());
            Console.Write(" Unesi širinu stranice pravokutnika: ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Površina pravokutnika iznosi:{0}", d * s);



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
