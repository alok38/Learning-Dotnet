using System;


namespace AbstractClass_Polymorphism
{
    abstract class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
