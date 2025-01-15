using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z1
    {

        public static void Izvedi() 
        {

            //Console.WriteLine("13");

            //osigurati unos broja

            int broj=0;



            while (true) 
            {
                Console.Write("Unesi broj: ");
                try
                {
                    broj = int.Parse(Console.ReadLine()); 
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }

            Console.WriteLine(broj);


            // osigurati unos parnog broja
            //---- nisam napravio

            // osigurati unos visine čovjeka

            int visina = 0;
            string unos2;
            int brojZnak1;

            for (; ; )
            {
            pocetak: // labela --> label

                Console.Write("Unesi visinu čovjeka: ");
                unos2 = Console.ReadLine();
                if (unos2.Trim() == "")
                {

                    Console.WriteLine("Nisi unio visinu!");
                    continue;

                }
                try
                {
                    visina = int.Parse(unos2);
                    
                    if (visina < 0)
                    {
                        Console.WriteLine("Visina ne može biti manja od 0!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    
                    foreach (char znak in unos2)
                    {

                        brojZnak1 = znak;
                        if (brojZnak1 < 48 || brojZnak1 > 57)
                        {

                            Console.WriteLine("Uneseni znak {0} nije broj," +
                                "on je dio abecede ...{1}, {2}, {3}...", znak, (char)(brojZnak1 - 1), znak, (char)(brojZnak1 + 1));
                            goto pocetak;

                        }

                    }
                    Console.WriteLine("Nije visina!");

                }

            }

            Console.WriteLine("Visoki ste {0} cm", visina);

        }

    }
}
