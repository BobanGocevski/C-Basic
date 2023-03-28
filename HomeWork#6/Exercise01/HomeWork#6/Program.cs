using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> numbers = new Queue<int>();
        bool inputting = true;

        while (inputting)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Enqueue(num);

            Console.Write("Do you want to enter another number? (Y/N): ");
            string answer = Console.ReadLine().ToUpper();
            if (answer != "Y")
            {
                inputting = false;
            }
        }

        Console.WriteLine("Numbers entered in order: ");
        while (numbers.Count > 0)
        {
            Console.WriteLine(numbers.Dequeue());
        }
    }
}
