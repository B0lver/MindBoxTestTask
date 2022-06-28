using ShapeLibrary_MindBoxTestTask.Shapes;
using ShapeLibrary_MindBoxTestTask.Shapes.Base;

List<Shape> shapes = new List<Shape>();

shapes.Add(new Circle(2));
shapes.Add(new Circle(14));
shapes.Add(new Triangle(7, 3, 5));
shapes.Add(new Triangle(3, 4, 5));

foreach (var shape in shapes)
{
    Console.WriteLine($"Shape's name: {shape.GetType().Name},\t shape's area: {shape.GetArea()}");
    if (shape.GetType() == typeof(Triangle))
    {
        Console.WriteLine($"\t Is right triangle : {(shape as Triangle).IsRightAngle()}");
    }
}