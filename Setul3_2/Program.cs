using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            bool a = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea k: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    a = true;
                    Console.WriteLine($"Prima pozitie in care apare {k} este: {i}");
                }
            }

            if(!a)
                Console.WriteLine($"{k} nu apare in vector");
        }
    }
}
