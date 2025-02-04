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


            string velikaSl = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSl = "abcdefghijklmnopqrstuvwxyz";
            string brojevi = "0123456789";
            string znakovi = "/!@#$%^&*()";
            string sviZnakovi = "";

            
            Console.Write("Uključena velika slova? (da/ne): ");
            bool Vslova = Console.ReadLine().Trim().ToLower() == "da";
            if (Vslova) sviZnakovi += velikaSl;

            Console.Write("Uključena mala slova? (da/ne): ");
            bool MSlova = Console.ReadLine().Trim().ToLower() == "da";
            if (MSlova) sviZnakovi += malaSl;

            Console.Write("Uključeni brojevi? (da/ne): ");
            bool brUklj = Console.ReadLine().Trim().ToLower() == "da";
            if (brUklj) sviZnakovi += brojevi;

            Console.Write("Uključeni znakovi? (da/ne): ");
            bool znakUklj = Console.ReadLine().Trim().ToLower() == "da";
            if (znakUklj) sviZnakovi += znakovi;

            Console.Write("Ponavljanje znakova? (da/ne): ");
            bool ponavljanje = Console.ReadLine().Trim().ToLower() == "da";
            
            Console.Write("Prvi znak u lozinki broj? (da/ne): ");
            bool prviBroj = Console.ReadLine().Trim().ToLower() == "da";

            Console.Write("Prvi znak u lozinki interpunkcijski znak? (da/ne): ");
            bool prviInter = Console.ReadLine().Trim().ToLower() == "da";

            Console.Write("Broj lozinki koji želim generirati je: ");
            int kol = int.Parse(Console.ReadLine());


            if (brUklj == false && Vslova == false && MSlova == false && znakUklj == false)
            {
                Console.WriteLine("Niste uključili niti jednu vrstu znakova!");
                return;
            }


            Random random = new Random();
            

            string password = "";

            for (int i = 0; i < kol; i++)
            {
                password = "";
                for (int j = 0; j < duz; j++)
                {
            

                    int pozicija;
                    pozicija = random.Next(0, sviZnakovi.Length);

                    if (ponavljanje == true)
                    {
                        password += sviZnakovi[pozicija];
                    }
                    else
                    {
                        while (password.Contains(sviZnakovi[pozicija]))
                        {
                            pozicija = random.Next(0, sviZnakovi.Length);
                        }
                        password += sviZnakovi[pozicija];
                    }

                    if (prviBroj == true)
                    {
                        if (j == 0)
                        {
                            password = random.Next(0, 10).ToString();
                        }
                    }

                    if (prviInter == true)
                    {
                        if (j == 0)
                        {
                            password = znakovi[random.Next(0, znakovi.Length)].ToString();
                        }
                    }
                }
                Console.WriteLine(password);
            }




            

            








        }
    }
}
