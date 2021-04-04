using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 4, 45, 6, 34 };
            int[] b = new int[] { 45, 5 , 64};

            MyList<int> test1 = new MyList<int>(a);
            MyList<int> test2 = new MyList<int>(a);

            test1.Add(8);

            Console.WriteLine("Прибавить число");
            foreach (var res in test1.Mas)
            {
                Console.Write(res + " ");
            }

            test2.AddRange(b);

            Console.WriteLine("\nПрибавить массив");
            foreach (var res in test2.Mas)
            {
                Console.Write(res + " ");
            }

            Console.WriteLine("\nУзнать индекс");
            Console.WriteLine("\n"+test2.IndexOf(45));
            Console.WriteLine(test2.IndexOf(12));


            test2.Insert(4, 1337);
            Console.WriteLine("\nВставить число на 1337 на 4 индекс");
            foreach (var res in test2.Mas)
            {
                Console.Write(res + " ");
            }

            test2.Remove(45);
            Console.WriteLine("\nУдалить элемент 45");
            foreach (var res in test2.Mas)
            {
                Console.Write(res + " ");
            }

            test2.RemoveAt(3);
            Console.WriteLine("\nУдалить элемент 3-го индекса");
            foreach (var res in test2.Mas)
            {
                Console.Write(res + " ");
            }

            test2.Sort();
            Console.WriteLine("\nСортировка");
            foreach (var res in test2.Mas)
            {
                Console.Write(res + " ");
            }

        }


    }
}
