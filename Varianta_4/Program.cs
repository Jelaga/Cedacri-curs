using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculNumarSuma();
            //MaximParImpar();
            StergereaValorii();
            //DiagonalaSecundara();
        }

        public static void CalculNumarSuma()
        {
            int[] myArray = { 1, -2, 4, -6, 7, -1, 3 };

            int numarPozitiv = 0;
            int numarNegativ = 0;
            int sumaPozitiv = 0;
            int sumaNegativ = 0;

            for(int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0)
                {
                    numarPozitiv++;
                    sumaPozitiv += myArray[i];
                }
                else
                {
                    numarNegativ++;
                    sumaNegativ += myArray[i];
                }
            }

            Console.WriteLine($"Numarul de elemente pozitive: {numarPozitiv}");
            Console.WriteLine($"Suma elementelor pozitive: {sumaPozitiv}");

            Console.WriteLine($"Numarul de elemente negative: {numarNegativ}");
            Console.WriteLine($"Suma elementelor negative: {sumaNegativ}");
            
        }

        public static void MaximParImpar()
        {
            int[] myArray = { 3, 4, 5, 8, 9, 1, 2, 7, 10, 0 };

            int valueParMaxim = myArray[0];
            int valueImparMaxim = myArray[0];

            for(int i = 0; i < myArray.Length;i++)
            {
                if (myArray[i] %2 == 0 && myArray[i] > valueParMaxim)
                {
                    valueParMaxim = myArray[i];
                }
                else if (myArray[i] %2 != 0 && myArray[i] > valueImparMaxim)
                {
                    valueImparMaxim = myArray[i];
                }
            }

            Console.WriteLine($"Valoarea para maxima: {valueParMaxim}");
            Console.WriteLine($"Valoarea impara maxima: {valueImparMaxim}");

        }

        public static void StergereaValorii()
        {
            int[] myArray = { 35, 30, 89, 76, 155, 123 };
            int[] newArray = new int[myArray.Length - 1];

            Console.WriteLine("Introdu indexul pe care vrei sa il stergi:");
            int index = Convert.ToInt32(Console.ReadLine());
             
            for(int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }

            for(int i = index + 1; i < myArray.Length; i++)
            {
                newArray[i - 1] = myArray[i];
            }

            myArray = newArray;

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        public static void DiagonalaSecundara()
        {
            int[,] myArray =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine(myArray[i, myArray.GetLength(0) - 1 - i]);   
            }
        }
    }
}
