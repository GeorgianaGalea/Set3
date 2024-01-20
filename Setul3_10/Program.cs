using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introdu elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Introdu elementul pentru căutare: ");
            int k = int.Parse(Console.ReadLine());
            int poz = CautareBinara(v, k);
            if (poz != -1)
            {
                Console.WriteLine($"Elementul {k} se află la pozitia {poz + 1} în vector.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Elementul {k} nu se găsește în vector.");
                Console.ReadLine();
            }
        }

        static int CautareBinara(int[] a, int elementCautat)
        {
            int stanga = 0;
            int dreapta = a.Length - 1;
            while (stanga <= dreapta)
            {
                int mijl = (stanga + dreapta) / 2;

                if (a[mijl] == elementCautat)
                {
                    return mijl;
                }
                else if (a[mijl] < elementCautat)
                {
                    stanga = mijl + 1;
                }
                else
                {
                    dreapta = mijl - 1;
                }
            }
            return -1;
        }
    }
}
