using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabWork4
{
    public interface BaseTaskInterface
    {
        void DoBlock1(int[]? array);
        void DoBlock2(int[][]? array);
        void DoBlock3(int[][]? array);
        void DoBlock4();

    }
}