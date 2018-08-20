using System;
using System.Collections.Generic;

namespace Aug_20_18_2
{
    public class FuncLearning
    {
        public static void PrintTheNumber(IEnumerable<int> _listOfNumbers, Func<int,bool> _numberParser)
        {
            foreach(var i in _listOfNumbers)
            {
                if(_numberParser(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}