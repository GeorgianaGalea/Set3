using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceți elementele vectorului: ");

            for (int i = 0; i < n; i++)
            {

                v[i] = int.Parse(Console.ReadLine());
            }

            InsertionSort(v);

            Console.WriteLine("Vectorul sortat:");

            foreach (var elem in v)
            {
                Console.Write($"{elem} ");
            }
        }

        static void InsertionSort(int[] a)
        {

            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;


                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }


                a[j + 1] = key;
            }
        }
    }
}
