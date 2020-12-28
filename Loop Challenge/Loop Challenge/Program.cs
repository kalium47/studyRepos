using System;

namespace Loop_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopTime = 1;

            while (loopTime <= 5)
            {

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i);
                }

                for (int i = 10; i > 1; i--)
                {
                    Console.WriteLine(i);
                }

                loopTime++;
            }


        }
    }
}
