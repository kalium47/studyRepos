using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 1;

            while (count <=10)
            {
                Console.WriteLine(count);
                count++;
            }

            for (int i = 2; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
