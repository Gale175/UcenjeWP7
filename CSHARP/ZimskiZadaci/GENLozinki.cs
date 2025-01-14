using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class GENLozinki
    {

        public static void Izvedi()
        {


            Console.WriteLine("GENERATOR LOZINKI");
            Console.WriteLine("********************************");

            Console.Write("Unesi dužinu lozinke: ");
            int duz = int.Parse(Console.ReadLine());

            Console.Write("Broj lozinki koji želim generirati je: ");
            int kol = int.Parse(Console.ReadLine());



            string velikaSl = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSl = "abcdefghijklmnopqrstuvwxyz";
            string brojevi = "0123456789";
            string znakovi = "/!@#$%^&*()";
            string sviZnakovi = "";

            
            Console.Write("Uključena velika slova? (y/n): ");
            bool Vslova = bool.Parse(Console.ReadLine());
            if (Vslova = true) sviZnakovi += velikaSl;

            Console.Write("Uključena mala slova? y/n ");
            bool MSlova = bool.Parse(Console.ReadLine());
            if (MSlova = true) sviZnakovi += malaSl;

            Console.Write("Uključeni brojevi? y/n ");
            bool brUklj = bool.Parse(Console.ReadLine());
            if (brUklj = true) sviZnakovi += brojevi;

            Console.Write("Uključeni znakovi? y/n ");
            bool znakUklj = bool.Parse(Console.ReadLine());
            if (znakUklj = true) sviZnakovi += znakovi;


            Random random = new Random();
            

            string[] password = new string[duz];

            foreach (string s in password) 
            { 
            
                Console.WriteLine(s);
            
            }

            

            /////








        }
    }
}
