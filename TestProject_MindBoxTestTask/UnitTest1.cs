using ShapeLibrary_MindBoxTestTask.Shapes;
namespace TestProject_MindBoxTestTask
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Test_Triangle_Area()
        {
            Triangle triangle = new Triangle(5, 4, 8);
            Assert.AreEqual(8.181534085976786, triangle.GetArea());
        }
        [TestMethod]
        public void Test_TrueRightTriangle_Check()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngle());
        }
        [TestMethod]
        public void Test_FalseRightTriangle_Check()
        {
            Triangle triangle = new Triangle(4, 4, 5);
            Assert.IsFalse(triangle.IsRightAngle());
        }
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Test_OneUnitRadiusCircle_Area()
        {
            Circle circle = new Circle(1);
            Assert.AreEqual(Math.PI, circle.GetArea());
        }
    }
}