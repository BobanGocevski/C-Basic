//Take one string from the input and print its last 5 characters.

string input = "Hello World";
string lastFiveChars = input.Substring(input.Length - 5);
Console.WriteLine(lastFiveChars);