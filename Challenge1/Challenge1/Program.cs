using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();
            Console.WriteLine("Survey Result:");
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your month of birth is: {0}", month);

            if(month == "2")
            {
                Console.WriteLine("HaiYa");
            }
            else if (month == "2")
            {
                Console.WriteLine("Chou");
            }
        }
    }
}
