using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInterface
{
    interface INumber
    {
        Number add(Number number);
        Number sub(Number number);
        int compareTo(Number number);
    }
}
