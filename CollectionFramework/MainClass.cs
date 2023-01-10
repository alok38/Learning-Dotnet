// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

public class MainClass
{
    static void ArrayListImplementation()
    {
        ArrayList Al = new ArrayList(5);
        Al.Add(10);
        Al.Add(new MainClass());
        Al.Add("alok");
        Al.Add(10.45);
        Al.Add("ok");
        Al.Add(245);
        Al.Add("225");
        Al.Remove("225");
        Al.RemoveAt(0);
        foreach(object o in Al)
        {
            Console.WriteLine(o);
        }

        Console.WriteLine(Al.Capacity);
        Console.WriteLine(Al.Count);
    }
    static void genericListImplementation()
    {
        List<int> intList = new List<int>();
        intList.Add(10);
        intList.Add(200);
        intList.Add(206);
        intList.Add(233);
        intList.Add(2070);
        intList.Remove(207);
        intList.RemoveAt(0);
        foreach(int i in intList)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(intList.Capacity);
        Console.WriteLine(intList.Count);
    }
    static void sortedListImplementation()
    {
        SortedList sl = new SortedList();
        sl.Add("A1", "alok");
        sl.Add("A6", "blok");
        sl.Add("A3", "clok");
        sl.Add("A2", "dlok");
        sl.Add("A5", "elok");
        sl.Add("A4", "flok");
        ICollection c = sl.Values;
        foreach(object o in sl.Values)
        {
            Console.WriteLine(o);
        }
        foreach(string S in c)
        {
            Console.WriteLine(S);
        }
        foreach(object o in sl.Keys)
        {
            Console.WriteLine(sl[o]);
        }
        Console.WriteLine(sl.GetByIndex(1));
    }
    static void hashTableImplementation()
    {
        Hashtable h = new Hashtable();
        h.Add(1, "ALOK");
        h.Add(4, "blok");
        h.Add(3, "clok");
        h.Add(2, "oklok");
        h.Add(5, "sLOK");
        foreach(int i in h.Keys)
        {
            Console.WriteLine(h[i]);
        }
        foreach(object o in h.Values)
        {
            Console.WriteLine(o);
        }
    }
    static void hashSetImplementation()
    {
        string[] str1 = { "alok", "blok", "clok", "dlok", "alok", "blok" };
        HashSet<string> h = new HashSet<string>(str1);
        foreach(string s in h)
        {
            Console.WriteLine(s);
        }
    }
    static void stackImplementation()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);  
        stack.Push(3);  
        stack.Push(4);  
        stack.Push(5);
        stack.Push(6);
        stack.Pop();
        stack.Pop();
        Console.WriteLine(stack.Count);
        foreach(int i in stack)
        {
            Console.WriteLine(i);
        }
    }
    static void queueImplementation()
    {
        Queue<int> queue = new Queue<int>(); 
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);   
        queue.Enqueue(5);   
        queue.Enqueue(6);   
        queue.Enqueue(7);   
        queue.Enqueue(8);   
        queue.Dequeue(); 
        queue.Dequeue();
        Console.WriteLine(queue.Count);
        foreach(int i in queue)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main(string[] args)
    {
        //ArrayListImplementation();
        //genericListImplementation();
        // sortedListImplementation(); 
        //hashTableImplementation();
        //hashSetImplementation(); 
       // stackImplementation();
       queueImplementation();
    }
}

