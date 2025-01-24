using System;
using System.Buffers;
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

            Osoba[] osobe = new Osoba[3];

            osobe[0] = osoba;

            // upoznati se s kraćom sintaksom za inicijalizaciju objekta
            osobe[1] = new Osoba { Ime = "Ana", Prezime = "Zimska" };

            Console.WriteLine(osobe[1].Ime);

            Console.WriteLine("*************************************");
            foreach (Osoba vo in osobe) // vo mi glumi varijbal osoba
            {

                Console.WriteLine(vo?.Ime ?? "Nije postavljeno"); // o?.Ime --> program neće puknuti ako je null ---> ovo je if
            }

            Console.WriteLine("*************************************");

            Console.WriteLine(osoba.ImePrezime()); // na objektu osoba zovem metodu ImePrezime
            //osoba.Hello(); //ovo ne mogu
            Osoba.Hello(); // ovo mogu jer je metoda static

            // ispiši Ana Zimska
            Console.WriteLine(osobe[1].ImePrezime());

            // ne treba pisati s desne strane jer piše sa lijeve mjesto
            Mjesto mjesto = new() { Naziv = "Osijek", PostanskiBroj = "31000" };

            osoba.Mjesto = mjesto;

            Console.WriteLine("*************************************");
            //ispisati Osijek
            Console.WriteLine(osoba.Mjesto.Naziv);

            var m = new Mjesto() { Naziv = "Zagreb", PostanskiBroj = "10000" }; // () se može izostaviti 

            osobe[1].Mjesto = m;

            Console.WriteLine("*************************************");
            // ispisati Zagreb
            Console.WriteLine(osobe[1].Mjesto.Naziv);

            osobe[2] = new()
            {

                Ime = "Ivo",
                Mjesto = new()
                {
                    Naziv = "Split"
                }
            };

            // ispisati Split
            Console.WriteLine(osobe[2].Mjesto.Naziv);


            // Primjer korištenja klasa iz SDK

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(random.Next(1, 10));

            }

            // da ne pišem svaki puta osoba[2] mogu koristiti varijablu o
            var o = osobe[2];

            o.Mjesto.Zupanija = new Zupanija
            {
                Naziv = "Splitsko-dalmatinska",
                Zupan = new()
                {

                    Ime = "Marko",
                    Mjesto = new()
                    {
                        Naziv = "Sinj"
                    }
                }
            };

            // ispisati Sinj
            Console.WriteLine(o.Mjesto.Zupanija.Zupan.Mjesto.Naziv);




        }

    }
}
