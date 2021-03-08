using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInterface
{
    class Number : INumber
    {
        public SimpleLongNumber SimpleLong { get; set; }
        public VeryLongNumber VeryLong { get; set; }

        public int Value { get; set; }

        public Number(SimpleLongNumber number)
        {
            SimpleLong = number;
            Value = number.Value;
        }

        public Number(VeryLongNumber number)
        {
            VeryLong = number;
            Value = int.Parse(number.Value);
        }
        public Number(int n)
        {
            Value = n;
        }

        public Number() { }

        public Number add(Number number)
        {
            int res = Value + number.Value;
            return new Number(res);
        }

        public Number sub(Number number)
        {
            int resSub = Value - number.Value;
            if (resSub < 0)
                throw new NotNaturalNumberException("Число является не натуральным");
            else
                return new Number(resSub);
        }

        public int compareTo(Number number)
        {
            if (number.Value > Value)
                return 1;
            else if (number.Value == Value)
                return 0;
            else
                return -1;
        }
    }
}
