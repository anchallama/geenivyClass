using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenIvy.Shapes
{
    public class Triangle : IShape
    {
        public void Area()
        {
            decimal Base = 0;
            decimal Height = 0;

            Console.WriteLine("Enter Base");
            Base = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height");
            Height = decimal.Parse(Console.ReadLine());

            decimal area =  (Base * Height)/2;
            Console.Write($"Area is {area}");
        }

        public void Perimeter()
        {
            decimal a = 0, b = 0, c = 0;
            Console.WriteLine("Enter first side");
            a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter second side");
            b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter thirsd side");
            c = decimal.Parse(Console.ReadLine());

            decimal perimeter = a + b + c;
            Console.WriteLine($"Perimeter is {perimeter}");

        }
    }
}
