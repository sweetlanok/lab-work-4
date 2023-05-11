using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabWork4
{
    public class Vasilchenko : BaseTaskInterface
    {
        public void DoBlock1(int[]? array)
        {
            Console.WriteLine("Vasilchenko.DoBlock1() runs...");
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