using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("Length : " + length);
            Console.WriteLine("Width : " + width);
            Console.WriteLine("Area : " + GetArea());
        }
    }
}
