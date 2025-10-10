using System;

namespace Abstraction
{
    internal class Rectangle : Figure
    {
        private double width;
        private double height;

        public double Width
        {
            get 
            { 
                return width; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value of the width must be positive!");
                }
                
                width = value; 
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value of the height must be positive!");
                }

                height = value;
            }
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
