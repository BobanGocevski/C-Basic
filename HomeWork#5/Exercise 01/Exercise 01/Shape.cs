using System;

class Shape
{
    private string _name;
    private string _color;
    public int[] Position { get; set; }

    public string Name
    {
        get { return _name; }
        set
        {
            Console.WriteLine($"Setting name to {value}.");
            _name = value;
        }
    }

    public string Color
    {
        get { return _color; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Color cannot be empty.");
            }
            else
            {
                Console.WriteLine($"Setting color to {value}.");
                _color = value;
            }
        }
    }

    public void getArea()
    {
        Console.WriteLine("There is no special implementation for area.");
    }

    public void getPerimeter()
    {
        Console.WriteLine("There is no special implementation for perimeter.");
    }

    public static void move(Shape shape)
    {
        shape.Position[0] += 5;
        shape.Position[1] += 5;
    }
}

class Rectangle : Shape
{
    public int SideA { get; set; }
    public int SideB { get; set; }

    public  void getArea()
    {
        Console.WriteLine($"Area of rectangle {Name} is {SideA * SideB}.");
    }

    public  void getPerimeter()
    {
        Console.WriteLine($"Perimeter of rectangle {Name} is {(SideA + SideB) * 2}.");
    }
}

class Circle : Shape
{
    public int Radius { get; set; }

    public  void getArea()
    {
        Console.WriteLine($"Area of circle {Name} is {Math.PI * Radius * Radius}.");
    }

    public void getPerimeter()
    {
        Console.WriteLine($"Circumference of circle {Name} is {2 * Math.PI * Radius}.");
    }
}
