using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z1
    {

        public static void Izvedi() 
        {
            
            Console.WriteLine("1.-POVRŠINA PRAVOKUTNIKA");
            Console.WriteLine("********************************");

            decimal d, s;
            Console.Write(" Unesi duljinu stranice pravoktunika: ");
            d = decimal.Parse(Console.ReadLine());
            Console.Write(" Unesi širinu stranice pravokutnika: ");
            s = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Površina pravokutnika iznosi:{0}", d * s);


        }
    }
}
