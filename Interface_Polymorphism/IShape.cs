using System;


namespace Interface_Polymorphism
{
    interface IShape
    {
        void draw();
    }
    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

}
