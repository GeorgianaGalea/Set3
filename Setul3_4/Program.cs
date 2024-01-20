using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_4
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
            int min = v[0];
            int max = v[0];
            int countMin = 1;
            int countMax = 1;

            for (int i = 1; i < n; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    countMin = 1;
                }
                else if (v[i] == min)
                {
                    countMin++;
                }

                if (v[i] > max)
                {
                    max = v[i];
                    countMax = 1;
                }
                else if (v[i] == max)
                {
                    countMax++;
                }
            }

            Console.WriteLine($"Cea mai mica valoare este {min} si apare de {countMin} ori.");
            Console.WriteLine($"Cea mai mare valoare este {max} si apare de {countMax} ori.");
        }

    }
}
