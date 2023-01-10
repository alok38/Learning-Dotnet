namespace PartialMethods
{
    partial class MyPartialClass
    {
        partial void M();// it should return void
        static partial void N();//Partial methods are implicitly private



    }
}