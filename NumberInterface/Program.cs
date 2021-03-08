using System;

namespace NumberInterface
{
    class Program
    {
        static void Main()
        {
            
            Number[] arrayNum = new Number[10];

            arrayNum[0] = new Number("12132");

            for (int i = 1; i < arrayNum.Length; i++)
            {
                arrayNum[0] = arrayNum[0].add(arrayNum[i]);
            }

            Console.WriteLine(arrayNum[0]);
        }
    }
}
