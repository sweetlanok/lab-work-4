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