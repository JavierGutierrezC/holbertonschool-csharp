﻿using System;

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
        this.name = name;
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;      
        }
        this.hp = maxHp;
        
    }

    /// <summary>Print Health Method</summary>
    public void PrintHealth()
    {
        //Console.WriteLine("rtyrrete");
       //Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
       Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}