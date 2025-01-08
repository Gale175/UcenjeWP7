using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Z1
    {

        public static void Izvedi()
        {

            Console.WriteLine("********************************");
            Console.WriteLine("1.-POVRŠINA PRAVOKUTNIKA");


            int d, s;
            Console.Write("  Unesi duljinu stranice pravoktunika: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("  Unesi širinu stranice pravokutnika: ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Površina pravokutnika iznosi:{0}", d * s);


        }
    }
}
