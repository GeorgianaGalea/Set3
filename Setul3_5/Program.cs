using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_5
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
                Console.WriteLine($"Introduceti elementul {i+1}:");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("introduceti pozitia de inserat: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("introduceti valoarea de inserat: ");
            int e = int.Parse(Console.ReadLine());

            

            v = InserareElem(v, e, k);

            Console.WriteLine("vectorul dupa inserare:");

            foreach (var elem in v)
            {
                Console.Write($"{elem} ");
            }
        }

      static int[] InserareElem(int[] vector, int e, int k)
        {
            if (k < 0 || k > vector.Length)
            {
                Console.WriteLine("pozitie incorecta.");
                return vector;
            }

            Array.Resize(ref vector, vector.Length + 1);

            for (int i = vector.Length - 1; i > k; i--)
            {
                vector[i] = vector[i - 1];
            }

            vector[k] = e;

            return vector;
        }
    }
    
}
