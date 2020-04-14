using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastd = number % 10;
        
        if (lastd > 5)
        {
        Console.WriteLine("The last digit of " + number + " is " + lastd + " and is greater than 5");
        }
        else if (lastd == 0)
        {
        Console.WriteLine("The last digit of " + number + " is " + lastd + " and is 0");
        }
        else
        {
        Console.WriteLine("The last digit of " + number + " is " + lastd + " and is less than 6 and not 0");
        }
    }
}
