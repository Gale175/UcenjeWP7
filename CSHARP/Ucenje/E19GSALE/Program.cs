using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GSALE
{
    public class Program
    {

        public Program() 
        {
            //ovo mi moze pomoci u izgradnji programa generator lozinki
            Console.WriteLine("E19");
            // problem nizova je to mora unaprijed znati dužinu niza prije nego ga kreiramo
            // tom problemu u c# se doskace koristenjem liste (List)
            // list koristi sintaksu parametriziranja, moramo shvatiti sto su generic klase ili generici

            List <int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(7);

            var sb = new Random();
            for (int i = 0; i < 20; i++)
            {
                brojevi.Add(sb.Next(1, 100));
            }

            // trenutno u listi ima 22 broja
            Console.WriteLine(brojevi[6]);

            Console.WriteLine("****************************");
            foreach (var broj in brojevi)
            {
                Console.WriteLine(broj);
            }

            //brojevi.Add("a"); // nece raditi jer je lista in, a ne string

            List<string> imena = new List<string>();
            imena.Add("Ivan");
            imena.Add("Marko");

            Console.WriteLine(imena[1]);

            List<Smjer> smjerovi = new List<Smjer>();
            smjerovi.Add(new Smjer { Sifra = 1, Naziv = "Web programiranje" });
            smjerovi.Add(new () { Sifra = 2, Naziv = "Serviser" });

            var o = new Obrada<Smjer>();

            o.PredmetObrade = smjerovi[0];

            o.Posao();

            var op= new Obrada<Polaznik>();

            op.PredmetObrade = new Polaznik { Sifra = 7, Ime = "Ivan", Prezime = "Mrav" };

            op.Posao();

            //var os = new Obrada<string>(); // string ne nasljeduje entitet

            Console.WriteLine("****************************");

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            Console.WriteLine("****************************");

            smjerovi.Sort();

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            Console.WriteLine("****************************");


            op.Job();


            Console.WriteLine("****************************");

            Console.WriteLine(smjerovi[0]);

            Console.WriteLine("****************************");




        }

    }
}
