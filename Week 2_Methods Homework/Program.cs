using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Methods_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            FavoriteFood("Brian", "Pasta");
            Console.WriteLine("Please enter your age to figure out how long until you retire.");
            RetirementCalculator(0);
            Console.WriteLine("Your monthly wage is $" + WageCalculator(10, 8.75));
        }

        public static void FavoriteFood(string myName, string favFood)
        {
            Console.WriteLine(myName + " " + favFood);
            return;
        }

        public static void RetirementCalculator(int userAge)
        {
            userAge = int.Parse(Console.ReadLine());
            int retirementAge = 65 - userAge;
            Console.WriteLine("The user will retire in " + retirementAge + " years.");
            return;
        }

        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWage = hoursWorked * hourlyWage;
            return monthlyWage;
        }

    }
}
