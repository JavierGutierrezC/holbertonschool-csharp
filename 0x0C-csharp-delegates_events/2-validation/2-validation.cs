using System;


/// <summary>Delegate takes float as param</summary>
public delegate void CalculateHealth(float dam);

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

    /// <summary>Take damage method. Affect hp</summary>
    public void TakeDamage(float damage)
    {
        float newHp = this.hp;
        Console.WriteLine(this.name + " takes " + damage + " damage!");
        //Console.WriteLine("newhp " + newHp);
        //Console.WriteLine("damage " + damage);
        if (damage < 0f)
            damage = 0f;     
        newHp = newHp - damage;
        //Console.WriteLine("newHpafterdmg " + newHp);
            ValidateHP(newHp);
    }

    /// <summary>Heal damage method. Affect hp</summary>
    public void HealDamage(float heal)
    {
        float newHp = this.hp;
        Console.WriteLine(this.name + " heals " + heal + " HP!"); 
        if (heal < 0f)
            heal = 0f;
        newHp = newHp + heal;
            ValidateHP(newHp);
    }  
    
    /// <summary>Delegate takes float as param</summary>
    public delegate void CalculateHealth(float dam);

    /// <summary>Sets new value of players hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        if (newHp > this.maxHp)
            this.hp = maxHp;
        else
            this.hp = newHp;
    }

}