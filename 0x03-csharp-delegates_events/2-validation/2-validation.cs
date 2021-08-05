using System;

/// <summary> player character data tracker </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// each player gets one of these
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
            this.hp = 100f;
        }
    }

    /// how much health does the player have?
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// changes in health from various sources
    public delegate void CalculateHealth(float healthPoints);

    /// damage reduces hit points
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(hp - damage);
    }

    /// healing increases hit points
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);
    }

    /// check to make sure you're still alive
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }
}
