﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            string salary = Console.ReadLine();
            Console.WriteLine("{0:c}",CalculateIncome(salary));


        }

        public static double CalculateIncome(string salaryStr)
        {
            double salary = Convert.ToDouble(salaryStr);
            return 1.13*salary;
        }
    }
}
