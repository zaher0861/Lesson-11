using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число k:");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k, b);
            equation.Root();
            Console.ReadKey();
        }
    }


}
