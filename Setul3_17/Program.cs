using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul in baza 10: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti baza de conversie (1 < b < 17): ");
            int b = int.Parse(Console.ReadLine());

            if (b <= 1 || b >= 17)
            {
                Console.WriteLine("Baza de conversie trebuie sa fie intre 1 si 16.");
                return;
            }

            string rez = ConvertInBaza(n, b);

            Console.WriteLine($"Numarul {n} in baza {b} este: {rez}");
        }

        static string ConvertInBaza(int nr, int baza)
        {
            if (nr == 0)
            {
                return "0";
            }

            string rezultat = "";

            while (nr > 0)
            {
                int rest = nr % baza;
                char cifra = (char)(rest < 10 ? '0' + rest : 'A' + rest - 10);
                rezultat = cifra + rezultat;
                nr /= baza;
            }

            return rezultat;
        }
    }
}
