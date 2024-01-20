using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_7
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
            Inversare(v);
            Console.WriteLine("vectorul dupa inversare");
            for (int i =0; i < n; i++)
            {
                Console.WriteLine($"{v[i]}");
            }
        }
        static void Inversare(int[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
        }
    }
}
