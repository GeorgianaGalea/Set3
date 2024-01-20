using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_27
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
                Console.Write($"Introduceti elementul vectorului[{i}]: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Quicksort(v, 0, n - 1);

            Console.WriteLine("Vectorul sortat:");
            Afisare(v);
        }

        static void Quicksort(int[] v, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int pivotIndex = Partitie(v, stanga, dreapta);

                Quicksort(v, stanga, pivotIndex - 1);
                Quicksort(v, pivotIndex + 1, dreapta);
            }
        }

        static int Partitie(int[] vector, int stanga, int dreapta)
        {
            int pivot = vector[dreapta];
            int i = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (vector[j] <= pivot)
                {
                    i++;
                    Schimba(vector, i, j);
                }
            }

            Schimba(vector, i + 1, dreapta);

            return i + 1;
        }

        static void Schimba(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        static void Afisare(int[] vector)
        {
            Console.WriteLine(string.Join(", ", vector));
        }
    }
}
