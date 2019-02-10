using System;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        double radius;

        public Circle(double radius =0) //생성자
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }

        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
    }

}
