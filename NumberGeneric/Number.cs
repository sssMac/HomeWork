using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGeneric
{
    class Number<T>
    {
        public T Num { get; set; }
        public long Sum { get; set; }

        public Number(T num)
        {
            Num = num;
            Sum = Convert.ToInt64(num);
        }

        public Number(long a)
        {
            Sum = a;
        }

        public Number<T> Add(Number<T> n)
        {
            long res = Sum + n.Sum;
            return new Number<T>(res);
        }

        public Number<T> Sub(Number<T> n)
        {
            Exception NotNaturalNumberExeption = new Exception("Число не натуральное");
            if (n.Sum > Sum)
                throw NotNaturalNumberExeption;
            else
            {
                long res = Sum - n.Sum;
                return new Number<T>(res);
            }
        }

        public int CompareTo(Number<T> n)
        {
            if (n.Sum > Sum)
                return 1;
            else if (n.Sum < Sum)
                return -1;
            else
                return 0;
        }
    }
}
