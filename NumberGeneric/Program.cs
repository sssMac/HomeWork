using System;

namespace NumberGeneric
{
    class Program
    {
        static void Main()
        {
            Number<long>[] num = new Number<long>[5];

            num[0] = new Number<long>(0);
            num[1] = new Number<long>(8);
            num[2] = new Number<long>(123);
            num[3] = new Number<long>(45);
            num[4] = new Number<long>(13);

            for (int i = 1; i < 5; i++)
            {
                num[0] = num[0].Add(num[i]);
            }
            Console.WriteLine($"Сумма элементов = {num[0].Sum}");


            num[0] = num[1].Add(num[3]);
            Console.WriteLine(num[0].Sum);

            //num[0] = num[1].Sub(num[3]);      // Этот тест выводит NotNaturalNumberExeption.
            Console.WriteLine(num[0].Sum);

            num[0] = num[2].Sub(num[3]);
            Console.WriteLine(num[0].Sum);

            Console.WriteLine(num[3].CompareTo(num[4]) + "\n\n");



            var snum = new Number<string>("0");
            var snum1 = new Number<string>("8");
            var snum2 = new Number<string>("123");
            var snum3 = new Number<string>("45");
            var snum4 = new Number<string>("13");
            snum = snum1.Add(snum3);
            Console.WriteLine(snum.Sum);

            //snum = snum1.Sub(snum3);      // Этот тест выводит NotNaturalNumberExeption.
            Console.WriteLine(snum.Sum);

            snum = snum2.Sub(snum3);
            Console.WriteLine(snum.Sum);

            Console.WriteLine(snum3.CompareTo(snum4));
        }
    }
}
