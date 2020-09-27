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
            MyArray[index] = Value;
        }
        public override string ToString()
        {
            string retString = "";
            for(int i = 0;i<MyArray.Length - 1;i++) 
            {
                if(GetItem(i) != null) {
                    retString += " " + GetItem(i).ToString();
                }
            }
            return retString;
        }
    }
}

