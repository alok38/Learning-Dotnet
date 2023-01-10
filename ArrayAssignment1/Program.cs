using System;

public class MainClass
{
    static void average(int[] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Average is: {0}", sum / arr.Length);
    }
    static void minMax(int[] arr)
    {
        int min = arr[0];
        int max = arr[arr.Length - 1];
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Max element is: {0}\nMin element is: {1}",max,min);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of Array: ");
        int size = int.Parse(Console.ReadLine());
        int[] intArray = new int[size];
        for(int i=0; i < size; i++)
        {
            Console.WriteLine("Enter {0} Element: ",i+1);
            intArray[i] = int.Parse(Console.ReadLine());    

        }
        average(intArray);
        minMax(intArray);

    }

}