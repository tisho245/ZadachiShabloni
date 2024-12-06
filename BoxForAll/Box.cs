using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxForAll
{
    internal class Box<T>
    {
        private T value1;
        private List<T> values;
        public T Value 
        {
            get 
            {
                return value1; 
            }
            set 
            {
                value1 = value;
            }
        }
        public Box(T value2) 
        {
            this.Value = value2;
        }
        public void ToString()
        {
            Console.WriteLine($"{value1.GetType()}: {value1}");
        }
    }
}
