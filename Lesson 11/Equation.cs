using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    struct Equation
    {
        double k;
        double b;

        public Equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public void Root()
        {
            Console.WriteLine("0 = {0}*x-{1}", k, b);
            double x = b / k;
            Console.WriteLine("x = {0:f3}", x);
        }
    }
}
