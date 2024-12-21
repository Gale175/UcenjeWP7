using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Varijable
    {
        public static void Izvedi()
        {

            //Console.WriteLine("E02");

            //Tipovi podataka

            int cijeliBroj = 1; //Ovo je kraće nego da smo učlitali od korisnika

            bool logickaVrijednost = true; //Zadana vrijednost je false

            float decimalniBroj = 4.5f; //Ovo je decimalni broj--- MORA SE STAVITI f ili F 

            double velikiDecimalniBroj = 3.14;

            decimal decimalniBroj2 = 3.4M;

            char znak = '@';

            string nizZnakova = "dfdsfjne";

            Console.WriteLine("Znak je broj {0}", (int)znak); //(int) je znak

            cijeliBroj = int.MaxValue;

            Console.WriteLine(cijeliBroj);
            Console.WriteLine(cijeliBroj + 1);







        }



    }
}
