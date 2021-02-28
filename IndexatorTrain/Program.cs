using System;

namespace IndexatorTrain
{
    class Program 
    {
        static void Main()
        {

            string nameTrain;

            DateTime timeS = default; DateTime timeE = default;


            //Название поезда
            Console.Write("Введите название поезда : "); nameTrain = Console.ReadLine();

            //Количество вагонов
            Console.Write("Количество вагонов : "); int count = CountOfWagon();

            //Место назначение
            Console.Write("Место назначения : "); string dest = Console.ReadLine();

            //Время отправления и прибытия
            OperationTime(ref timeS, ref timeE);

            Train train = new Train(dest, nameTrain, timeS, timeE, count);

            train.TrainInfo(train);

        }

        private static void OperationTime(ref DateTime timeS, ref DateTime timeE)
        {
            int k = 0;
            while (k != 2)
            {
                if (k == 0)
                    Console.Write("Время отправления: ");
                else
                    Console.Write("Время прибытия: ");
                string[] txt = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (k == 0)
                {
                    timeS = new DateTime(2020, 2, 20, int.Parse(txt[0]), int.Parse(txt[1]), 0);
                    k++;
                }
                else if (k == 1)
                {
                    timeE = new DateTime(2020, 2, 21, int.Parse(txt[0]), int.Parse(txt[1]), 0);
                    k++;
                }

            }
        }

        private static int CountOfWagon()
        {
            int count;
            while (true)
            {
                try
                {
                    count = int.Parse(Console.ReadLine());
                    break;
                }
                catch { }
            }

            return count;
        }
    }
}
