using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_28
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

            MergeSort(v);

            Console.WriteLine("Vectorul sortat:");
            Afisare(v);
        }

        static void MergeSort(int[] vector)
        {
            if (vector.Length <= 1)
                return;

            int mijloc = vector.Length / 2;
            int[] stanga = new int[mijloc];
            int[] dreapta = new int[vector.Length - mijloc];

            Array.Copy(vector, 0, stanga, 0, mijloc);
            Array.Copy(vector, mijloc, dreapta, 0, vector.Length - mijloc);

            MergeSort(stanga);
            MergeSort(dreapta);

            Uneste(vector, stanga, dreapta);
        }

        static void Uneste(int[] vector, int[] stanga, int[] dreapta)
        {
            int i = 0, j = 0, k = 0;

            while (i < stanga.Length && j < dreapta.Length)
            {
                if (stanga[i] <= dreapta[j])
                {
                    vector[k] = stanga[i];
                    i++;
                }
                else
                {
                    vector[k] = dreapta[j];
                    j++;
                }
                k++;
            }

            while (i < stanga.Length)
            {
                vector[k] = stanga[i];
                i++;
                k++;
            }

            while (j < dreapta.Length)
            {
                vector[k] = dreapta[j];
                j++;
                k++;
            }
        }

        static void Afisare(int[] vector)
        {
            Console.WriteLine(string.Join(", ", vector));
        }
    }
}
