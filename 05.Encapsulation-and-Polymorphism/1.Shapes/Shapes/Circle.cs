using System;

namespace _1.Shapes.Shapes
{
    class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if(value.Equals(null))
                {
                    throw new ArgumentNullException("Radius can not be empty!");
                }
                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
        public double CalculatePerimeter()
        {
            return this.Radius * Math.PI * 2;
        }
    }
}
