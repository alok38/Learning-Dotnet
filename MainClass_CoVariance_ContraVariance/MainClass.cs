using CoVariance_ContraVariance_Generic_Delegate;
delegate Animal AnimalDelegate(Dog d);
public class MainClass1
{
    static Dog M(Animal a)
    {
        a.Speak();
        return (Dog)a;
    }
    public static void Main()
    {
        AnimalDelegate ad = M;
        Animal a = ad(new Dog());
        a.Speak();
    }
}