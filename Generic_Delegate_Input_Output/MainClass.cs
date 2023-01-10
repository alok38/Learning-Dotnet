using CoVariance_ContraVariance_Generic_Delegate;
delegate T AnimalDelegate<out T,in V>(V a);
public class MainClass1
{
    static Dog M(Animal a)
    {
        a.Speak();
        return (Dog)a;
    }
    public static void Main()
    {
        AnimalDelegate <Animal,Dog> ad = M;
        Animal a = ad(new Dog());
        a.Speak();
    }
}