//Take a sentence as input and print its words.

string sentence = "I send my homework`s too late, but I do my best .";
string[] words = sentence.Split(' ');
foreach (string word in words)
{
    Console.WriteLine(word);
}
