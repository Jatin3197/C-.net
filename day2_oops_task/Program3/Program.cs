using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program3
{
    class Student 
    {
        int rollno; 
        string name;
        internal void getStuDetails()
        {
            Console.Write("Enter a Student roll no.:");
            rollno = int.Parse(Console.ReadLine());
            Console.Write("Enter a Student name:");
            name = Console.ReadLine();
            
        }

        internal void printStuDetails()
        {
            Console.WriteLine("Student rollno:" +rollno );

            Console.WriteLine("Student name:" + name);


        }

    }

    class Marks : Student
    {
        int marks;
        internal void getStuMarks()
        {
            getStuDetails();
            Console.Write("Enter a marks of a Student:");
            marks = int.Parse(Console.ReadLine());
        }

        internal void printStuMarks()
        {
            printStuDetails();
            Console.WriteLine("Student total marks:" + marks);

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
         Marks stu1 = new Marks();
         stu1.getStuMarks();
         stu1.printStuMarks();
         Marks stu2 = new Marks();
         stu2.getStuMarks();
         stu2.printStuMarks();

         
         
         
         
         
         

        }
    }
}
