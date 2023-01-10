using System;
enum Countries : byte
{
    India = 1,
    Australia,
    US,
    UK,
    China,
    Japan,
    Canada,
    Brazil,
    Spain
}
public class MainClass
{
    enum Countries : byte
    {
        India = 1,
        Australia,
        US,
        UK,
        China,
        Japan,
        Canada,
        Brazil,
        Spain
    }
    public static void Main(string[] args)
    {
        string a;
        byte option;
        do
        {
            Console.WriteLine("which country would you like to know the language of?\n1.India\n2.Australia\n3.US\n4.UK\n5.China\n6.Japan\n7.Canada\n8.Brazil\n9.Spain\n");
            option = byte.Parse(Console.ReadLine());
            switch ((Countries)option)
            {
                case Countries.India:

                case Countries.Australia:

                case Countries.US:

                case Countries.UK:
                    Console.WriteLine("language spoken in {0} is English", (Countries)option);
                    break;
                case Countries.China:
                    Console.WriteLine("language spoken in {0} is Chinese", (Countries)option);
                    break;
                case Countries.Japan:
                    Console.WriteLine("language spoken in {0} is Japanese", (Countries)option);
                    break;
                case Countries.Canada:
                    Console.WriteLine("language spoken in {0} is English", (Countries)option);
                    break;
                case Countries.Brazil:
                    Console.WriteLine("language spoken in {0} is Brazillian", (Countries)option);
                    break;
                case Countries.Spain:
                    Console.WriteLine("language spoken in {0} is Spanish", (Countries)option);
                    break;
                default:
                    Console.WriteLine("please enter correct number");
                    break;
            }
            Console.WriteLine("continue?(y/n)");
            a = Console.ReadLine();

        } while (a != "n");
    }
}