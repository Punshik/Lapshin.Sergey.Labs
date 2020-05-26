using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public interface IMessS
    {
        int value1 { get; }
        int value2 { get; }
        int Summ();
        int Substr();
        int Divide();
        int Mult();
    }
}
