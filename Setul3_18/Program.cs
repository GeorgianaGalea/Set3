using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți gradul polinomului : ");
            int n = int.Parse(Console.ReadLine());

            double[] coeficienti = new double[n + 1];

            Console.WriteLine("Introduceți coeficienții polinomului de la gradul cel mai mic la cel mai mare:");

            for (int i = 0; i <= n; i++)
            {
                coeficienti[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Introduceți punctul x pt care să  se calculeze valoarea polinomului: ");
            double x = double.Parse(Console.ReadLine());

            double rezultat = CalculeazaValPolinom(coeficienti, x);

            Console.WriteLine($"Valoarea polinomului în {x} este: {rezultat}");
        }

        static double CalculeazaValPolinom(double[] a, double x)
        {
            double rezultat = 0.0;

            for (int i = 0; i < a.Length; i++)
            {
                rezultat += a[i] * Math.Pow(x, i);
            }

            return rezultat;
        }
    }
}
