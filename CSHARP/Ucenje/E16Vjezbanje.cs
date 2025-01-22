using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16Vjezbanje
    {

        public static void Izvedi() 
        {
            // igranje bojama
            Console.BackgroundColor = ConsoleColor.Gray; // pozadniska boja teksta
            Console.ForegroundColor = ConsoleColor.Red; // boja teksta
            Console.WriteLine("Dobrodošli u vježbanje srijedom!"); 
            Console.ResetColor(); // dalje je reset
            Izbornik();
            Console.WriteLine("Doviđenja!");


        }

        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("Za uneseni broj provjeri da li je parni ili ne?");
            Console.WriteLine("0. Izlaz iz aplikacije");
            OdabirOpcijeIzbornika();
            
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch (E14Metode.UcitajBroj("Odaberi opciju izbornika"))
            {
                case 1:
                    ParnostBroja(); // crtl + klik na metodu i šećeš na metodu
                    Izbornik();
                    break;
                case 0:
                    break;
            }
        }

        private static void ParnostBroja()
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-- Program za uneseni broj ispisuje da li je paran ili ne. --");
            Console.WriteLine("-------------------------------------------------------------");
            int broj = E14Metode.UcitajBroj("Unesi cijeli broj za provjeru", 1, 100);
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je paran", broj);
            }
            else 
            {
                Console.WriteLine("Broj {0} je neparan", broj);
            }
            Console.WriteLine("-- Kraj programa parnost broja --");
        }
    }
}
