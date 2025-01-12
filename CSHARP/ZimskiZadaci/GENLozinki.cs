using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class GENLozinki
    {

        public static void Izvedi() 
        {


            Console.WriteLine("GENERATOR LOZINKI");
            Console.WriteLine("********************************");

            Console.Write("Unesi dužinu lozinke: ");
            int duz = int.Parse(Console.ReadLine());

            Console.Write("Broj lozinki koji želim generirati je: ");
            int kol = int.Parse(Console.ReadLine());

            Console.Write("Uključena velika slova? y/n ");
            bool Vslova = bool.Parse(Console.ReadLine(true));

            Console.Write("Uključena mala slova? y/n ");
            bool MSlova = bool.Parse(Console.ReadLine(true));

            Console.Write("Uključeni brojevi? y/n ");
            bool brojevi = bool.Parse(Console.ReadLine(true));

            Console.Write("Uključeni znakovi? y/n ");
            bool znakovi = bool.Parse(Console.ReadLine(true));

            char[] pass = new char[duz];

            



                    //ABCDEFGHIJKLMNOPQRSTUVWXYZ
                    //abcdefghijklmnopqrstuvwxyz
                    //0123456789
                    //!@#$%^&*()


        }
    }
}
