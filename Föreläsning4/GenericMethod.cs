using System;
using System.Collections.Generic;

namespace Föreläsning4
{
    public class GenericClass<T>
    {
        public T1 GenericMethod<T1>(T1 parm1)
        {
            return parm1;
        }
    }
    public class GenericClass2<T1, T2>
    {
        public T1 MyProperty { get; set; }
        public T2 MyProperty2 { get; set; }
        public T3 GetAType<T3>() where T3 : new()
        {
            return new T3();
        }
    }
    public interface IGenericInterface<T>
    {

    }

    public class GenericMethod
    {
        public GenericMethod()
        {
        }
        public T GetInstance<T>() where T : new()
        {
            T retObj = new T();
            return retObj;
        }

        public void SwapInstance<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public Shape GetInstance()
        {
            return GetInstance<Shape>();
        }
    }

    public class Shape 
    {
        public string TypeName = "Shape";
        public string LastName;
        public Shape()
        {

        }
        public Shape(string LastName) 
        {
            this.LastName = LastName;
        }
    }
    public class Rectangle : Shape 
    {
        public Rectangle()
        {
            TypeName = "Rectangle";
        }
        public Rectangle(string LastName) : base(LastName)
        {

        }
    }
    public class Circle : Shape
    {
        public Circle()
        {
            TypeName = "Circle";
        }
        public Circle(string LastName) : base(LastName)
        {
            
        }
    }

}
