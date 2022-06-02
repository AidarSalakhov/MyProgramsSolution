using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U61_this
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Student(string firstName, string lastName, string middleName, DateTime birthday): this(lastName, birthday)
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }

        public Student(Student student)
        {
            lastName = student.lastName;
            firstName = student.firstName;
            middleName = student.middleName;
            birthday = student.birthday;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        private string middleName;
        private string firstName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}\nОтчество: {middleName}\nДата рождения: {birthday}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(firstName: "Ivan", lastName: "Ivanov", middleName: "Ivanovich", new DateTime(2000, 10, 5));

            //student.SetLastName("#######");

            student.Print();

            Student student2 = new Student(lastName: "Petrov", new DateTime(1999, 1, 20));

            //Student student2 = student;

            student2.Print();

            Student student3 = new Student(student);

            student3.SetLastName("----------------------");

            student3.Print();
        }
    }
}
