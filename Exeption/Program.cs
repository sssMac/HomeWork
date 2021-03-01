using System;

namespace Exeption
{
    class PersonExeption : Exception
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMethod(0, 1);

            int[] array = new int[10];
            //SimpleMethod(array);

            int a = 0;
            SimpleMethod(a);

            SimpleMethod();

            PersonExeption("коля");
        }

        static void SimpleMethod(int x, int y)
        {

            try
            {
                Console.WriteLine(y / x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль");
            }
        }

        static void SimpleMethod(int a)
        {
            try
            {
                a = int.Parse(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Аргумент null");
            }
        }

        static void SimpleMethod(int[] array)
        {
            array[11] = 0;
        }

        static void SimpleMethod()
        {
            object value = 12;
            string s = (string)value;
        }

        static void PersonExeption(string name)
        {
            try
            {
                try
                {
                    if (Char.IsLetter(name[0]))
                        throw new Exception();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Имя с маленькой буквы");
            }

        }
    }
}
