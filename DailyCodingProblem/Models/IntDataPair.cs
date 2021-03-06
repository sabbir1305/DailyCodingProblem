using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Models
{
    public struct IntDataPair
    {
        public IntDataPair(int intValue, int intvalue2)
        {
            IntegerData = intValue;
            IntegerData2 = intvalue2;
        }

        public int IntegerData { get; private set; }
        public int IntegerData2 { get; private set; }
       
    }
}
