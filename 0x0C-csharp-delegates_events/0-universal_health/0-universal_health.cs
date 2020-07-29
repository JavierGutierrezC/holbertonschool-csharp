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
            this.maxHp = maxHp;
            //Console.WriteLine("else maxhp " + this.maxHp);
        }     
        this.name = name;
        this.hp = this.maxHp; 
        // Console.WriteLine("out maxhp " + this.maxHp);
        // Console.WriteLine("out hp " + this.hp);
        
    }

    /// <summary>Print Health Method</summary>
    public void PrintHealth()
    {
        //Console.WriteLine("rtyrrete");
       Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }
}
