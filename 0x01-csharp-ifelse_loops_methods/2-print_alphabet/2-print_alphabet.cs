using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for(byte a = 97; a <= 122; a++)
            {
                Console.Write((char)a);
            }
        }
    }
}
