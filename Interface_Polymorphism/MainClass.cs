namespace Interface_Polymorphism
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Circle();
            shapes[1] = new Square();
            shapes[2] = new Rectangle();
            foreach (IShape s in shapes)
            {
                s.draw();
            }
        }
    }
}