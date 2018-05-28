using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.Algorithms.math.fibonacci
{
    public static class Fibonacci
    {
        public static int GetNumberAtPosition(int position)
        {
            if (position <= 0)
                throw new ArgumentException("Position must be greater than 0");
            if(position == 1)
            {
                return 1;
            }
            var iterations = position - 1;

            int ret = 0;
            int prev = 1;
            int prevPrev = 0;

            while(iterations > 0)
            {
                ret = prev + prevPrev;
                prevPrev = prev;
                prev = ret;
                iterations--;
            }

            return ret;
        }
    }
}
