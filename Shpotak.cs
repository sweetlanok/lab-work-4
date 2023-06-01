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
            PrintJaggedArray(res);
        }


        static int[][] DeleteEvenRows(int[][] jaggedArray)
        {
            int rowCount = jaggedArray.Length;
            int[][] result = new int[rowCount / 2][];

            int index = 0;
            for (int i = 0; i < rowCount; i++)
            {
                if (i % 2 != 0)
                {
                    result[index] = jaggedArray[i];
                    index++;
                }
            }

            return result;
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }


        public void DoBlock3(int[][]? array)
        {
            Console.WriteLine("Shpotak.DoBlock3() runs...");
            int[] res = SortAndInvertJaggedArray(array);
            foreach (int num in res)
            {
                Console.Write(num + " ");
            }
        }


        public static int[] SortAndInvertJaggedArray(int[][] jaggedArray)
        {

            foreach (int[] row in jaggedArray)
            {
                Array.Sort(row);
            }


            int[] largestElements = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] row = jaggedArray[i];
                largestElements[i] = row[row.Length - 1];
            }
            Array.Sort(largestElements);
            Array.Reverse(largestElements);

            return largestElements;
        }
    }
}