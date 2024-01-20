using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului s1: ");
            int n = int.Parse(Console.ReadLine());

            int[] s1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul s1[{i}]: ");
                s1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti lungimea vectorului s2: ");
            int m = int.Parse(Console.ReadLine());

            int[] s2 = new int[m];

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Introduceti elementul s2[{i}]: ");
                s2[i] = int.Parse(Console.ReadLine());
            }

            int rezultat = NrSuprapuneri(s1, s2);

            Console.WriteLine($"Vectorul s2 apare in vectorul s1 de {rezultat} ori.");
        }

        static int NrSuprapuneri(int[] a, int[] b)
        {
            int count = 0;
            if ( b.Length> a.Length)
            {
                return 0;
            }

            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                bool coincid = true;

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i + j] != b[j])
                    {
                        coincid = false;
                        break;
                    }
                }

                if (coincid)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
