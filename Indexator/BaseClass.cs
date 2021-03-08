using System;
using System.Collections.Generic;
using System.Text;

namespace Indexator // Ляпин Илья 11-012
{
    class BaseClass
    {
        private int[,] data { get; set; }
        private int[] data1 { get; set; }

        public BaseClass(int x, int y)
        {
            data = new int[x, y];
        }

        public int[] this[int colIndex]
        {
            get
            {
                if (colIndex > data.GetLength(1))
                    throw new IndexOutOfRangeException("");

                var array = new int[data.GetLength(1)];

                for (int i = 0; i < data.GetLength(1); i++)
                {
                    array[i] = data[i, colIndex];
                }

                return array;
            }
            set
            {
                if (colIndex > data.GetLength(1))
                    throw new IndexOutOfRangeException("");

                for (int i = 0; i < value.Length; i++)
                {
                    data[i, colIndex] = value[i];
                }
            }

        }

        public int this[int x, int y]
        {
            get
            {
                return data[x, y];
            }
            set
            {
                data[x, y] = value;
            }
        }
    }
}
