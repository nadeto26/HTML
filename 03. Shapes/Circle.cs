﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double  Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
             
        }

        public  override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override double CalculateArea()
        {
           return  Math.PI* this.Radius * this.Radius;
        }
    }
}
