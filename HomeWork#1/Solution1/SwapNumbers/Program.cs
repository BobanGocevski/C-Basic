Console.WriteLine("Input the first number:");
string numb1 = Console.ReadLine();
int numby1 = int.Parse(numb1);
Console.WriteLine($"Before the swap the first number is equal to {numby1}");

Console.WriteLine("Input the second number:");
string numb2 = Console.ReadLine();
int numby2 = int.Parse(numb2);
Console.WriteLine($"Before the swap the first number is equal to {numby2}");

numby1 = numby1 + numby2;
numby2 = numby1 - numby2;
numby1 = numby1 - numby2;

Console.WriteLine($"After the swap the first number is equal to {numby1}");
Console.WriteLine($"After the swap the second number is equal to {numby2}");


Console.Read();
