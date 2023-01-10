using System;

public class MainClass
{
    static void total(int[] arr)
    {
        int total=0;
        for(int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }
        Console.WriteLine("Total is {0}: ",total);
    }
    static void average(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Average is: {0}", sum / arr.Length);
    }
    static void minMax(int[] arr)
    {
        int min = arr[0];
        int max = arr[arr.Length - 1];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Max element is: {0}\nMin element is: {1}", max, min);
    }
    static void ascending(int[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("Ascending: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    static void descending(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.WriteLine("Descending: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void Main(string[] args)
    {
        int[] intArray = new int[10];
        for(int i=0; i < intArray.Length; i++)
        {
            Console.Write("Enter Marks{0}: ",i+1);
            intArray[i] = int.Parse(Console.ReadLine());    

        }
        total(intArray);
        average(intArray);
        minMax(intArray);
        ascending(intArray);
        descending(intArray);

    }

}