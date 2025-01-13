using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10WhilePetlja
    {

        public static void Izvedi()

        {

            //Console.WriteLine("Radi");

            // while radi sa bool

            // beskonačna petlja
            while (true)
            {

                Console.WriteLine("Ispis iz beskonačne petlje nakon čega je break!");
                break;

            }


            Console.WriteLine("*****************************************************");
            //ispisuje 1 do 10
            int i = 0;
            while (i++ < 10)  //može ići i (i<10)
            {

                Console.WriteLine(i); // (++i)
                // i++ krenut će od 0

            }

            Console.WriteLine("*****************************************************");
            //continue radi na isti način
            // ispisuje 11 22 33 44 55 66
            int j = 0;
            while (i >= 10 && j++ < 10)  // može još i || te !
            {

                Console.WriteLine(i * j);

            }

            Console.WriteLine("*****************************************************");
            // u for i while se ne mora uči

            int odBroja = 0;

            int doBroja = 10;

            for (int x = odBroja; x <= odBroja; x++) 
            { 
            
            
                Console.WriteLine(x);
            
            }
            Console.WriteLine("*****************************************************");

            //neće se ispisati ništa
            bool uvjet = false;
            while (uvjet) 
            { 
            
                Console.WriteLine("Neće se ispisati");
            
            }


          
















        }

    }
}
