using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Odd number from 1 to 50 is:"+i);
                }
            }
        }
    }
}
