using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInterface
{

    class SimpleLongNumber : INumber
    {
        public int Value { get; set; }

        public SimpleLongNumber(int value)
        {
            Value = value;
        }

        public SimpleLongNumber() { }

        public Number add(Number number)
        {
            throw new NotImplementedException();
        }

        public Number sub(Number number)
        {
            throw new NotImplementedException();
        }

        public int compareTo(Number number)
        {
            throw new NotImplementedException();
        }
    }
}

