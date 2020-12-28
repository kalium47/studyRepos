using System;
using System.Collections.Generic;

namespace DynamicStudentManager
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentNameList = new List<string>();
            var studentGradeList = new List<int>();

            var addOne = true;

            while(addOne)
            {
                Console.WriteLine("Name?");
                studentNameList.Add(Console.ReadLine());

                Console.WriteLine("Grade?");
                studentGradeList.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add Another? Y/N");

                if (Console.ReadLine() == "y")
                    addOne = true;

                else
                    addOne = false;
            }

            for (int i = 0; i < studentNameList.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade {1}", studentNameList[i], studentGradeList[i]);
            }            
        }
    }
}
