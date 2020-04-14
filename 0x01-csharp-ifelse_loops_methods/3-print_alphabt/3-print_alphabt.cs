using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char alpha;
            for (alpha = 'a'; alpha <= 'z'; alpha++)
            {
                if(alpha == 'e' || alpha == 'q')
                {
                continue;
                }
            Console.Write(alpha);
                
            }
        }
    }
}