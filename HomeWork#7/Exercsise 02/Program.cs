class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Animal { Name = "Alex", Color = "Brown", Age = 7, Gender = Gender.Male },
            new Animal { Name = "Alice", Color = "Black", Age = 2, Gender = Gender.Female },
            new Animal { Name = "Anna", Color = "Brown", Age = 4, Gender = Gender.Female },
            new Animal { Name = "Archie", Color = "White", Age = 8, Gender = Gender.Male },
            new Animal { Name = "Albert", Color = "Brown", Age = 3, Gender = Gender.Male },
            new Animal {Name = "Anacondaaaa", Color = "White", Age = 10, Gender = Gender.Male },
        };

      
        var result1 = animals.Where(a => a.Age >= 5).Select(a => a.Name);
        Console.WriteLine("Animals aged 5 or more:");
        foreach (string name in result1)
        {
            Console.WriteLine(name);
        }

      
        var result2 = animals.Where(a => a.Name.StartsWith("A")).Select(a => a.Name);
        Console.WriteLine("Animals with names starting with 'A':");
        foreach (string name in result2)
        {
            Console.WriteLine(name);
        }

       
        var result3 = animals.Where(a => a.Gender == Gender.Male && a.Color == "Brown").Select(a => a.Name);
        Console.WriteLine("Male, brown animals:");
        foreach (string name in result3)
        {
            Console.WriteLine(name);
        }

       
        var result4 = animals.FirstOrDefault(a => a.Name.Length > 10);
        Console.WriteLine("First animal with a name longer than 10 characters:");
        if (result4 != null)
        {
            Console.WriteLine(result4.Name);
        }
    }
}