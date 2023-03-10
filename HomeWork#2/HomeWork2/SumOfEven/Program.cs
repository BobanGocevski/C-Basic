int[] numbers = new int [] { 1, 5, 8, 9, 10, 25, 40 };
int sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine($"The result is: {sum}");

