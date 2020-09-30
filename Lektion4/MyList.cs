using System;
namespace Lektion4
{
    public class MyList<T>
    {
        private T[] Values;
        public int Count { 
            get {
                return Values.Length;
            }
        }
        public MyList()
        {
            Values = new T[0];
        }
        public MyList(T Value)
        {
            Values = new T[1];
            Values[0] = Value;
        }
        public void Add(T Value)
        {
            T[] tmpValues = new T[Values.Length + 1];
            for(int i = 0; i < Values.Length; i++) 
            {
                tmpValues[i] = Values[i];
            }
            tmpValues[tmpValues.Length - 1] = Value;
            Values = tmpValues;
        }
        public T GetAtIndex(int index)
        {
            try 
            {
                return Values[index];
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(T);
        }
        public void Remove(T Value)
        {
            bool found = false;
            var tmpValues = new MyList<T>();
            for(int i = 0; i < Values.Length; i++) 
            {
                if(found || !Values[i].Equals(Value))
                {
                    tmpValues.Add(Values[i]);
                }
                else {
                    found = true;
                }
            }
            Values = tmpValues.ToArray();
        }
        public void RemoveAt(int index)
        {
            bool IndexError = true;
            var tmpValues = new MyList<T>();
            for(int i = 0; i < Values.Length; i++) 
            {
                if(i == index) {
                    IndexError = false;
                }
                if(i != index)
                {
                    tmpValues.Add(Values[i]);
                }
            }
            Values = tmpValues.ToArray();
            if(IndexError) 
            {
                throw new IndexOutOfRangeException();
            }
        }
        public T[] ToArray()
        {
            return this.Values;
        }

        public void Clear()
        {
            Values = new T[0];
        }
    }
}