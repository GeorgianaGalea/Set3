using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_30
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
            int majoritate = GasesteElementMajoritate(v);
            if (majoritate != -1)
            {
                Console.WriteLine($"Elementul majoritate este: {majoritate}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nu exista element majoritate.");
                Console.ReadLine();
            }
        }
        static int GasesteElementMajoritate(int[] vector)
        {
            int majoritateCandidat = -1;
            int count = 0;
            foreach (int element in vector)
            {
                if (count == 0)
                {
                    majoritateCandidat = element;
                    count = 1;
                }
                else if (element == majoritateCandidat)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            count = 0;
            foreach (int element in vector)
            {
                if (element == majoritateCandidat)
                {
                    count++;
                }
            }
            return count > vector.Length / 2 ? majoritateCandidat : -1;
        }
    }
}
