using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            double inputDistance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:#.0}", Math.Ceiling(CalculateFare(inputDistance)*10)/10);
        }

        public static double CalculateFare(double distance)
        {

            return 2.4 + 0.4 * distance;

        }
    }
}
