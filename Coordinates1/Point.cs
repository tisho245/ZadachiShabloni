using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates1
{
    public class Point<T>
    {
        private T x;
        private T y;
        public T X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public T Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Swap()
        {
            T temp = this.y;
            this.y = this.x;
            this.x = temp;
        }
        public double DistanceTo(Point<T> other)
        {
            double x1 = Convert.ToDouble(this.X);
            double y1 = Convert.ToDouble(this.Y);
            double x2 = Convert.ToDouble(other.X);
            double y2 = Convert.ToDouble(other.Y);
            return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

        }
        public void MidPoint(Point<T> other) 
        {
            double x1 = Convert.ToDouble(this.X);
            double y1 = Convert.ToDouble(this.Y);
            double x2 = Convert.ToDouble(other.X);
            double y2 = Convert.ToDouble(other.Y);
            Console.WriteLine($"{(x1+x2)/2}, {((y1+y2)/2)}");
        }

    }
}
