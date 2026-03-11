using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Student 
    {
        int stu_id;
        string stu_name,stu_course;
        internal void getStuDetails()
        {
            Console.Write("Enter a Student id:");
            stu_id=int.Parse(Console.ReadLine());
            Console.Write("Enter a Student name:");
            stu_name = Console.ReadLine();
            Console.Write("Enter a Student course:");
            stu_course = Console.ReadLine();
        }

        internal void printStuDetails()
        {
            Console.WriteLine("Student id:"+stu_id);
            
            Console.WriteLine("Student name:"+stu_name);
            
            Console.WriteLine("Student course:"+stu_course);
            
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
          Student s1= new Student();
          s1.getStuDetails();
          Console.Clear();
          s1.printStuDetails();

        }
    }
}
