using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public virtual double GetSalary()
    {
        return Salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
    }
}

public class Manager : Employee
{
    public string Department { get; set; }

    public override double GetSalary()
    {
        return base.GetSalary() * 1.15;
    }
}

public class SalesPerson : Employee
{
    public double SalesAmount { get; set; }

    public override double GetSalary()
    {
        return base.GetSalary() + SalesAmount * 0.03;
    }
}

public class Contractor : Employee
{
    public double WorkHours { get; set; }
    public int PayPerHour { get; set; }
    public Manager Responsible { get; set; }

    public override double GetSalary()
    {
        double salary = WorkHours * PayPerHour;
        Salary = salary;
        return salary;
    }

    public string CurrentPosition()
    {
        return Responsible.Department;
    }
}

public class CEO : Employee
{
    private double sharesPrice;

    public CEO(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public Employee[] Employees { get; set; }
    public int Shares { get; set; }

    public void AddSharesPrice(double price)
    {
        sharesPrice = price;
    }

    public void PrintEmployees()
    {
        Console.WriteLine("Employees:");
        foreach (Employee employee in Employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }
    }

    public override double GetSalary()
    {
        return Salary + Shares * sharesPrice;
    }
}

public class Program
{
    public static void Main()
    {
        Manager manager1 = new Manager { FirstName = "Bob", LastName = "Bobert", Salary = 1000, Department = "Sales" };
        Manager manager2 = new Manager { FirstName = "Rick", LastName = "Rickert", Salary = 1200, Department = "Marketing" };
        SalesPerson salesPerson = new SalesPerson { FirstName = "Mona", LastName = "Monalisa", Salary = 800, SalesAmount = 5000 };
        Contractor contractor1 = new Contractor { FirstName = "Igor", LastName = "Igorsky", Salary = 500, WorkHours = 40, PayPerHour = 12, Responsible = manager1 };
        Contractor contractor2 = new Contractor { FirstName = "Lea", LastName = "Leova", Salary = 600, WorkHours = 50, PayPerHour = 11, Responsible = manager2 };

        Employee[] employees = { manager1, manager2, salesPerson, contractor1, contractor2 };

        CEO ceo = new CEO("Boban", "Gocevski", 2000);
        ceo.Employees = employees;
        ceo.Shares = 1000;
        ceo.AddSharesPrice(1.3);

        ceo.PrintInfo();
        Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");
        ceo.PrintEmployees();
    }
}
