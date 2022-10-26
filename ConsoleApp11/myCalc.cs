using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_10._5
{
    public class myCalc : ISum
    {
        ILogger Logger { get; }

        public myCalc(ILogger logger)
        {

        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

    }
}
