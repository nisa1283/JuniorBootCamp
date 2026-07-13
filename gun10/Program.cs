using gun10;

IShape rect = new Rectangle(5, 10);
IShape square = new Square(5);

List<IShape> shapes = new List<IShape>();

shapes.Add(rect);
shapes.Add(square);

foreach (var shape in shapes)
{
    Console.WriteLine(shape.Area());
}
