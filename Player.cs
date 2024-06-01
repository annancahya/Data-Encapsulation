using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health;
    int power;
    string name;

    public Player(int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
    }

    public void Attack()
    {
        Debug.Log(name + " sedang menyerang");
    }

    public void Info()
    {
        Debug.Log("Health is: " + health);
        Debug.Log("Power is: " + power);
        Debug.Log("Name is: " + name);
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }


}
