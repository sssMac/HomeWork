using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClass // Ляпин Илья 11-012
{
    class BaseClass
    {
        private int[,] data { get; set; }

        public BaseClass()
        {
            data = new int[3,3];
        }

        

        public int this[int index1,int index2]
        {
            get
            {
                return data[index1,index2];
            }
            set
            {
                data[index1,index2] = value;
            }
        
        }




    }
}
