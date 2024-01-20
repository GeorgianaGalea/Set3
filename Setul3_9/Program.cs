using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti numarul de pozitii pentru rotirea spre stanga (k): ");
            int k = int.Parse(Console.ReadLine());

            RotireStanga(v, k);

            Console.WriteLine("Vectorul dupa rotire:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.ReadLine();
        }
        static void RotireStanga(int[] a, int k)
        {
            k %= a.Length; 
            for (int i = 0; i < k; i++)
            {
                int elem1 = a[0];
                for (int j = 0; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                }
                a[a.Length - 1] = elem1;
            }
        }
    }
    
}
