using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Pair<T, U>
    {

        public T Value { get; set; }
        public U Value2 { get; set; }

        public Pair(T value, U value2)
        {
            Value = value;

            Value2 = value2;
        }

        public void Swap()
        {
            object value1 = Value;


            object value2 = Value2;

            Value = (T?)value2;

            Value2 = (U?)value1;

        }
    }
}
