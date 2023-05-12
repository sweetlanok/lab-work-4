using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabWork4
{
    public class Vasilchenko : BaseTaskInterface
    {
        public void DoBlock1(int[] array)
        {
            Console.WriteLine("Vasilchenko.DoBlock1() runs...");
            DefineenMinAndMaxValuesInArray(array);
        }


        static void DefineenMinAndMaxValuesInArray(int[] array)
        {
            int max = int.MinValue, min = int.MaxValue;
            int maxIndex = 0, minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] <= min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            int start = Math.Min(maxIndex, minIndex);
            int end = Math.Max(maxIndex, minIndex);
            Console.WriteLine(start);
            Console.WriteLine(end);


            RemoveElementsBetweenMinAndMaxValues(array, start, end);
        }

        static void RemoveElementsBetweenMinAndMaxValues(int[] array, int minIndex, int maxIndex)
        {

            int newArrayLength = array.Length - GetCountOfRemovedElements(array, minIndex, maxIndex);
            int[] newArray = new int[newArrayLength];
            int newArrayIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < minIndex || i > maxIndex)
                {
                    newArray[newArrayIndex] = array[i];
                    newArrayIndex++;
                }
            }

            Array.Resize(ref array, newArrayLength);
            Array.Copy(newArray, array, newArrayLength);
            Console.WriteLine($"Result: {String.Join(", ", newArray)}");

        }

        static int GetCountOfRemovedElements(int[] array, int minIndex, int maxIndex)
        {
            int countRemovedElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i >= minIndex && i <= maxIndex)
                {
                    countRemovedElement++;

                }
            }
            return countRemovedElement;
        }


        public void DoBlock2()
        {
            Console.WriteLine("Vasilchenko.DoBlock2() runs...");

        }
        public void DoBlock3()
        {
            Console.WriteLine("Vasilchenko.DoBlock3() runs...");

        }
        public void DoBlock4()
        {
            Console.WriteLine("Vasilchenko.DoBlock4() runs...");

        }
    }
}