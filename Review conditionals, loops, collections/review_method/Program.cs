//chase blackmore
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_method
{
    class Program
    {
        //static double sum = 0;  //class level variable for homework?? 
        static void Main(string[] args)
        {
            double result=Addition(5.5,2);
            Console.WriteLine(result);
            Console.ReadKey();
            double val1 = 10.5;
            double val2 = 1.5;
            subtraction(val1, val2);
        }

        private static void subtraction(double val1, double val2)
        {
            Console.WriteLine($"{val1 - val2}");
        }

        static double Addition(double value1, double value2)
        {
            double sum = value1 + value2;
            return sum;

        }
    }
}
