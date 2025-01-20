using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z3
    {
        /// <summary>
        /// Program unosi ime, prezime i godine osobe te ispisuje:
        /// Dobra dan, ja sam {0} {1} i imam {2} godine
        /// Kako upozoriti je li napisao broj i na kojemu je mjestu taj broj
        /// </summary>
        public static void Izvedi() 
        {
            Console.WriteLine("Dobra dan, ja sam {0} {1} i imam {2} godine",
                E14Metode.UcitajString("Unesi svoje ime", "Ime obavezno"),
                E14Metode.UcitajString("Unesi svoje prezime", "Prezime obavezno"),
                E14Metode.UcitajBroj("I unesi svoje godina!", 1,110)
                );
        
        
        }

    }
}
