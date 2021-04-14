using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num <= 98){
                Console.Write("{0:00}, ", num);
                num++;
            }
            Console.Write("99\n");
        }
    }
}
