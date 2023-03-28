Rectangle rect = new Rectangle();
rect.Name = "Rectangle";
rect.Color = "Blue";
rect.Position = new int[] { 0, 0 };
rect.SideA = 5;
rect.SideB = 3;

Circle circle = new Circle();
circle.Name = "Circle";
circle.Color = "Green";
circle.Position = new int[] { 10, 10 };
circle.Radius = 4;

Shape.move(rect);
Shape.move(circle);

Console.WriteLine($"Rectangle - Name: {rect.Name}, Color: {rect.Color}, Position: ({rect.Position[0]}, {rect.Position[1]}), SideA: {rect.SideA}, SideB: {rect.SideB}");
rect.getArea(); 
rect.getPerimeter(); 

Console.WriteLine($"Circle - Name: {circle.Name}, Color: {circle.Color}, Position: ({circle.Position[0]}, {circle.Position[1]}), Radius: {circle.Radius}");
circle.getArea(); 
circle.getPerimeter(); 
