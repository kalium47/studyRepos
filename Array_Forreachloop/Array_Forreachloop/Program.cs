using System;

namespace Array_Forreachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            nameFuction();

            writeItemOne();
            writeItemTwo();
        }
        static void nameFuction()
        {
            Console.WriteLine("Name?");
            var name = answerFuction();

            Console.WriteLine("Age?");
            var age = answerFuction(); 

            Console.WriteLine("You are {0} ", name);
            Console.WriteLine("You are {0} years old ", age);
        }
        static string answerFuction()//(string new var) //fuction that returns values //Refactoring ayy
        {
            var answer = Console.ReadLine();//so the input is first stored as var answer
            if (answer == "")//if it is match to empty
            {
                Console.WriteLine("Emtpy Name, Try again.");
                return Console.ReadLine();//it returns to readline 
            }
            return answer;//otherwise, it return as var answer and equals to the var in main function
        }

        static void writeItemOne() //fuction type void means no return
        {
            var arrayOne = new int[5];

            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;

            Console.WriteLine(arrayOne[1]);
        }
        static void writeItemTwo()
        {
            var arrayTwo = new int[] { 1, 2, 3, 4, 5 };

            foreach (var itemTwo in arrayTwo)
            {
                Console.WriteLine(itemTwo);
            }
        }


    }
}
