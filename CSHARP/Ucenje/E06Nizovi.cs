using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06Nizovi
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E06");

            //Motivacija treba pohraniti prosječne temperature u 12 mjeseci

            //Krivi pristup
            int sijecanj, veljaca, ozujak, /*...*/ prosinac; //Ne raditi 12 varijabli

            //uglate zagrade [-(AltGr+F ili Alt+91), ]-(AltGr+G ili Alt+93)
            //Nizovi=Polja eng Array


            //jednodimenzionalni
            int[] temp = new int[12]; // Glavni problem nizova je što u trenutku kreiranja moraš znati koliko elemenata

            //Niz ima indeks i vrijednost
            temp[0] = -1; //Siječanj
            temp[1] = 1;  // Veljača
            //...
            temp[11] = 4;   //Prosinac

            Console.WriteLine(temp[0]);
            Console.WriteLine(temp);
            //Ispisivanje svih elemenata niza
            Console.WriteLine(string.Join(",", temp));

            //dvodimenzionalni niz - tablica
            int[,] tablica =
            {
                { 1,2,3,},
                { 4,5,6,},
                { 7,8,9,}
            };

            //Ispišite broj 6
            Console.WriteLine(tablica[1, 2]);

            //trodimenzionalni niz - kocka
            int[,,] kocka = new int[10, 10, 10];
            kocka[5, 5, 5] = 27;
            Console.WriteLine(kocka[5, 5, 5]);

            //Četverodimenzionalni niz - tesaarect

            //multiverse
            int[,,,,,,,,,,] multiverse;

            // zašto nam je bitan jednodimenzionalni niz
            string grad = "Najbolji grad je Osijek";

            //ispiši slovo j
            //string je niz znakova
            Console.WriteLine(grad[3]);

            char znak = 'A'; //- SAMO JEDAN ZNAK moguće pohraniti, a za VIŠE znakova uvijek string

            //ispišite zadnji znak
            Console.WriteLine(grad[grad.Length - 1]); //ispiše zadnje slovo
            Console.WriteLine(grad.Length); //broji ukupan broj znakova u varijabli
        }

    }
}
