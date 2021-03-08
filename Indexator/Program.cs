using System;

namespace Indexator // Ляпин Илья 11-012
{
    class Program
    {
        static void Main()
        {
            BaseClass n = new BaseClass(3, 3);
            n[0, 0] = 5;
            n[0, 1] = 0;
            n[0, 2] = 4;
            n[1, 0] = 3;
            n[1, 1] = 3;
            n[1, 2] = 2;
            n[2, 0] = 9;
            n[2, 1] = 9;
            n[2, 2] = 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(n[i, j]);
                }

                Console.WriteLine();
            }

            n[1] = new int[] { 2, 2, 8 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(n[i, j]);
                }

                Console.WriteLine();
            }

            foreach (var item in n[2])
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
