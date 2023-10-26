using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    /// <summary>
    /// Pair
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Pair<T, U>
    {

        public T Value { get; set; }
        public U Value2 { get; set; }


        /// <summary>
        /// Конструктор класса  Pair 2 параметр value и value2
        /// </summary>
        /// <param name="value"></param>
        /// <param name="value2"></param>
        public Pair(T value, U value2)
        {
            Value = value;

            Value2 = value2;
        }


        /// <summary>
        /// Меняет Значение переменых на оборот 
        /// </summary>
        public void Swap()
        {
            object value1 = Value;


            object value2 = Value2;

            Value = (T?)value2;

            Value2 = (U?)value1;

        }
    }
}
