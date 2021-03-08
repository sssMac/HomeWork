using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInterface
{
    class VeryLongNumber : Number
    {
        public string Value { get; set; }

        public VeryLongNumber(string value)
        {
            Value = value;
        }

        public VeryLongNumber () { }


    }
}

