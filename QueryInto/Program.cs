using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    static void UsingInto()
    {
        string[] words = { "apples", "anjir", "avocado", "blueberries", "oranges", "bananas", "apricots" };
        var wordGroups1 = from w in words
                          group w by w[0] into fruitGroup
                          where fruitGroup.Count() >= 2
                          select new
                          {
                              FirstLetter = fruitGroup.Key,
                              count = fruitGroup.Count()
                          };
        foreach(var item in wordGroups1)
        {
            Console.WriteLine("{0} has {1} elements",item.FirstLetter,item.count);
        }
    }
    static void Main()
    {
        UsingInto();
    }
        
        }