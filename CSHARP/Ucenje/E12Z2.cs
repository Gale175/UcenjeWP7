using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z2
    {

        public static void Izvedi()
        {


            //Console.WriteLine("Izvodi se");

            //Korisnik unosi dvije rijčei
            //program ispisuje unesnee riječi redoslijedom druga pa prva riječ unatrag u istoj liniji

            // Pero kava ---> avak oreP


            Console.Write("Unesi prvu riječ: ");
            string rijec1 = Console.ReadLine();


            Console.Write("Unesi prvu riječ: ");
            string rijec2 = Console.ReadLine();

            string unazad = "";
            rijec2 = rijec1 + " " + rijec2;

            for (int i = rijec2.Length - 1; i >= 0; i--)
            {
                unazad += rijec2[i];
            }

            Console.WriteLine("{0}", unazad);









        }


    }
}
