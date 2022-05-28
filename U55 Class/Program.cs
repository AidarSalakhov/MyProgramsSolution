using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U55_Class
{
    class Student
    {
        public Guid id;
        public string name;
        public int age;
    }

    internal class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.id = Guid.NewGuid();
            student.name = "Vitaliy";
            student.age = 19;

            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine(student.id);
            Console.WriteLine(student.age);
            Console.WriteLine(student.name);
        }

        static void Main(string[] args)
        {
            var student = GetStudent();
            Print(student);
            
            
            
            //var person = new Person();

            //person.id = 1;
            //person.name = "ivan";
            //person.age = 37;
            //person.city = "Moscow";
            //person.color = Color.White;

            //person.Print();

            //var person2 = new Person();

            //person2.id = 2;
            //person2.name = "alexei";
            //person2.age = 39;
            //person2.city = "London";

            //person2.Print();


        }
    }
}
