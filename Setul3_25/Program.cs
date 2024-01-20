using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți primul numar ");
            int[] numar1 = CitesteNumar();

            Console.Write("Introduceți al doilea numaer: ");
            int[] numar2 = CitesteNumar();

            int[] suma = Adunare(numar1, numar2);
            AfiseazaNumar("Suma", suma);

            int[] diferenta = Scadere(numar1, numar2);
            AfiseazaNumar("Diferența", diferenta);

            int[] produs = Inmultire(numar1, numar2);
            AfiseazaNumar("Produsul", produs);
        }

        static int[] CitesteNumar()
        {
            string input = Console.ReadLine().Trim();
            return input.Select(c => int.Parse(c.ToString())).ToArray();
        }

        static int[] Adunare(int[] nr1, int[] nr2)
        {
            int n1 = nr1.Length;
            int n2 = nr2.Length;
            int maxlength = Math.Max(n1, n2) + 1;
            int[] rezultat = new int[maxlength];

            int carry = 0;

            for (int i = 0; i < maxlength; i++)
            {
                int digit1 = (i < n1) ? nr1[n1 - 1 - i] : 0;
                int digit2 = (i < n2) ? nr2[n2 - 1 - i] : 0;

                int sumaCifre = digit1 + digit2 + carry;
                rezultat[maxlength - 1 - i] = sumaCifre % 10;
                carry = sumaCifre / 10;
            }

            return rezultat;
        }

        static int[] Scadere(int[] nr1, int[] nr2)
        {
            int n1 = nr1.Length;
            int n2 = nr2.Length;
            int maxlength = Math.Max(n1, n2);
            int[] rezultat = new int[maxlength];

            int borrow = 0;

            for (int i = 0; i < maxlength; i++)
            {
                int digit1 = (i < n1) ? nr1[n1 - 1 - i] : 0;
                int digit2 = (i < n2) ? nr2[n2 - 1 - i] : 0;

                int diferentaCifrelor = digit1 - digit2 - borrow;

                if (diferentaCifrelor < 0)
                {
                    diferentaCifrelor += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                rezultat[maxlength - 1 - i] = diferentaCifrelor;
            }

            return rezultat;
        }

        static int[] Inmultire(int[] nr1, int[] nr2)
        {
            int n1 = nr1.Length;
            int n2 = nr2.Length;
            int lungimeProdus = n1 + n2;
            int[] rezultat = new int[lungimeProdus];

            for (int i = 0; i < n1; i++)
            {
                int carry = 0;

                for (int j = 0; j < n2; j++)
                {
                    int produsCifre = nr1[n1 - 1 - i] * nr2[n2 - 1 - j] + rezultat[lungimeProdus - 1 - i - j] + carry;

                    rezultat[lungimeProdus - 1 - i - j] = produsCifre % 10;
                    carry = produsCifre / 10;
                }

                rezultat[lungimeProdus - n1 - i - 1] += carry;
            }

            return rezultat;
        }

        static void AfiseazaNumar(string mesaj, int[] numar)
        {
            Console.Write($"{mesaj}: ");
            bool afiseazaZero = false;

            foreach (var cifra in numar)
            {
                if (cifra != 0)
                {
                    afiseazaZero = true;
                }

                if (afiseazaZero)
                {
                    Console.Write(cifra);
                }
            }

            if (!afiseazaZero)
            {
                Console.Write("0");
            }



        }
    }
}
