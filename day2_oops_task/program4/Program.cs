using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class MO
    {
       internal int Area(int side)
        {
            int sqarea = side * side;
            return sqarea;
        }
        internal int Area(int len,int width)
        {
            int recarea = len * width;
            return recarea;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MO mo = new MO();
            Console.Write("Enter a side:");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of a square:"+ mo.Area(side));
            Console.Write("Enter a length:");
            int len = int.Parse(Console.ReadLine());
            Console.Write("Enter a width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of a rectangle:" + mo.Area(len,width));
        }
    }
}
