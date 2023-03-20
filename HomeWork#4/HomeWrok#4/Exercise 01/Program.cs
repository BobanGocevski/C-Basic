using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's birthdate
            Console.Write("Enter your birthdate (MM/DD/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            // Calculate the user's age
            int age = AgeCalculator(birthdate);

            // Display the user's age
            Console.WriteLine("Your age is " + age + ".");
            Console.ReadLine();
        }

        static int AgeCalculator(DateTime birthdate)
        {
            // Calculate the difference between the birthdate and today's date
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            // Check if the user's birthday has already happened this year
            if (birthdate.Month > today.Month || (birthdate.Month == today.Month && birthdate.Day > today.Day))
            {
                age--;
            }

            return age;
        }
    }
}
