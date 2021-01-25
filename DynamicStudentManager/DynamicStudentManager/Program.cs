using System;
using System.Collections.Generic;

namespace DynamicStudentManager
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<StudentInfo>();

            var addOne = true;

            while(addOne)
            {
                var newStudentInfo = new StudentInfo();

                Console.WriteLine("Name?");
               newStudentInfo.Name = (Console.ReadLine());

                Console.WriteLine("Grade?");
                newStudentInfo.Grade = (int.Parse(Console.ReadLine()));

                Console.WriteLine("Birthday?");
                newStudentInfo.Birthday = (Console.ReadLine());

                Console.WriteLine("Address?");
                newStudentInfo.Address = (Console.ReadLine());

                Console.WriteLine("PhoneNumber?");
                newStudentInfo.PhoneNumber = (int.Parse(Console.ReadLine()));

                students.Add(newStudentInfo);

                Console.WriteLine("Add Another? Y/N");

                if (Console.ReadLine() == "y")
                    addOne = true;

                else
                    addOne = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade {1}, Birthday {2}, Address {3}, PhoneNumber {4}. ", student.Name, student.Grade, student.Birthday, student.Address, student.PhoneNumber);
            }

        }
    }

    class StudentInfo
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int PhoneNumber;

    }
}
