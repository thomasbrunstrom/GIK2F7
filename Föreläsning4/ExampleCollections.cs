using System;
using System.Collections.Generic;

namespace Föreläsning4
{
    public class ExampleCollections
    {
        public List<int> intList;
        public List<string> stringList;
        public enum Keys 
        {

        }

        public Dictionary<string, int> d1;
        public Dictionary<int, List<int>> d2;

        public ExampleCollections()
        {
            intList = new List<int>();
            intList.Add(10);
            Console.WriteLine(intList.Contains(10));
            intList.Remove(10);
            Console.WriteLine(intList.Contains(10));
            
            d1 = new Dictionary<string, int>();
            d1.Add("key1", 1);
            d1.Add("key2", 2);
            d1.Add("key3", 3);
            d1.Add("key4", 4);
            d1.Add("key5", 5);
            foreach(KeyValuePair<string, int> l in d1) 
            {
                Console.WriteLine("Key: {0}, Value: {1}", l.Key, l.Value);
            }

            List<int> l1 = new List<int> {1, 2, 3, 4, 5};
            d2 = new Dictionary<int, List<int>>();
            d2.Add(1, l1);
            d2.Add(2, new List<int> {6, 7, 8, 9, 10});
            foreach(KeyValuePair<int, List<int>> l in d2) 
            {
                int total = 0;
                foreach(int i in l.Value) {
                    total += i;
                }
                Console.WriteLine("Key: {0}, Value: {1}", l.Key, total);
            }

            Console.WriteLine("Innehåller nyckeln 1: {0}", d2.ContainsKey(1));
            Console.WriteLine("Innehåller nyckeln 5: {0}", d2.ContainsKey(5));
            Console.WriteLine("Innehåller värdet List<int>: {0}", d2.ContainsValue(l1));
            Console.WriteLine("Innehåller värdet List<int>: {0}", d2.ContainsValue(new List<int> {1, 2, 3, 4, 5}));
            
            SortedList<int, int> si = new SortedList<int, int>();
            si.Add(5, 5);
            si.Add(2, 2);
            si.Add(3, 3);
            si.Add(1, 1);
            si.Add(4, 4);
            foreach(KeyValuePair<int, int> a in si)
            {
                Console.WriteLine("Key: {0}, Value: {1}", a.Key, a.Value);
            }
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();

            Console.WriteLine("Kö exempel");
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(4);
            q.Enqueue(3);
            q.Enqueue(2);
            q.Enqueue(1);
            while(q.Count > 0) {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("Stack exempel");
            Stack<string> st = new Stack<string>();
            st.Push("dig");
            st.Push("på");
            st.Push("Hej");
            while(st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
