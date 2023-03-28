using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public double Salary { get; protected set; }

    public Employee(string name, int age, string department)
    {
        Name = name;
        Age = age;
        Department = department;
    }

    public virtual double GetSalary()
    {
        return Salary;
    }
}

class Contractor : Employee
{
    public double WorkHours { get; set; }
    public int PayPerHour { get; set; }
    public Employee Responsible { get; set; }

    public Contractor(string name, int age, string department, double workHours, int payPerHour, Employee responsible)
        : base(name, age, department)
    {
        WorkHours = workHours;
        PayPerHour = payPerHour;
        Responsible = responsible;
    }

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

class Program
{
    static void Main(string[] args)
    {
        Employee manager = new Employee("John Smith", 40, "Marketing");
        Contractor contractor = new Contractor("Jane Doe", 25, "Marketing", 40, 20, manager);

        Console.WriteLine("Contractor Name: " + contractor.Name);
        Console.WriteLine("Contractor Age: " + contractor.Age);
        Console.WriteLine("Contractor Department: " + contractor.Department);
        Console.WriteLine("Contractor Work Hours: " + contractor.WorkHours);
        Console.WriteLine("Contractor Pay Per Hour: " + contractor.PayPerHour);
        Console.WriteLine("Contractor Responsible Manager: " + contractor.Responsible.Name);
        Console.WriteLine("Contractor Salary: " + contractor.GetSalary());
        Console.WriteLine("Contractor Current Position: " + contractor.CurrentPosition());
    }
}
