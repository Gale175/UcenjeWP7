using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {

        // 5. vrsta metode je konstruktor
        public Program()
        {

            Console.WriteLine("E17");

            // Objekt je pojavnost/instanca klase  ---> naučiti napamet
            // Osoba (primjetiti veliko slovo O) je klasa
            // osoba (primjetiti malo slovo O) je objekt, instanca, varijabla
            Osoba osoba = new Osoba(); // kreiranje objekta klase Osoba

            osoba.Sifra = 1;
            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";
            osoba.DatumRođenja = new DateTime(2000, 1, 1);


            Console.WriteLine(osoba.Ime);

            Osoba[] osobe = new Osoba[2];

            osobe[0] = osoba;

            // upoznati se s kraćom sintaksom za inicijalizaciju objekta
            osobe[1] = new Osoba { Ime = "Ana", Prezime = "Zimska" };

            Console.WriteLine(osobe[1].Ime);

            Console.WriteLine("*************************************");
            foreach (Osoba o in osobe)
            {

                Console.WriteLine(o.Ime);
            }

            Console.WriteLine("*************************************");

            Console.WriteLine(osoba.ImePrezime()); // na objektu osoba zovem metodu ImePrezime
            //osoba.Hello(); ovo ne mogu
            Osoba.Hello(); // ovo mogu jer je metoda static

            // ispiši Ana Zimska
            Console.WriteLine(osobe[1].ImePrezime());




        }

    }
}
