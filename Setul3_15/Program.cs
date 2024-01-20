using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {

                v[i] = int.Parse(Console.ReadLine());
            }

            int UltimElemUnic = 0;
            for (int i = 0; i < n; i++)
            {
                bool Edublu = false;
                for (int j = 0; j < UltimElemUnic; j++)
                {
                    if (v[i] == v[j])
                    {
                        Edublu = true;
                        break;
                    }
                }
                if (!Edublu)
                {
                    v[UltimElemUnic] = v[i];
                    UltimElemUnic++;
                }
            }
            Console.WriteLine("Vectorul dupa eliminarea duplicatelor ");
            for (int i = 0; i < UltimElemUnic; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
