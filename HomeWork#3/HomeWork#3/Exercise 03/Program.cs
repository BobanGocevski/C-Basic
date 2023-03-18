//Create a function that takes a number as input. 
//This method should return the sum of the digits in the number.
int SumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int digit = num % 10;
        sum += digit;
        num /= 10;
    }
    return sum;
}


int num = 456789;
int sum = SumOfDigits(num);
Console.WriteLine(sum); 
