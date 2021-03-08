using System;

namespace AnonimusMethod
{
    class Program
    {
        delegate int MyDelegate2();
        delegate double MyDelegate1(MyDelegate2[] a);
        static void Main()
        {
            int n = 6;

            MyDelegate1 myDelegate;

            myDelegate = delegate(MyDelegate2[] a) 
            {
                double sum = 0;

                foreach (var i in a)
                {
                    sum += i.Invoke();
                }

                return sum / a.Length;
            };

            var array = new MyDelegate2[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = AddNumber;
            }

            Console.WriteLine(myDelegate.Invoke(array));
        }

        static int AddNumber()
        {
            return new Random().Next(1, 100);
        }

    }
}
