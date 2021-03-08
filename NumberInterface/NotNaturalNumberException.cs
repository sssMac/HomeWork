using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInterface
{
    class NotNaturalNumberException : Exception
    {
        public NotNaturalNumberException(string message)
        : base(message)
        { }
    }
}
