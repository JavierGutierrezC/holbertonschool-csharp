using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
        string coma= "";
        int y;
        for (y = 0; y <= 99; y++)
            { 
            Console.Write("{0}{1:d2}",coma, y);
            coma = ", "; 
            }
        Console.Write("\n");
        }
    }
}
