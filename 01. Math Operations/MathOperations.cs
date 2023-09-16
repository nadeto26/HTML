﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int x, int y) => x + y;

        public double Add(double x, double y, double z) => x + y + z;

        public decimal Add (decimal x, decimal y, decimal z) => x + y + z;
        
    }
}
