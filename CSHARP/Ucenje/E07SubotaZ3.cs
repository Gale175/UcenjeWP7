using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ3
    {

        // Unos dva broja
        //Program ispisuje manji broj
        // 5 i 2 ispisuje 2
        // 3 i 5 ispisuje 3
        // 3 i 3 ispisuje "jednaki su"
        public static void Izvedi() 
        {
            int broj1, broj2;
            Console.Write("Unesi prvi broj: ");
            broj1=int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            broj2=int.Parse(Console.ReadLine());

            Console.WriteLine(broj1<broj2 ? broj1 : broj1>broj2 ? broj2 : "Jednaki su");
            
        }

        //DZ isto napraviti za 3 broja

        
    }
}
