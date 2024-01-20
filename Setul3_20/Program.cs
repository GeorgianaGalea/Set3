using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector: ");
            int[] v1 = ReadVector();
            Console.Write("Introduceti al doilea vector: ");
            int[] v2 = ReadVector();
            string ordinelex = ComparareVectori(v1, v2);
            Console.WriteLine($"Ordinea lexicografica: {ordinelex}");
            Console.ReadLine();
        }
        static int[] ReadVector()
        {
            string[] n = Console.ReadLine().Split(' ');
            int[] a = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                a[i] = int.Parse(n[i]);
            }
            return a;
        }
        static string ComparareVectori(int[] v1, int[] v2)
        {
            int minLength = Math.Min(v1.Length, v2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (v1[i] < v2[i])
                {
                    return "Primul vector apare inaintea celui de-al doilea vector in ordine lexicografica.";
                }
                else if (v1[i] > v2[i])
                {
                    return "Al doilea vector apare inaintea primului vector in ordine lexicografica.";
                }
            }
            if (v1.Length < v2.Length)
            {
                return "Primul vector apare inaintea celui de-al doilea vector in ordine lexicografica.";
            }
            else if (v1.Length > v2.Length)
            {
                return "Al doilea vector apare inaintea primului vector in ordine lexicografica.";
            }
            return "Vectorii sunt identici lexicografic.";
        }
    }
}
