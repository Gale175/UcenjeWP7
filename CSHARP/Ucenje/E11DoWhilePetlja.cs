﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11DoWhilePetlja
    {

        public static void Izvedi() 
        {

            // Console.WriteLine("Ovo je dobro");  

            // do while osigurava izvođenje minimalno jedne iteracije
            // ispisat će "Izvede se jednom"
            do
            {

                Console.WriteLine("Izvede se jednom");

            } while (false);

            // sve ostalo navedeno u for (break i continue) te u while (&& || !) rade jednako i u do while

            // ispisati sve parne brojeve od 2 do 28 koristeći do while

            int odBroj = 2;
            int doBroj = 28;

            do 
            {
                if (odBroj % 2 == 0) 
                {

                    Console.WriteLine(odBroj);
                
                }
                odBroj++;

            } while (odBroj < doBroj);









        
        
        }


    }
}
