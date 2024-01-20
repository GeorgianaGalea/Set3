using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_16
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
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            int cmmd = CMMD(v);

            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
        }

        static int CMMD(int[] a)
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Vectorul este gol. CMMD nu este definit.");
                return 0;
            }

            int cmmd = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                cmmd = CMMD2nr(cmmd, a[i]);

                if (cmmd == 1)
                {
                    break;
                }
            }

            return cmmd;
        }

        static int CMMD2nr(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
