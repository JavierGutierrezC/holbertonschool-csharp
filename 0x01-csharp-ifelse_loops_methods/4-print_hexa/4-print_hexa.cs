using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            for (y = 0; y < 99; y++)
            { 
            Console.WriteLine("{0:d} = 0x{0:x}",y);   
            }
        }
    }
}
