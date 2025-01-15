using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {

        public static void Izvedi()
        {
            // osigurajte unos decimalnog broja
            float deci = 0;

            while (true)
            {
                Console.Write("Unesi broj: ");
                try
                {
                    deci = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }

            Console.WriteLine("{0:F2}", deci);

            // Osigurajte unos imena grada

            string un;


            while (true)
            {
                Console.Write("Unesi ime grada: ");
                un = Console.ReadLine();

                if (un.Trim() == "")
                {

                    Console.WriteLine("Nisi unio ime grada!");

                }
                // nešto si unio
                // da li je to samo broj
                try
                {
                    int.Parse(un);
                    Console.WriteLine("Ne smiješ unijeti broj!");
                }
                catch
                {


                }
                break;
                // da li u unosu imamo brojeve
            }

            Console.WriteLine(un);

            // da li imamo brojeve

           





        }

    }
}
