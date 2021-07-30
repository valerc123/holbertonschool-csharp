﻿using System;

/// <summary>
/// Creates a public Player class
/// </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player Constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f){
        this.name = name;
        if(maxHp <= 0f){
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    
    /// <summary>
    /// Display current health
    /// </summary>
    public void PrintHealth(){
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    private delegate void CalculateHealth(float amount);

    /// <summary>
    /// Applies damage to player.
    /// </summary>
    public void TakeDamage(float damage){
        if(damage <= 0){
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }else{
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
    }

    /// <summary>
    /// Rejuvinates player HP.
    /// </summary>
    public void HealDamage(float heal){
        if(heal <= 0){
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }else{
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }
}
