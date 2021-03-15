using System;

namespace NumberInterface
{
    class Program
    {
        static void Main()
        {
            
            Number[] arrayNum = new Number[6];

            arrayNum[0] = new VeryLongNumber("12132");
            arrayNum[1] = new SimpleLongNumber(12132);
            arrayNum[2] = new VeryLongNumber("12132");
            arrayNum[3] = new SimpleLongNumber(12132);
            arrayNum[4] = new VeryLongNumber("12132");
            arrayNum[5] = new SimpleLongNumber(12132);

            for (int i = 1; i < arrayNum.Length; i++)
            {
                arrayNum[0] = arrayNum[0].add(arrayNum[i]);
            }

            Console.WriteLine(arrayNum[0].Value);
        }
    }
}
