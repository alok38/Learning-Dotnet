namespace Interface_Implementation_Example
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            class1 c1 = new class1();
            Interface1 i1 = c1;
            Interface2 i2 = c1;

            i1.M();
            i2.M();
            //c1.M(); not accesible
            i2.N();
            c1.N();
        }
    }
}