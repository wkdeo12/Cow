using System;
using System.Collections.Generic;

[Serializable]
public class SaveData
{
    public int deathCount = 0;
    public int killZombieCount = 0;
    public List<int> superWeapon = new List<int>();
    public bool sound = true;
    public bool bgm = true;

    private int randomSeed;
    private int gold = 0;
    private int diamond = 0;

    public SaveData()
    {
        randomSeed = new Random().Next(1, 50000);
        gold = randomSeed;
        diamond = randomSeed;
    }

    public int Gold
    {
        get
        {
            return gold - randomSeed;
        }
        set
        {
            gold = value;
        }
    }

    public int Diamond
    {
        get
        {
            return diamond - randomSeed;
        }
        set
        {
            diamond = value;
        }
    }
}