using System;

/// <summary>
/// A delegate used to calculate health.
/// </summary>
delegate void CalculateHealth(float amount);

/// <summary>
/// A delegate used to calculate modifiers.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// An enumeration of modifiers for enemy attacks.
/// </summary>
public enum Modifier
{
   /// <summary>The weak modifier.</summary>
    Weak,
    /// <summary>The base modifier.</summary>
    Base,
    /// <summary>The strong modifier.</summary>
    Strong
}

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

    /// <summary>
    /// Applies damage to player.
    /// </summary>
    public void TakeDamage(float damage){
        if(damage <= 0){
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }else{
            ValidateHP(this.hp - damage);
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
            ValidateHP(this.hp + heal);
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }

    /// <summary>
    /// Validates player's new HP.
    /// </summary>
    public void ValidateHP(float newHp) {
        if (newHp <=0) {
            this.hp = 0;
        }
        else if (newHp > maxHp) {
            this.hp = maxHp;
        }
        else {
            this.hp = newHp;
        }
    }

    /// <summary>
    /// Apply modifier to incoming damage.
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier){
        if (modifier == Modifier.Weak){
            return baseValue / 2;
        }
        else if(modifier == Modifier.Base)
        {
            return baseValue;
        }
        else{
            return baseValue * 1.5f;
        }
    }
}
