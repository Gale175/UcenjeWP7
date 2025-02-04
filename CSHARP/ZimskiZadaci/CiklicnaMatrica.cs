using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    class CiklicnaMatrica
    {
        public static void Izvedi()
        {


            Console.WriteLine("CIKLICNA MATRICA");
            Console.WriteLine("********************************");
            
            // upiti za unos redaka i stupaca
            Console.Write("Unesi broj redaka: ");
            int red = int.Parse(Console.ReadLine());
            Console.Write("Unesi broj stupaca: ");
            int stup = int.Parse(Console.ReadLine());

            int[,] matrica = new int[red, stup]; // kreiranje matrice i deklariranje
            int broj = 1; // deklariranje broja
            int redak = 0; // deklariranje reda
            int stupac = 0; // deklariranje stupca
            int maxRed = red - 1; // deklariranje maksimalnog reda
            int maxStup = stup - 1; // deklariranje maksimalnog stupca
            int minRed = 0; // deklariranje minimalnog reda
            int minStup = 0; // deklariranje minimalnog stupca

            // petlja za kretanje po matrici
            while (broj <= red * stup)
            {
                // Kretanje udesno
                for (int i = minStup; i <= maxStup; i++)
                {
                    matrica[minRed, i] = broj;
                    broj++;
                }
                minRed++; // povecanje minimalnog reda

                // Kretanje prema dolje
                for (int i = minRed; i <= maxRed; i++)
                {
                    matrica[i, maxStup] = broj;
                    broj++;
                }
                maxStup--; // smanjenje maksimalnog stupca

                // Kretanje ulijevo
                for (int i = maxStup; i >= minStup; i--)
                {
                    matrica[maxRed, i] = broj;
                    broj++;
                }
                maxRed--; // smanjenje maksimalnog reda

                // Kretanje prema gore
                for (int i = maxRed; i >= minRed; i--)
                {
                    matrica[i, minStup] = broj;
                    broj++;
                }
                minStup++; // povecanje minimalnog stupca
            }

            // Ispis matrice
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
