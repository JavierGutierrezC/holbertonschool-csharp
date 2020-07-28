using System;

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
public interface ICollectible
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