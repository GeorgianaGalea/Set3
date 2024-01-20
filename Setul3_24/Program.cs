using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea primului vector: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele primului vector : ");
            int[] v1 = CitesteVector(n1);

            Console.Write("Introduceți lungimea celui de-al doilea vector: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele celui de-al doilea vector: ");
            int[] v2 = CitesteVector(n2);

            int[] rezultat = Interclasare(v1, v2);
            AfiseazaVector("Vectorul interclasat", rezultat);
        }

        static int[] CitesteVector(int n)
        {
            int[] vector = new int[n];
            string[] elemente = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(elemente[i]);
            }

            return vector;
        }

        static int[] Interclasare(int[] v1, int[] v2)
        {
            int nV1 = v1.Length;
            int nV2 = v2.Length;
            int[] rezultat = new int[nV1 + nV2];

            int i = 0, j = 0, k = 0;

            while (i < nV1 && j < nV2)
            {
                if (v1[i] < v2[j])
                {
                    rezultat[k++] = v1[i++];
                }
                else
                {
                    rezultat[k++] = v2[j++];
                }
            }

            while (i < nV1)
            {
                rezultat[k++] = v1[i++];
            }

            while (j < nV2)
            {
                rezultat[k++] = v2[j++];
            }

            return rezultat;
        }

        static void AfiseazaVector(string mesaj, int[] vector)
        {
            Console.Write($"{mesaj}: ");
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
