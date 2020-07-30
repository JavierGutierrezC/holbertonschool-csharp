using System;


/// <summary>Enum</summary>
public enum Modifier
{
    /// <summary>Waek attack</summary>
    Weak,
    /// <summary>Base attack</summary>
    Base,
    /// <summary>Stronh attack</summary>
    Strong
}

/// <summary>Class Player</summary>
public class Player
{
    /// <summary>Class Constructor</summary>
    private string name;
    private float maxHp;
    private float hp;
    /// <summary>Eventhandler</summary>
    EventHandler<CurrentHPArgs> HPCheck;
    private string status;

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
        }
        this.name = name;
        this.hp = maxHp;
        this.status = this.name + "is ready to go!";
        HPCheck = HPCheck + CheckStatus;
    }

    /// <summary>Print Health Method</summary>
    public void PrintHealth()
    {
        //Console.WriteLine("rtyrrete");
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    /// <summary>Take damage method. Affect hp</summary>
    public void TakeDamage(float damage)
    {
        float newHp = this.hp;
        if (damage < 0f)
            damage = 0f;
            //Console.WriteLine("damage " + damage);
        Console.WriteLine(this.name + " takes " + damage + " damage!");
        newHp = newHp - damage;
        ValidateHP(newHp);
    }

    /// <summary>Heal damage method. Affect hp</summary>
    public void HealDamage(float heal)
    {
        float newHp = this.hp;
        if (heal < 0)
            heal = 0f;
        Console.WriteLine(this.name + " heals " + heal + " HP!");
        newHp = newHp + heal;
        ValidateHP(newHp);
    }  

    /// <summary>Sets new value of players hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>Method that sets base value</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return (baseValue / 2f);
        }
        else if (modifier == Modifier.Base)
        {
            return (baseValue);
        }
        else
        {
            return (baseValue * 1.5f);
        }
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {

        if (e.currentHp == this.maxHp)
        {
            this.status = (this.name + " is in perfect health!");
        }
        else if (e.currentHp >= this.maxHp / 2f && e.currentHp < this.maxHp)
        {
            this.status = (this.name + " is doing well!");
        }
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp / 2f))
        {
			this.status = (this.name + " isn't doing too great...");
        }
		else if (e.currentHp > 0f && e.currentHp < (this.maxHp / 2f))
		{
            	this.status = (this.name + " needs help!");
        }
		else
        {
			this.status = (this.name + " is knocked out!");
        }
		Console.WriteLine(this.status);
    }
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }
}

/// <summary>Delegate takes float and the enum modifiers as param</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Class that inherits from EventArgs</summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>Class property</summary>
    public readonly float currentHp;

    /// <summary>Class constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }

}
