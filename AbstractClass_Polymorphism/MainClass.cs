namespace AbstractClass_Polymorphism
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Square();
            shapes[2] = new Rectangle();
            foreach (Shape s in shapes)
            {
                s.draw();
            }
        }
    }
}