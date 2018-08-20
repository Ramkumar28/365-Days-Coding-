using System;
using System.Collections.Generic;

namespace Aug_20_18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> _numbers = new []{3,4,7,9,10,15,12,19};
            FuncLearning.PrintTheNumber(_numbers, x=>(x/5) >1);
        }
    }
}
