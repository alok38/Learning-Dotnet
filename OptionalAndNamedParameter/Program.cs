using System.Collections;
namespace OptionalAndNamedParameter
{
    class MainClass
    {
        public static void M(string name, bool b = false, ArrayList mylist = null)
        {
            Console.WriteLine(name);
            Console.WriteLine(b);
        }
        static void Main()
        {
            M("Alok");
            M("Blok", true);
            M("Clok", true, new ArrayList());
            //M("Alok",new ArrayList()); // Invalid



            M(name:"Dlok", mylist: new ArrayList());
            M(name:"Elok", mylist: new ArrayList(), b: true);//valid but silly



        }
    }
}