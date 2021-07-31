using System;

/// <summary>
/// Provides an abstract base class.
/// </summary>
abstract class Base
{
    public string name = "";

    /// <summary>
    /// Gets the string representation of the instance.
    /// </summary>
    /// <returns>The string representation.</returns>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, GetType());
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set;}
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set;}
    void Collect();
}

/// <summary>
/// Provides a class that inherits from IInteractive, IBreakable, and ICollectable.
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact() { }

	public void Break() { }

	public void Collect() { }
}