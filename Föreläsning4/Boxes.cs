using System;

namespace Föreläsning4
    {
    public class IntBox
    {
        public int width;
        public int height;
        public int depth;

        public int GetInfo()
        {
            return width * height * depth;
        }
    }

    public class Box<T>
    {
        public T width;
        public T height;
        public T depth;
        public string GetInfo()
        {
            return string.Format("{0}, {1}, {2}", width, height, depth);
        }
    }
}
