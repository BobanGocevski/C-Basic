using DogA;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the dog's name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the dog's breed: ");
        string breed = Console.ReadLine();
        Console.Write("Enter the dog's color: ");
        string color = Console.ReadLine();

        Dog myDog = new Dog
        {
            Name = name,
            Breed = breed,
            Color = color
        };

       
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Eat");
        Console.WriteLine("2. Play");
        Console.WriteLine("3. Chase Tail");
        int option = int.Parse(Console.ReadLine());

    
        switch (option)
        {
            case 1:
                myDog.Eat();
                break;
            case 2:
                myDog.Play();
                break;
            case 3:
                myDog.ChaseTail();
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }

        Console.ReadLine();
    }
}





