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
        Console.WriteLine("{0} has {1} / {2} health", name, maxHp, hp);
    }
}