using System;


namespace Delegate
{
    class Program
    {
        public delegate double Calculation(double r);
        static void Main()
        {
            double r = 4;
            Calculation D = GetCircle;
            Calculation S = GetCircleArea;
            Calculation V = GetBallVolume;
            Console.WriteLine("D = " + D(r)+ "\n" + "S = " + S(r) + "\n" + "V = " + V(r));
            
        }

        static double GetCircle(double r)
        {
            return 2 * Math.PI * r;
        }

        static double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }

        static double GetBallVolume(double r)
        {
            return (4 / 3) * Math.PI * r * r * r;
        }
    }
}
