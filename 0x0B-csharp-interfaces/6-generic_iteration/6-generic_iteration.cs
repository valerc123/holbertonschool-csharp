using System;
using System.Collections;
using System.Collections.Generic;

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
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Represents a Decoration.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; } = 1;
    public bool isQuestItem { get; set; }  

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
       if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
            return;
        }

        if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
            return;
        }

        Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary>
    /// Attempts to break the Decoration.
    /// </summary>
    public void Break() {
       durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// Collectible key
/// </summary>
class Key : Base, ICollectable
{
    public bool isCollected {get; set;}

    /// <summary>The Key constructor.</summary>
    /// <param name="name">The name of the Key.</param>
    /// <param name="isCollected">Whether the Key has been collected.</param>
    public Key(string name = "Key", bool isCollected = false){
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>Collects the Key.</summary>
    public void Collect(){
        if (!isCollected){
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}


/// <summary>
/// 
/// </summary>
class Objs<T> : IEnumerable<T>
{
    List<T> collection = new List<T>();

    public void Add(T item)
    {
        collection.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return collection.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}