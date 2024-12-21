using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ4
    {

        // Program učitava ime grada, a ispisuje regiju
        // Osijek -- slavonija
        //zadar -- dalmacija
        public static void Izvedi() 
        {
            Console.WriteL("Upiši ime grada: ");
            string grad= Console.ReadLine();

            switch (grad)
            {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
                case "Čakovec"
                    Console.WriteLine("Međimurje");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }
            //Pojednostavljeno
            string regija = grad switch 
            { 
                "Osijek" => "Slavonija",
                "Zadar" => "Dalmacija",
                "Pula" => "Istra",
                "Čakovec" => "Međumirje",
               
            }
        }


    }
}
