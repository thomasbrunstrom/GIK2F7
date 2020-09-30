using System;

namespace Lektion4
{
    public class MyVar<T> 
    {
        public T value { get; set; }
        public MyVar(T value) 
        {
            this.value = value;
        }
    }
    public class Box<T1, T2>
    {
        private MyVar<T1> value1;
        private MyVar<T2> value2;
        public Box()
        {

        }
        public Box(T1 t1, T2 t2)
        {
            value1 = new MyVar<T1>(t1);
            value2 = new MyVar<T2>(t2);
        }

        public MyVar<T1> GetValue1()
        {
            return value1;
        }
        public MyVar<T2> GetValue2()
        {
            return value2;
        }
        public DataHolder<T1, T2> GetValue()
        {
            return new DataHolder<T1, T2>(value1.value, value2.value);
        }
        public void GetValue(ref T1 val1, ref T2 val2)
        {
            val1 = value1.value;
            val2 = value2.value;
        }
    }
    public class DataHolder<B1, B2> 
    {
        public B1 a;
        public B2 b;
        public DataHolder(B1 a, B2 b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
