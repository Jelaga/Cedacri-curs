using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AfisareSeparata();
            //Diapazon();
            //AdaugareaElementului();
            DeasupraDiagonalei();
        }

        public static void AfisareSeparata()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    Console.WriteLine(myArray[i]);
                }
                else
                    Console.WriteLine("\t" + myArray[i]);
            }
        }

        public static void Diapazon()
        {
            int[] myArray = { 2, -1, 6, 4, -3, 7, -2, 0, 9, 2 };
            int suma = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= -2 && myArray[i] <= 4)
                {
                    suma += myArray[i];
                }
            }

            Console.WriteLine($"Suma elementelor este: {suma}");

        }

        public static void AdaugareaElementului()
        {
            int[] myArray = { 54, 2, 6, 7, 8, 65, 21, 91 };
            int[] newArray = new int[myArray.Length + 1];

            Console.WriteLine("Introdu numarul pe care vrei sa adaugi:");
            int numar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdu pozitia:");
            int pozitie = Convert.ToInt32(Console.ReadLine());

            newArray[pozitie] = numar;

            for(int i = 0; i < pozitie; i++)
            {
                newArray[i] = myArray[i];
            }

            for(int i = pozitie; i < myArray.Length; i++)
            {
                newArray[i + 1] = myArray[i];
            }

            myArray = newArray;

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }

        public static void DeasupraDiagonalei()
        {
            int[,] myArray = 
            {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };
            
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                if (j > myArray.GetLength(0) - 1 - i)
                    {
                            Console.WriteLine(myArray[i, j] + " ");
                    }
                }
            }
        }
    }
}
