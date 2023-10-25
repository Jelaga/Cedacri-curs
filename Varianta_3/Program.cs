using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GasireaElementului();
            //NumerePareMari();
            //NumereAproapeZero();
            //DiferentaVectorilor();
            IndexSubPrincipala();
        }

        public static void GasireaElementului()
        {
            int[] myArray = { 1, 3, 4, 3, 8 };

            Console.WriteLine("Introdu numarul pe care il cauti:");

            int numar = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Valorile lui myArray[{i}]: " + myArray[i]);
            }

            for(int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == numar)
                {
                    Console.WriteLine($"Numarul {numar} este prezent pe indexul {i}");
                }
            }
        }

        public static void NumerePareMari()
        {
            int[] myArray = { 3, 4, 5, 8, 9, 1, 2, 7, 10, 0 };

            int maxValue1 = myArray[0];
            int maxValue2 = myArray[0];
            int maxValue3 = myArray[0];

            for(int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] %2 == 0)
                {
                    if (myArray[i] > maxValue1)
                    {
                        maxValue3 = maxValue2;
                        maxValue2 = maxValue1;
                        maxValue1 = myArray[i];
                    }
                    else if (myArray[i] > maxValue2 && myArray[i] < maxValue1)
                    {
                        maxValue2 = myArray[i];
                    }
                    else if (myArray[i] > maxValue3 && myArray[i] < maxValue2)
                    {
                        maxValue3 = myArray[i];
                    }
                }
            }

            Console.WriteLine($"Prima valoare para cea mai mare: {maxValue1}");
            Console.WriteLine($"Prima valoare para cea mai mare: {maxValue2}");
            Console.WriteLine($"Prima valoare para cea mai mare: {maxValue3}");

        }

        public static void NumereAproapeZero()
        {
            int[] myArray = { 8, 3, 1, 9, -4, 7, 10, 3, 9 };

            int suma = 0;

            for(int i = 0; i < myArray.Length; i++)
            {
                for(int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] <= 0)
                    {
                        Console.WriteLine($"{myArray[i]} {myArray[j]}");
                    }
                }
            }
        }

        public static void DiferentaVectorilor()
        {
            int[] vector1 = { 7, 2, 12, 14, 35 };
            int[] vector2 = { 3, 4, 5, 6, 7 };
            List<int> list = new List<int>();

            if (vector1.Length != vector2.Length)
            {
                Console.WriteLine("Vectorii au lungimi diferite, nu se poate calcula diferenta.");
            }
            else
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    list.Add(vector1[i] - vector2[i]);
                }

                Console.WriteLine("Diferenta dintre vectori:");
                foreach (int element in list)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public static void IndexSubPrincipala()
        {
            int[,] myArray =
                { 
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };

            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                for(int j = 0;  j < myArray.GetLength(1); j++)
                {
                    if(i > j)
                    {
                        Console.WriteLine(myArray[i, j]);
                    }
                }
            }
        }
    }
}
