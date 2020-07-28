using System;
using System.Collections.Generic;

/// <summary>Class Base</summary>
public abstract class Base 
{
    /// <summary>Public property</summary>
    public string name;
    
    /// <summary>Overides to string method</summary>
        public override string ToString()
        {
            return name + " is a " + GetType();
        }
    
}
/// <summary>Interface</summary>
public interface IInteractive
{
    /// <summary>method</summary>
    void Interact();
}
/// <summary>Interface</summary>
public interface IBreakable
{
    /// <summary>Properties</summary>
    int durability
    { get; set; }
    /// <summary>method</summary>
    void Break();
}
/// <summary>Interface</summary>
public interface ICollectable
{
    /// <summary>Properties</summary>
    bool isCollected
    { get; set; }
    /// <summary>method</summary>
    void Collect();
}
/// <summary>Class that that inherits from ...</summary>
public class Door : Base, IInteractive
{
    /// <summary>Constructor taht set the value of name</summary>
    public Door(string door = "Door")
    {
        name = door;
    }
    /// <summary>method from IInteractive</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + name +". It's locked.");
    }
}
/// <summary>Class that that inherits from ...</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>Properties</summary>
    public bool isQuestItem = false;
    /// <summary>Properties</summary>
    public int durability
    { get; set; }

    /// <summary>Constructor taht set the value of name</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>method from IInteractive</summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The " + name + " has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine("You look at the " + name + ". There's a key inside.");
        else
        {
            Console.WriteLine("You look at the " + name + ". Not much to see here.");
        }
    }
    /// <summary>method from IBreakable</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the " + name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the " + name + ". What a mess.");
        else if (durability < 0)
        {
            Console.WriteLine("The " + name + " is already broken.");
        }
    }
}

/// <summary>Class Key</summary>
public class Key : Base, ICollectable
{
    /// <summary>properties</summary>
    public bool isCollected
    { get; set; }

    /// <summary>Class constructor</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary>method</summary>
    public void Collect()
    {
        if (isCollected == false)
            Console.WriteLine("You pick up the " + name + ".");
        else if (isCollected == true)
        {
           Console.WriteLine("You have already picked up the " + name + "."); 
        }
        this.isCollected = true;

    }
}

/// <summary>Class RoomObjects</summary>
public class RoomObjects
{
    /// <summary>Method that accepts a list</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
		{
            if (type == typeof(IInteractive) && obj is IInteractive)
                ((IInteractive)obj).Interact();
               //Console.WriteLine("ii " + obj + " Type " + type);
            if (type == typeof(IBreakable) && obj is IBreakable)
                ((IBreakable)obj).Break();
                //Console.WriteLine("iB " + obj + " Type " + type);
            if (type == typeof(ICollectable) && obj is ICollectable)
                ((ICollectable)obj).Collect();
                //Console.WriteLine("iC " + obj + " Type " + type);
		}          
    }
}
