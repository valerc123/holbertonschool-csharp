using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for(byte a = 97; a <= 122; a++)
            {
                if (a == 113  || a ==  101){
                    continue;
                }else{
                    Console.Write((char)a);
                }
            }
        }
    }
}
