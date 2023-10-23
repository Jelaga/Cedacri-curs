using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndentificareaElemenului();
            //IndentificareaMaxElement();
            //NumarulDubluri();
            //ReuniuneaVectorilor();
            DiagonalaPrincipala();
        }

        public static void IndentificareaElemenului()
        {
            int[] myArray = { 3, 5, 8, 6, 2, 7, 10, 11 };

            int maxValue = myArray[0];
            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
                else if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
            }

            Console.WriteLine($"Valoarea minima din tabel este: {minValue}");
            Console.WriteLine($"Valoarea maxima din tabel este: {maxValue}");

        }

        public static void IndentificareaMaxElement()
        {
            int[] myArray = { 3, 4, 5, 8, 9, 1, 2, 7, 10, 0 };

            int maxValue1 = myArray[0];
            int maxValue2 = myArray[0];
            int maxValue3 = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
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
                else if (myArray[i] > maxValue3 && myArray[i] < maxValue1 && myArray[i] < maxValue2)
                {
                    maxValue3 = myArray[i];
                }
            }

            Console.WriteLine($"Primul element mai mare este: {maxValue1}");
            Console.WriteLine($"Al doilea element mai mare este: {maxValue2}");
            Console.WriteLine($"Al treilea element mai mare este: {maxValue3}");

        }

        public static void NumarulDubluri()
        {
            int[] myArray = { 45, 30, 45, 35, 67, 35, 30, 89, 90, 35 };

            for (int i = 0; i < myArray.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{myArray[i]}={count}");
            }
        }

        public static void ReuniuneaVectorilor()
        {
            int[] Array1 = { 2, 3, 1, 7 };
            int[] Array2 = { 3, 5, 8, 2, 4, 6 };
            int[] myArray = new int[Array1.Length + Array2.Length];

            for (int i = 0; i < Array1.Length; i++)
            {
                myArray[i] = Array1[i];
            }

            int count = Array1.Length;

            for (int i = 0; i < Array2.Length; i++)
            {
                bool existsInMyArray = false;

                for (int j = 0; j < count; j++)
                {
                    if (myArray[j] == Array2[i])
                    {
                        existsInMyArray = true;
                        break;
                    }
                }

                if (!existsInMyArray)
                {
                    myArray[count] = Array2[i];
                    count++;
                }
            }

            Array.Resize(ref myArray, count);

            foreach (int element in myArray)
            {
                Console.WriteLine(element + " ");
            }
        }

        public static void DiagonalaPrincipala()
        {
            int[,] myArray =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine(myArray[i,i]);
            }
        }
    }
}
