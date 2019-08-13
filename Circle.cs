﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_ShapeMgmt
{
    public class Circle:Dimensions
    {
        public Circle(int x, int y):base(x,y)
        { }
        public override double Area()
        {
            return Math.PI * X * X;
        }
    }
}
