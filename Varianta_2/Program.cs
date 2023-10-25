using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SumaMediaElementelor();
            //TreiNumereImpareMici();
            //AdunareElement();
            //IntersectiaDoiVectori();
            ElementeleDeasupraMatricei();

        }

        public static void SumaMediaElementelor()
        {
            int[] myArray = { 5, 2, 7, 6, 5, 3 };

            int suma = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                suma += myArray[i];
            }

            Console.WriteLine($"Suma elementelor: {suma}");

            float media = (float)suma / myArray.Length;

            Console.WriteLine($"Media elementelor: {media}");
        }

        public static void TreiNumereImpareMici()
        {
            int[] myArray = { 3, 5, 1, 8, 9, 2, 7, 10, 11, 0 };

            int valoareaMinima1 = myArray[0];
            int valoareaMinima2 = myArray[7];
            int valoareaMinima3 = myArray[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    if (myArray[i] < valoareaMinima1)
                    {
                        valoareaMinima3 = valoareaMinima2;
                        valoareaMinima2 = valoareaMinima1;
                        valoareaMinima1 = myArray[i];
                    }
                    else if (myArray[i] < valoareaMinima2 && myArray[i] > valoareaMinima1)
                    {
                        valoareaMinima2 = myArray[i];
                    }
                    else if (myArray[i] < valoareaMinima3 && myArray[i] > valoareaMinima2)
                    {
                        valoareaMinima3 = myArray[i];
                    }
                }
            }

            Console.WriteLine($"Prima valoare minima este: {valoareaMinima1}");
            Console.WriteLine($"A doua valoare minima este: {valoareaMinima2}");
            Console.WriteLine($"A treia valoare minima este: {valoareaMinima3}");
        }

        public static void AdunareElement()
        {
            int[] myArray = { 4, 2, 3, 5, 1, 3, 8 };

            Console.Write("Introdu numarul de la tastatura:");

            int numar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] == numar)
                    {
                        Console.WriteLine($"{myArray[i]}  {myArray[j]}");
                    }
                }
            }
        }

        public static void IntersectiaDoiVectori()
        {
            int[] Array1 = { 2, 3, 1, 7 };
            int[] Array2 = { 3, 5, 8, 2, 4, 6 };
            int lungime = 0;
            int[] myArray = new int[Math.Min(Array1.Length, Array2.Length)];

            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    if (Array1[i] == Array2[j])
                    {
                        myArray[lungime] = Array1[i];
                        lungime++;
                    }
                }
            }

            for (int i = 0; i < lungime; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        public static void ElementeleDeasupraMatricei()
        {
            int[,] myArray = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Elementele deasupra diagonalei principale:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        Console.WriteLine(myArray[i, j]);
                    }
                }
            }
        }
    }
}
