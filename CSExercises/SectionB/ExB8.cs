using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            double inputDistance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:#.0}", Math.Round(CalculateFare(inputDistance),1));
        }
       

        public static double CalculateFare(double distance)
        {
            return 2.4 + 0.4 * distance;

        }
    }
}
