/*
 Create new console application “RealCalculator” that takes two numbers from the input and asks what 
operation would the user want to be done ( +, - , * , / ). Then it returns the result.

Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the Operation: +
Expected Output:
The result is: 25
 */

Console.WriteLine("Please enter your  operation:");
string operation = Console.ReadLine();

if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
{
    Console.WriteLine("Invalid operation selected!!!");
    System.Environment.Exit(1);


}

Console.WriteLine("Enter the First number:");
string numberOne = Console.ReadLine();
int number1 = int.Parse(numberOne);

Console.WriteLine("Enter the second number:");
string numberTwo = Console.ReadLine();
int number2 = int.Parse(numberTwo);

if (operation == "+")
{
    Console.WriteLine($"The result is: {number1 + number2}");
}
else if (operation == "-")
{
    Console.WriteLine($"The result is: {number1 - number2}");
}
else if (operation == "*")
{
    Console.WriteLine($"The result is: {number1 * number2}");
}
else if (operation == "/")
{
    Console.WriteLine($"The result is: {number1 / number2}");
}

Console.Read();
