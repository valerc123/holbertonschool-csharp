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

/// <summary>Provides current HP arguments.</summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    /// <summary>The CurrentHPArgs constructor.</summary>
    public CurrentHPArgs(float newHP){
        this.currentHp = newHP;
    }
}

/// <summary>
/// Creates a public Player class
/// </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;


    event EventHandler<CurrentHPArgs> HPCheck; 

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
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
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
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
        ValidateHP(this.hp - damage);
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
        ValidateHP(this.hp + heal);
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
        OnCheckStatus(this, new CurrentHPArgs(this.hp));
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

    ///<summary>
    /// Checks the Player's status.
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e){
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }

    ///<summary>
    /// Provides low HP warnings.
    ///</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e){
        if(e.currentHp == 0){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else{
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    /// <summary>
    /// Checks current HP status.
    /// </summary>
    private void OnCheckStatus(object sender, CurrentHPArgs e){
        if(e.currentHp <= (maxHp/4))
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}
