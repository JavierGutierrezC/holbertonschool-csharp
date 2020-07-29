using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        player.TakeDamage(25f);

        player.HealDamage(10f);
    }
}