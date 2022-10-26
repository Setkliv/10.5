using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_10._5
{
    public interface ILogger
    {
        void Event(string s);
        void Error(Exception e);


    }
}
