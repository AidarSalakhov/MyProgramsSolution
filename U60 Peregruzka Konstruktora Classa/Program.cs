using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U60_Peregruzka_Konstruktora_Classa
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(string firstName, string lastName,string middleName, DateTime birthday)
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _birthday = birthday;
        }

        public Student(Student student)
        {
            _lastName = student._lastName;
            _firstName = student._firstName;
            _middleName = student._middleName;
            _birthday = student._birthday;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private string _middleName;
        private string _firstName;
        private string _lastName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nОтчество: {_middleName}\nДата рождения: {_birthday}");
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
