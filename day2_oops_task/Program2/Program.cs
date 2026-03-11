using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Rectangle
    {
        
        internal int Area(int length,int width)
        {
            int area = length * width;
            return area;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Length:");
            int len=int.Parse(Console.ReadLine());
            Console.Write("Enter a Width:");
            int width = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area of a Rectangle:"+ rectangle.Area(len,width));

        }
    }
}
