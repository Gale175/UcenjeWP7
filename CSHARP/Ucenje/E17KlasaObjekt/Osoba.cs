﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    // klasa je opisnik objekta --> ovo naučit napamet ---> klasa je entitet
    public class Osoba
    {

        // klasa sadrži svojstva
        // princip učahurivanja gdje se kaže da će klasa sakriti svoja svojstva ---> najčešće POCO (plain old c# objects)
        // svojstva klase idu velikim početnim slovima
        public int Sifra { get; set; }  // kad pravim klasu napišem prop pa dvaput tab
        public string? Ime { get; set; } // ? znači da može biti null
        public string Prezime { get; set; } = ""; // = će postaviti prazno, neće biti null
        public DateTime? DatumRođenja { get; set; }


        // ovo je iz konteksta baza veza 1:n
        public Mjesto Mjesto { get; set; } = new Mjesto();

        // ovo je iz konteksta baza veza n:n
        public Mjesto[]? Mjesta { get; set; }





        // klasa može i ne mora sadržavati metode
        // metoda vidi i upravlja svojstvima klase

        /// <summary>
        /// Vraća puno ime i prezime osobe
        /// </summary>
        /// <returns>Sttring koji sadrži ime i prezime osobe</returns>
        public string ImePrezime() // nema static jer static metode se zovu na klasi, a bez static se zovu na objektu
        {
            NeVidiSeIzvana();
            return Ime + " " + Prezime; // ovo nije dobro riješenje- strign je mutable
        }

        private string NeVidiSeIzvana() 
        {
            return "";
        }



        public static void Hello()  // nju zovem na klasi a ne na objektu, Osoba.Hello(); 
        {

            Console.WriteLine("!Hello");
        }
    }
}
