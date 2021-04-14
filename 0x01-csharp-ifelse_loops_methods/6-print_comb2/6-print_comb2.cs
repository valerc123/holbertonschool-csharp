using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if(i < j){
                        Console.Write("{0}{1}, ", i, j);
                    }
                }
            }
            Console.WriteLine("89");
        }
    }
}
