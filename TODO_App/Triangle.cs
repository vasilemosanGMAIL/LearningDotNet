using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_App
{
    public class Triangle
    {
        private int Base;
        private int Height;

        public Triangle(int @base, int height)
        {
            Base = @base;
            Height = height;
        }

        public int CalculateArea()
        {
            return ((Base * Height) / 2);
         }

        public void AsString()
        {
            Console.WriteLine($"Base is {Base}, height is {Height}");
        }
    }
}
