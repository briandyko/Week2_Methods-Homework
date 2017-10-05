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


            //FavoriteFood("Brian", "Pasta");
            //FavoriteFood("Beth", "Apples");
            //FavoriteFood("Kenneth", "Pizza");

            //RetirementCalculatorB(100);


            //Console.WriteLine("Please enter your age to figure out how long until you retire.");



            //RetirementCalculator(100);

            // below is user input WageCalculator()

            //double hours;
            //double wage;
            //Console.WriteLine("What is your # of hours?");
            //hours = double.Parse(Console.ReadLine());
            //Console.WriteLine("What is your hourly rate?");
            //wage = double.Parse(Console.ReadLine());
        
            Console.WriteLine("Your monthly wage is $" + WageCalculator(15.2, 95.30));

            string wins;
            string losses;

            Console.WriteLine("How many games do you think the Tribe will win this post season?");
            wins = Console.ReadLine();

            Console.WriteLine("How many games do you think the Tribe will lose this post season?");
            losses = Console.ReadLine();

            PostSeason(wins, losses);
            

        }

        public static void FavoriteFood(string myName, string favFood)
        {
            Console.WriteLine("********************************");
            Console.WriteLine(myName + " loves " + favFood);
            Console.WriteLine();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            return;
        }


        //this is the way I did RetirementCalculator
        public static void RetirementCalculator(int userAge)
        {
            //userAge = int.Parse(Console.ReadLine());
            int retirementAge = 65 - userAge;
            Console.WriteLine("The user will retire in " + retirementAge + " years.");
            return;
        }

        //this is the way we did it in Class

        public static void RetirementCalculatorB(int age)
        {
            int retirementAge = Math.Max(0, 65 - age);

            Console.WriteLine("The user will retire in " + retirementAge+ " years");
        }
         
        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWage = hoursWorked * hourlyWage;
            return monthlyWage;
        }

        public static void PostSeason(string gamesWon, string gamesLost)
        {
          Console.WriteLine("The Tribe's Post Season record is " + " " + gamesWon + "-" + gamesLost);
            
        }
    }
}
