using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Person
    {
        string name;
        int age;
      internal void GetPersonDetail()
        {
            Console.Write("Enter Your Name:");
            name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            age = int.Parse(Console.ReadLine());

        }
        internal void ShowPersonDetail()
        {
            Console.WriteLine("Name:"+name);
            
            Console.WriteLine("Age:"+age);
            

        }

    }
    class Student:Person
    {
        string course;
        
        internal void GetStudentCourse()
        {
            GetPersonDetail();
            Console.Write("Enter Your Course:");
            course= Console.ReadLine();
            

        }
        internal void ShowStudentCourse()
        {
            ShowPersonDetail();
            Console.WriteLine("Course:" + course);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1= new Student();
            s1.GetStudentCourse();
            Console.Clear();
            s1.ShowStudentCourse();
        }
    }
}
