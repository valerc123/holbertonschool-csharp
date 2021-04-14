using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0){
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0){
                    if (i % 5 == 0){
                        Console.Write("FizzBuzz ");
                    }
                    Console.Write("Fizz ");
                }else{
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
