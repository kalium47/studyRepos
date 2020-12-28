using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";
            while (passcode != "secret") //While Loop
            {

                Console.WriteLine("Please Enter the Passcode");
                passcode = Console.ReadLine();

               if (passcode != "secret")
                {
                    Console.WriteLine("Wrong Passcode");
                }

            }
            Console.WriteLine("Logged In"); //Reduce Code
        }
    }
}
