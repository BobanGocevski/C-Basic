string sentence = "I send my homework`s too late, but I do my best";
string[] words = sentence.Split(' ');

string largestWord = "";
foreach (string word in words)
{
    if (word.Length > largestWord.Length)
    {
        largestWord = word;
    }
}

Console.WriteLine("Largest word: " + largestWord);
