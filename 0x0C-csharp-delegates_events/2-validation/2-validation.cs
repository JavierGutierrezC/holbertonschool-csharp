using System;

/// <summary>Class Player</summary>
public class Player
{
    /// <summary>Class Constructor</summary>
    private string name;
    private float maxHp;
    private float hp;


    /// <summary>Constructor prototype, assign defaul parameters</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }

    /// <summary>Print Health Method</summary>
    public void PrintHealth()
    {
        //Console.WriteLine("rtyrrete");
        Console.WriteLine(this.name + " has " + this.hp + "/ " + this.maxHp + " health.");
    }
    /// <summary>Delegate takes float as param</summary>
    public delegate void CalculateHealth(float dam);

    /// <summary>Take damage method. Affect hp</summary>
    public void TakeDamage(float damage)
    {
        Console.WriteLine(this.name + " takes " + damage + " damage!");
        if (damage < 0f)
            damage = 0f;
            this.hp = this.hp - damage;
        //Console.WriteLine(this.name + " takes 0 damage!");

    }

    /// <summary>Heal damage method. Affect hp</summary>
    public void HealDamage(float heal)
    {
        Console.WriteLine(this.name + " heals " + heal + " HP!"); 
        if (heal < 0)
            heal = 0f;
            this.hp = this.hp + heal;
        //Console.WriteLine(this.name + " heals 0 damage!");
    }    

}