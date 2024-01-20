using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti pozitia de pe care doriti sa stergeti elementul: ");
            int k = int.Parse(Console.ReadLine());
            v = StergeElem(v, k);
            Console.WriteLine("Vectorul dupa modificari:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{v[i]}");
            }

        }
        static int[] StergeElem(int[] a, int k)
        {
            for (int i = k; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            Array.Resize(ref a, a.Length - 1);
            return a;
        }
    }
}
