using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenIvy.Shapes
{
    public class Rectangle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Enter Length");
            decimal Length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Breadth");
            decimal breadth = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Area is {Length * breadth}");
        }

        public void Perimeter()
        {
            Console.WriteLine("Enter Length");
            decimal Length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Breadth");
            decimal breadth = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter is {(Length + breadth)*2}");
        }
    }
}
