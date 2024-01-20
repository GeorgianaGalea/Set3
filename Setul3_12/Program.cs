using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu lungimea vectorului: ");
            int lungime = int.Parse(Console.ReadLine());
            int[] vector = new int[lungime];
            Console.WriteLine("Introdu elementele vectorului:");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            SelectionSort(vector);
            Console.WriteLine("Vectorul sortat prin Selection Sort:");

            foreach (var elem in vector)
            {
                Console.Write($"{elem} ");
            }

        }

        static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[indexMin])
                    {
                        indexMin = j;
                    }
                }
                int temp = a[indexMin];
                a[indexMin] = a[i];
                a[i] = temp;
            }
        }
    }
}
