using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public class HTMLS : IMessS
    {
        public int value1 { get; private set; }
        public int value2 { get; private set; }
        public HTMLS()
        {
            Random rnd = new Random();
            (value1, value2) = (rnd.Next() % 10, rnd.Next() % 10);
        }


        public int Divide()
        {
            try
            {
                var divResult = value1 / value2;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }

        public int Mult()
        {
            return value1 * value2;
        }

        public int Substr()
        {
            return value1 - value2;
        }

        public int Summ()
        {
            return value1 + value2;
        }
    }
}
