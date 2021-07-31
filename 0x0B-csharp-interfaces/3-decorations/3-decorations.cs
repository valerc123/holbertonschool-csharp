using System;

/// <summary>
/// Provides an abstract base class.
/// </summary>
abstract class Base
{
    public string name { get; set; }

    /// <summary>
    /// Gets the string representation of the instance.
    /// </summary>
    /// <returns>The string representation.</returns>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, GetType());
    }
}

/// <summary>
/// Defines the properties of an interactive object
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Defines the properties of a breakable object
/// </summary>
interface IBreakable
{
    int durability { get; set;}
    void Break();
}

/// <summary>
/// Defines the properties of a collectable object
/// </summary>
interface ICollectable
{
    bool isCollected { get; set;}
    void Collect();
}

/// <summary>
/// Represents a Door.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Sets the name of the Door.
    /// </summary>
    public Door(string door = "Door"){
        this.name = door;
    }

    /// <summary>
    /// Prints interaction string.
    /// </summary>
    public void Interact() {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// Represents a Decoration.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; } = 1;
    public bool isQuestItem = false;

    /// <summary>
    /// The decoration constructor.
    /// </summary>
    /// <param name="name">The nameof the Decoration.</param>
    /// <param name="durability">The durability of the Decoration.</param>
    /// <param name="isQuestItem">Whether the Decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false){
        
        if (this.durability <= 0){
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the Decoration.
    /// </summary>
    public void Interact(){
        if(this.durability <= 0){
            Console.WriteLine("The {0} has been broken.",  this.name);
        }
        else if(this.isQuestItem){
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        }else{
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
        }
    }

    /// <summary>
    /// Attempts to break the Decoration.
    /// </summary>
    public void Break() {
        if (this.durability < 0){
            Console.WriteLine("The {0} is already broken.", this.name);
        }
        this.durability--;
        if (this.durability == 0){
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        }else{
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        }
    }
}