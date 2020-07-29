using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");
        Player player4 = new Player("Water", -27f);

        player1.PrintHealth();
        player2.PrintHealth();
        player4.PrintHealth();
    }
}