using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples
{
    public sealed class Circle
    {
        private double radius = 5;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}
