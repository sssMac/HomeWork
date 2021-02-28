using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace IndexatorTrain // Ляпин Илья 11-012
{
    class Train
    {
        private string Wey { get; set; }
        private string NameTrain { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public TimeSpan TimeWey { get; set; }

        public int Wagon { get; set; }


        public Train(string wey, string name, DateTime start, DateTime end, int wagon)
        {
            Wey = wey;
            NameTrain = name;
            TimeStart = start;
            TimeEnd = end;
            TimeWey = CalculateTime(TimeStart, TimeEnd);
            Wagon = wagon;
        }

        public void TrainInfo(Train train)
        {
            Console.Clear();
            Console.WriteLine("Поезд №" + train.NameTrain + " Вагон(ов) : " + train.Wagon + "\n" +
                "Пункт назначения : " + train.Wey + "\n" +
                "Отправление : " + train.TimeStart + "\n" +
                "Прибытие : " + train.TimeEnd + "\n" +
                "Время пути : " + train.TimeWey);
        }

        static TimeSpan CalculateTime(DateTime ts, DateTime te)
        {
            TimeSpan interval = te - ts;

            return interval;
        }

    }
}
