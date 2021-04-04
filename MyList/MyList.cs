using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyList<T>
    { 
        public T[] Mas { get; set; }


        public MyList()
        {
            Mas = new T[1];
            int Length = Mas.Length;
        }

        public MyList(T[] mas)
        {
            Mas = mas;
            int Length = Mas.Length;
        }

        public void Add(T item)
        {
            int last = Mas.Length;
            Increase();
            Mas[last] = item;
        }

        public void AddRange(T[] collection)
        {
            var res = new T[Mas.Length + collection.Length];
            int indexCollect = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (i < Mas.Length)
                {
                    res[i] = Mas[i];
                }
                else
                {
                    res[i] = collection[indexCollect];
                    indexCollect++;
                }
            }
            Mas = res;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            var res = new T[Mas.Length + 1];
            int indexMas = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (i == index)
                {
                    res[i] = item;
                }
                else
                {
                    res[i] = Mas[indexMas];
                    indexMas++;
                }
            }
            Mas = res;
        }

        public bool Remove(T item)
        {
            int countItem = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].Equals(item))
                    countItem++;
            }

            var res = new T[Mas.Length - countItem];

            int indexRes = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].Equals(item))
                {
                    countItem--;
                    continue;
                }
                else
                {
                    res[indexRes] = Mas[i];
                    indexRes++;
                }
            }
            Mas = res;
            if (countItem == 0)
                return true;
            else
                return false;
        }

        public void RemoveAt(int index)
        {
            var res = new T[Mas.Length - 1];

            int indexRes = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                res[indexRes] = Mas[i];
                indexRes++;
            }
            Mas = res;
        }

        public void Sort()
        {
            Array.Sort<T>(Mas, 0, Mas.Length);
        }

        private void Increase()
        {

            var increace = new T[Mas.Length +1];
                for (int i = 0; i < Mas.Length; i++)
                {
                    increace[i] = Mas[i];
                }
            Mas = increace;
        }

    }
}
