using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNameArray = new string[studentCount];
            var studentGradeArray = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name?");
                studentNameArray[i] = Console.ReadLine();

                Console.WriteLine("Grade?");
                studentGradeArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade {1}", studentNameArray[i], studentGradeArray[i]);
            }

        }


    }
}
