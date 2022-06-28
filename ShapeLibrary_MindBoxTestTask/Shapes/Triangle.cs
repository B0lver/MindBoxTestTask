namespace ShapeLibrary_MindBoxTestTask.Shapes
{
    public class Triangle : Base.Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("One of the tringle's sides can't be less then 0.");
            if (2 * Math.Max(Math.Max(a, b), c) >= a + b + c)
                throw new ArgumentException("Can't make a triangle with largest side bigger then sum of other other two");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            double half_perimeter = (a + b + c)/ 2;
            double half_perimeter_subMembers = (half_perimeter - a) * (half_perimeter - b) * (half_perimeter - c);
            return Math.Sqrt(half_perimeter * half_perimeter_subMembers); ;
        }

        public bool IsRightAngle()
        {
            double Hypotenuse = Math.Max(Math.Max(a, b), c);
            return (2 * Hypotenuse * Hypotenuse == (a * a) + (b * b) + (c * c)); // 2 * Hypotenuse^2 == a^2 + b^2 + c^2
        }
    }
}
