using System;

namespace Föreläsning4
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyGenericArray<string> mgas = new MyGenericArray<string>(5);
            // mgas.SetItem(0, "Arthur");
            // mgas.SetItem(1, "Dent");
            // mgas.SetItem(2, "Ford");
            // mgas.SetItem(3, "Prefect");
            // Console.WriteLine(mgas);
            // MyGenericArray<int> mgai = new MyGenericArray<int>(5);
            // for(int i = 0; i < mgai.Count;i++) 
            // {
            //     mgai.SetItem(i, i * 5);
            // }
            // Console.WriteLine(mgai);

            // Circle a = new Circle();
            // GenericMethod gm = new GenericMethod();
            // var rectangle = gm.GetInstance<Rectangle>();
            // var shape = gm.GetInstance();
            // Console.WriteLine(shape.TypeName);
            // Console.WriteLine(rectangle.TypeName);


            // var circle = new Circle("Circle one");
            // var circle2 = new Circle("Circle two");
            // Console.WriteLine("{0} - {1}", circle.LastName, circle2.LastName);
            // gm.SwapInstance<Circle>(ref circle, ref circle2);
            // Console.WriteLine("{0} - {1}", circle.LastName, circle2.LastName);

            // var intBox = new IntBox();
            // intBox.depth = 50;
            // intBox.height = 20;
            // intBox.width = 10;
            // Console.WriteLine(intBox.GetInfo());

            // var floatBox = new Box<float>();
            // floatBox.depth = 2.5f;
            // floatBox.height = 5f;
            // floatBox.width = 10.5f;
            // Console.WriteLine(floatBox.GetInfo());

            // var stringBox = new Box<string>();
            // stringBox.depth = "djup";
            // stringBox.height = "höjd";
            // stringBox.width = "bredd";
            // Console.WriteLine(stringBox.GetInfo());

            new ExampleCollections();
        }
    }
}
