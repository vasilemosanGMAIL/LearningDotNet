using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse
{
    public class Rectangle
    {
        const int NumberOfSides = 4;
        private int _height;
        //private field _width
        private int _width;
        //old C# width property assignmen
        //public int Width
        //{
        //    get { return _width; }
        //    set { _width = value; }
        //}

        public int Width { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = GetLenghtOrDefault(width, nameof(Width));
            _height = GetLenghtOrDefault(height, nameof(_height));
        }

        public int GetHeight() => _height;
        public void SetHeight(int value)
        {
            if (value > 0) _height = value;
        }

        private int GetLenghtOrDefault(int lenght, string name)
        {
            const int defaultValueIfNonPositive = 1;
            if (lenght <= 0) return defaultValueIfNonPositive;
            else return lenght;
        }
    }
}
