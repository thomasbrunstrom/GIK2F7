using System;

namespace Föreläsning4
{
    public class MyGenericArray<T> where T : IComparable
    {
        private T[] MyArray;
        public readonly int Count = 0;
        public MyGenericArray(int Size) 
        {
            Count = Size;
            MyArray = new T[Size + 1];
        }
        public T GetItem(int index) 
        {
            return MyArray[index];
        }
        public void SetItem(int index, T Value) 
        {
            if(index < Count && index > -1) {
                MyArray[index] = Value;
            }
        }
        public int GetBiggest(T a, T b)
        {
            return a.CompareTo(b);
        }
        public override string ToString()
        {
            string retString = "";
            for(int i = 0;i < MyArray.Length - 1;i++) 
            {
                if(GetItem(i) != null) {
                    retString += " " + GetItem(i).ToString();
                }
            }
            return retString;
        }
    }
}

