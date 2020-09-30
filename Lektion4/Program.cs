using System;
using System.Collections.Generic;

namespace Lektion4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(4);
            myList.Add(4);
            myList.Add(4);
            myList.Add(4);
            myList.Remove(4);

            for(int i = 0;i < myList.Count; i++) 
            {
                Console.WriteLine(myList.GetAtIndex(i));
            }

            var myList2 = new MyList<string>();
            myList2.Add("Thomas");
            myList2.Add("Thomas");
            myList2.Add("Thomas");
            myList2.Add("Thomas");
            myList2.Add("Thomas");
            myList2.Add("Brunström");
            myList2.Remove("Thomas");
            myList2.Clear();
            for(int i = 0;i < myList2.Count; i++) 
            {
                Console.WriteLine(myList2.GetAtIndex(i));
            }

       }
    }
}
