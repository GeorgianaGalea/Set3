using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {

                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                s += v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este {s}");
            Console.ReadLine();
        }
    }
}
