﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }


        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

    }
}
