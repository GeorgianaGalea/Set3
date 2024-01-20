using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului v1: ");
            int n = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul v1[{i}]: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti lungimea vectorului v2: ");
            int m = int.Parse(Console.ReadLine());

            int[] v2 = new int[m];

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Introduceti elementul v2[{i}]: ");
                v2[i] = int.Parse(Console.ReadLine());
            }

            // Intersectia
            int[] intersectie = v1.Intersect(v2).ToArray();

            // Reuniunea
            int[] reuniune = v1.Union(v2).ToArray();

            // Diferenta v1 - v2
            int[] difv1v2 = v1.Except(v2).ToArray();

            // Diferenta v2 - v1
            int[] difv2v1 = v2.Except(v1).ToArray();

            // Afisam rezultatele
            Afisare("Intersectia intre v1 si v2", intersectie);
            Afisare("Reuniunea lui v1 si v2", reuniune);
            Afisare("Diferenta dintre v1 - v2", difv1v2);
            Afisare("Diferenta dintre v2 - v1", difv2v1);
        }

        static void Afisare(string mesaj, int[] array)
        {
            Console.WriteLine($"{mesaj}: {{{string.Join(", ", array)}}}");
        }
    }
}
