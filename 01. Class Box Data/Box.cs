using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp165
{
    public class Box
    {

        public Box(double lenght, double width, double height)
        {
            Length = lenght;
            Width = width;
            Height = height;
        }


        private double length;

        public double Length
        {
            get { return length; }
             set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Lenght cannot be zero or negative.");
                }
                length = value;
            }
        }

        private double width;

        public double Width
        {
            get { return width; }
             set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public  double LateralSurfaceArea()
        {
            return 2* length * height + 2* height * width;
        }

        public double Volume()
        {
            return length * width * height;
        }















    }
}
