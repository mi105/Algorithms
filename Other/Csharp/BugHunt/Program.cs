using System;
using System.Collections.Generic;

namespace BugHunt
{
    //for reference see here: https://careercup.com/forumpost?id=5704464011362304 
    class ItemsChecker{
      private List<string> _badItems;

         public ItemsChecker(List<String> badItems)
          {
           _badItems=badItems;
          }

         public List<String> GetGoodItems(List<String> items)
          {
           List<string> goodItems=new List<string>();
           foreach(string item in items)
           {
            if(!_badItems.Contains(item)) //here a bug - you can call Contains on null
           {
             goodItems.Add(item);
           }
           }

         return goodItems;

       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ItemsChecker ic = new ItemsChecker(null);// here is the bug - callin contains on null
            List<string> items = new List<string>(){"m", "t"};
            var x = ic.GetGoodItems(items);
            Console.WriteLine($"{x.ToString()}");
        }
    }
}
