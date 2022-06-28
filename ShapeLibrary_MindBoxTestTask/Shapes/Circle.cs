namespace ShapeLibrary_MindBoxTestTask.Shapes
{
    public class Circle : Base.Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * (radius * radius); // Pi * R^2
        }
    }
}
