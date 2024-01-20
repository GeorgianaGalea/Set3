using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Interschimbare0Vector(v);

            Console.WriteLine("Vectorul rearanjat:");
            foreach (var elem in v)
            {
                Console.Write($"{elem} ");
            }
        }

        static void Interschimbare0Vector(int[] a)
        {
            int Index0 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {

                    int temp = a[i];
                    a[i] = a[Index0];
                    a[Index0] = temp;

                    Index0++;
                }
            }
        }
    }
}
