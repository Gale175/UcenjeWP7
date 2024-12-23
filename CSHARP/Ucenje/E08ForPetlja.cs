using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08ForPetlja
    {
        //10 puta ispiši Osijek
        public static void Izvedi()
        {

            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");


            Console.WriteLine("*********************************");

            for (int i = 0; i < 10; i++)  // i=i+1    i+=1  ----> paziti da na kraju iza zagrade ne dođe ;
            {
                Console.WriteLine("Osijek");
            }


            //kao i kod if ne mora biti {} ali se onda petlja odnosi samo na prvu sljedeću liniju

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ispisujem {0}. broj", i + 1);
            }

            Console.WriteLine("*********************************");
            //zbroj prvih sto brojeva
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
                //ako želimo pratiti proces zbrajanja
                //Console.WriteLine("{0}+{1}={2}", suma-i, i, suma);
            }

            //ako želimo rezultat onda write ide nakon petlje
            Console.WriteLine(suma);

            Console.WriteLine("*********************************");
            //petlja može ići i "unazad"
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }



            //petlja ne mora ići za korak jedan
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************************");

            int odKuda = 2, doKuda = 20, uvecanje = 3; //simulacija da je unio korisnik

            // ono čemu težimo u kodu je bez konstanti
            for (int i = odKuda; i <= doKuda; i += uvecanje)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************************");

            int[] niz = { 2, 3, 4, 5, 3, 2, 2 }; //dužina je 7
            //ispiši broj 5
            Console.WriteLine(niz[3]);

            Console.WriteLine("*********************************");
            //ispiši svaki broj niza u novim linijama

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);  //ovo je slovo i, ne broj 1
            }
            Console.WriteLine("*********************************");

            int redaka = 8;
            int stupaca = 6;

            // for petlja se može gnijezditi
            for (int i = 0; i < redaka; i++)
            {


                for (int j = 0; j < stupaca; j++)
                {
                    Console.Write("{0,4}", (i + 1) * (j + 1));
                }

                Console.WriteLine();
            }
            Console.WriteLine("*********************************");


            //petelju se može preskočiti odnosno nastaviti

            for (int i = 0; i < 10; i++)
            {
                if (i == 4) //preskoči 5. mjesto
                {
                    continue; //vraća na početak petlju tj nastavlja od zadnjeg i
                }
                Console.WriteLine("Rezerviraj {0}. mjesto", i + 1);

            }

            Console.WriteLine("*********************************");
            //petlja se može nasilno prekinuti
            for (int i = 0; i < 10; i++) //prirodni kraj je kada je i=10
            {
                if (i == 5)
                {
                    break; //nasilno prekini
                }
                Console.WriteLine(i);
            }


            Console.WriteLine("*********************************");
            //korisnost break-a
            // prim broj, prime nuber, prosti broj
            // 2 3 5 7 11 13 17
            // zašto 4 nije prim broj? cjelobrojno je djeljiv sa 2 | 9 nije jer je djeljiv i sa 3

            int brojZaProvjeru = 157;
            int brojacIteracija = 1;
            bool prim = true; //moja hipoterza je da je taj broj prim broj

            for (int i = 2; i < brojZaProvjeru/2; i++)
            {
                Console.WriteLine("{0}%{1}=={2} ({3})", brojZaProvjeru, i, brojZaProvjeru % i, brojacIteracija++);
                if (brojZaProvjeru % i == 0)
                {
                    prim = false;
                    break; //to nije prim broj
                }
            }

            Console.WriteLine("{0} {1} prim broj", brojZaProvjeru, prim ? "JE" : "NIJE");

            // Za razbribrigu https://hr.wikipedia.org/wiki/Eratostenovo_sito





            Console.WriteLine("*********************************");

            //beskonačna petlja
            for (int i = 0; i > -1; i++)  //OVO NIJE beskonačna petlja zbog brojevne kružnice
            {
                break;
            }

            for (; ; ) //ovo je sintaksa beskonačna petlja
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} ", new Random().Next());
                Thread.Sleep(100);
                //break; //ovo osloboditi ili svaki puta ručno zaustaviti program
            }










        }
    }
}
