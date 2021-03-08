using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInterface
{
    class SimpleLongNumber : Number
    {
        public int Value { get; set; }

        public SimpleLongNumber(int value)
        {
            Value = value;
        }

        public SimpleLongNumber() { }
    }
}

