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

            // Create a new array with only even elements
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

            // Resize the original array to match the size of the new array
            Array.Resize(ref array, newArray.Length);

            // Copy the contents of the new array back into the original array
            Array.Copy(newArray, array, newArray.Length);

            // Print the resulting array
            foreach (int value in array)
            {
                Console.Write(value + " ");

            }
            return array;
        }
        public void DoBlock2()
        {
            Console.WriteLine("Shpotak.DoBlock2() runs...");

        }
        public void DoBlock3()
        {
            Console.WriteLine("Shpotak.DoBlock3() runs...");

        }
        public void DoBlock4()
        {
            Console.WriteLine("Shpotak.DoBlock4() runs...");
        }
    }
}