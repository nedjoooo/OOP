using System;

namespace _1.Shapes.Shapes
{
    class Triangle : BasicShape
    {
        private int angle;
        public Triangle(double width, double height, int angle) : base (width, height)
        {

        }
        public int Angle
        {
            get { return this.angle; }
            set
            {
                if(value.Equals(null))
                {
                    throw new ArgumentNullException("Angel value can not be empty!");
                }
                this.angle = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height + Math.Sqrt(
                (this.Width * this.Width) + 
                (this.Height * this.Height) - 
                (2 * this.Height * this.Width * Math.Cos(this.Angle * Math.PI / 180)));
        }
    }
}
