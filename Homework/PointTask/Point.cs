using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTask
{
    public class Point<T>
    {
        private T x, y;

        public T X
        {   get { return this.x; } 
            set { this.x = value; }
        }

        public T Y
        {
            get { return this.y; }
            set { this.y = value; }
        }


        public void Swap()
        {
            T temp = this.X;
            this.X = this.Y;
            this.Y = temp;
        }

        public double DistanceTo(Point<T> otherPoint)
        {
            double x1 = Convert.ToDouble(this.X);
            double y1 = Convert.ToDouble(this.Y);
            double x2 = Convert.ToDouble(otherPoint.X);
            double y2 = Convert.ToDouble(otherPoint.Y);

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static Point<double> Midpoint(Point<T> point1, Point<T> point2)
        {

            double x1 = Convert.ToDouble(point1.X);
            double y1 = Convert.ToDouble(point1.Y);
            double x2 = Convert.ToDouble(point2.X);
            double y2 = Convert.ToDouble(point2.Y);

            double midpointX = (x1 + x2) / 2;
            double midpointY = (y1 + y2) / 2;

            return new Point<double> { X = midpointX, Y = midpointY };
        }


    }
}
