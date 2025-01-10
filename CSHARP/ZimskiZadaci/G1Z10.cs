using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class G1Z10
    {

        public static void Izvedi()
        {
            Console.WriteLine("10.-KALKULATOR");
            Console.WriteLine("********************************");


            Console.Write("Unesi prvi broj: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Odaberi željenu operaciju:");
            Console.WriteLine("     1. ZBRAJANJE");
            Console.WriteLine("     2. ODUZIMANJE");
            Console.WriteLine("     3. MNOŽENJE");
            Console.WriteLine("     4. DIJELJENJE");


            int odabir = int.Parse(Console.ReadLine());
            switch (odabir)
            {
                case 1:
                    Console.WriteLine("Zboj dvaju brojeva je {0}", a + b);
                    break;
                case 2:
                    Console.WriteLine("Razlika dvaju brojeva je {0}", a - b);
                    break;
                case 3:
                    Console.WriteLine("Umnožak dva broja je {0}", a * b);
                    break;
                case 4:
                    Console.WriteLine("Kvocijent dva broja je {0:F2}", a / b);
                    break;
                default:
                    Console.WriteLine("Nije opcija");
                    break;
            }



        }

    }
}
