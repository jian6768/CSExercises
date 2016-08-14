using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.###}",SQRT(inputNumber));


        }

        public static double SQRT(double x)
        {
            return Math.Sqrt(x);

        }
    }
}
