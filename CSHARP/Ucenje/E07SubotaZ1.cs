﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ1
    {
        //Za učitani cijeli broj između 10 i 99 ispiši jediničnu vrijednost
        //Za 56 treba ispisati 6, za 82 trabe ispisati 2
        public static void Izvedi() 
        {
            Console.Write("Unesi cijeli broj između 10 i 99: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj%10);

            Console.Write("Ponovi unos: ");
            Console.WriteLine(Console.ReadLine()[1]);

            //Sada ispisati prvu znamenku iz int
            Console.WriteLine(broj/10);


        }

    }
}
