using System;

namespace _1.Shapes.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;
        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if(value.Equals(null))
                {
                    throw new ArgumentNullException("Width can not be empty!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value.Equals(null))
                {
                    throw new ArgumentNullException("Height can not be empty!");
                }
                this.height = value;
            }
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
