using System;

namespace BasicClass // Ляпин Илья 11-012
{
    class Program
    {
        static void Main()
        {
            BaseClass n = new BaseClass();
            n[0, 0] = 5;
            n[0, 1] = 0;
            n[0, 2] = 4;
            n[1, 0] = 3;
            n[1, 1] = 123;
            n[1, 2] = 12;
            n[2, 0] = 89;
            n[2, 1] = 9;
            n[2, 2] = -123;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(n[i,j]);
                }
            }

        }
    }
}
