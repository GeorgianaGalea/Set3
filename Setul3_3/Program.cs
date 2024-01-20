using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_3
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
            int pozMin = 0, pozMax = 0;
            if (v[0] < v[1])
            {
                pozMin = 0;
                pozMax = 1;
            }
            else
            {
                pozMin = 1;
                pozMax = 0;
            }
            for (int i = 2; i < n - 1; i += 2)
            {
                if (v[i] < v[i + 1])
                {
                    if (v[i] < v[pozMin])
                    {
                        pozMin = i;
                    }

                    if (v[i + 1] > v[pozMax])
                    {
                        pozMax = i + 1;
                    }
                }
                else
                {
                    if (v[i + 1] < v[pozMin])
                    {
                        pozMin = i + 1;
                    }

                    if (v[i] > v[pozMax])
                    {
                        pozMax = i;
                    }
                }
            }
            if (n % 2 != 0)
            {
                if (v[n - 1] < v[pozMin])
                {
                    pozMin = n - 1;
                }
                else if (v[n - 1] > v[pozMax])
                {
                    pozMax = n - 1;
                }
            }
            Console.WriteLine($"Pozitia celui mai mic element {pozMin + 1}");
            Console.WriteLine($"Pozitia celui mai mare element {pozMax + 1}");
            Console.ReadLine();

        }
    }
}
