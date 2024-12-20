using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04UvjetnoGrananjeIf
    {
        public static void Izvedi()

        {
            // Console.WriteLine("E04");

            int broj = 7; // Ovo je kao da sam ispisao poruku i da je korisnik unio broj 7

            //Operator == provjerava jednakost on je tipa bool

            bool uvjet = broj == 7;

            //if radi sa bool tipom podatka
            if (uvjet)
            {
                Console.WriteLine("Broj ima vrijednost 7");
            }

            // U pravilu se if koristi ovako

            if (broj == 7)
            {

                Console.WriteLine("Ponovo je jednako 7");
            }


            //if može i bez {}
            if (broj == 7)
                Console.WriteLine("Ovo je bez {} je jednako");
            //Console.WriteLine("I ovo bih da je uz uvjet jednakosti da je broj 7");

            if (broj == 7)
            {
                Console.WriteLine("I opet je 7 ali uz inače");
            }
            else
            {
                Console.WriteLine("Broj NIJE 7");
            }

            //Maksimalni oblik if naredbe je
            if (broj == 6)
            {
                Console.WriteLine("Sad je 6");
            }
            else if (broj == 7)
            {
                Console.WriteLine("Sad je 7");
            }//Može ići koliko god želimo else if
            else //Može i ne mora
            {
                Console.WriteLine("Broj nije niti 6 niti 7");
            }


            // If koristi <, >, >=, <= i !=različito

            //Logički operatori and, or, not

            //and & i &&

            broj = 1;
            int temp = 2;

            if (broj != 1 & temp < 0) // Provjeravat će se oba uvjeta
            {
                Console.WriteLine("Hladno je");
            }

            if (broj != 1 && temp < 0) // Ako prvi uvjet nije ispunje ne provjerava se drugi
            {
                Console.WriteLine("Hladno je");
            }

            // or | (AltGr+W) ||

            if (broj > 0 | temp > 0) // Provjeravat će se oba uvjeta 
            {
                Console.WriteLine("Toplo je");
            }

            if (broj > 0 || temp > 0) // Ako prvi uvjet nije ispunje ne provjerava se drugi
            {
                Console.WriteLine("Toplo je");
            }

            // not ! 
            if (!(broj > 1 || temp > 0))
            {
                Console.WriteLine("Ovo je kompliciran izraz");
            }

            // if se može ugnježđivati ili gnjezditi
            if (broj > 0) 
            {
                if (temp == 0) 
                { 
                    Console.WriteLine("Ugnježđeno");
                }
            }

            //djelokrug varijable

            if (broj > 0) 
            {
                int t = 8; // Ova varijabla živi samo unutar ovoga if
            }

            //Console.WriteLine(t); // Varijabla t nije vidljiva iznad gore definiranog if- GREŠKA

            string grad = "Osijek";

            if (grad == "Osijek")
            {
                Console.WriteLine("Super");
            }
            else 
            {
                Console.WriteLine("Nije super");
            }

            // U slučaju da if i else imaju istu akciju (naredba, metoda) tada se može koristit
            // inline if (? operator)

            Console.WriteLine(grad == "Osijek" ? "Super" : "Nije super");



        }

    }
}
