using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele vectorului: ");
            int[] vector = CitesteVector(n);

            Console.Write("Introduceți indexul dorit: ");
            int index = int.Parse(Console.ReadLine());
            int valoarefinala = ValoareDupaSortare(vector, index);
            Console.WriteLine($"Valoarea de pe poziția {index} după sortare este: {valoarefinala}");
        }
        static int[] CitesteVector(int n)
        {
            int[] a = new int[n];
            string[] elemente = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(elemente[i]);
            }

            return a;
        }
        static int ValoareDupaSortare(int[] vector, int index)
        {

            int[] vectorSortat = (int[])vector.Clone();
            Array.Sort(vectorSortat);
            return vectorSortat[index];

        }
    }
}
