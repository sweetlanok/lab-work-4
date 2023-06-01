using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabWork4
{
    public class Shpotak : BaseTaskInterface
    {
        public void DoBlock1(int[]? array)
        {
            Console.WriteLine("Shpotak.DoBlock1() runs...");
            int[] res = RemoveElementsFromArray(array);
            Console.WriteLine(res + " ");
        }
        static int[] RemoveElementsFromArray(int[] array)
        {
            int count = 0;
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    count++;
                }
            }

            int[] newArray = new int[count];
            int index = 0;
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    newArray[index] = value;
                    index++;
                }
            }

            Array.Resize(ref array, newArray.Length);

            Array.Copy(newArray, array, newArray.Length);

            foreach (int value in array)
            {
                Console.Write(value + " ");

            }
            return array;
        }
        public void DoBlock2(int[][]? array)
        {
            Console.WriteLine("Shpotak.DoBlock2() runs...");
            int[][] res = DeleteEvenRows(array);
            Console.WriteLine(res + " ");
        }


        static int[][] DeleteEvenRows(int[][] jaggedArray)
        {
            int rowCount = jaggedArray.Length;
            int[][] updatedArray = new int[rowCount][];
            int updatedRowCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                if (i % 2 == 0)
                {
                    updatedArray[updatedRowCount] = jaggedArray[i];
                    updatedRowCount++;
                }
            }

            Array.Resize(ref updatedArray, updatedRowCount);

            return updatedArray;
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            foreach (int[] row in jaggedArray)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
        public void DoBlock3(int[][]? array)
        {
            Console.WriteLine("Shpotak.DoBlock3() runs...");
            int[] res = SortAndInvert(array);
            Console.WriteLine(res + " ");
        }
        static int[] SortAndInvert(int[][] matrix)
        {

            Array.Sort(matrix, (x, y) => x.Length.CompareTo(y.Length));

            int totalRows = matrix.Length;
            int[] resultArray = new int[totalRows];


            for (int i = 0; i < totalRows; i++)
            {
                int[] row = matrix[i];
                int maxElement = row[0];

                for (int j = 1; j < row.Length; j++)
                {
                    if (row[j] > maxElement)
                    {
                        maxElement = row[j];
                    }
                }

                resultArray[i] = maxElement;
            }


            Array.Reverse(resultArray);

            return resultArray;
        }

        public void DoBlock4()
        {
            Console.WriteLine("Shpotak.DoBlock4() runs...");
        }
    }
}