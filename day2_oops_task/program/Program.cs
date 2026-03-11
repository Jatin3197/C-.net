using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        
        static void CheckNumber()
        {
            int n;
            Console.Write("Enter a number:");
            n=int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.Write("even number");
            }
            else 
            {
                Console.Write("odd number");
            }
        }
        static void Main(string[] args)
        {
          
          CheckNumber();
           
        }
    }
}
