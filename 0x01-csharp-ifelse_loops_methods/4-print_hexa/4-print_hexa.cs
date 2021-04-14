using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num <= 98){
                Console.Write("{0} = 0x{0:x} \n", num);
                num++;
            }
        }
    }
}
