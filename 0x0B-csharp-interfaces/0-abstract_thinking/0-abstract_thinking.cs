using System;

/// <summary>
/// Provides an abstract base class.
/// </summary>
abstract class Base
{
    public string name;

    /// <summary>
    /// Gets the string representation of the instance.
    /// </summary>
    /// <returns>The string representation.</returns>
    public override string ToString(){
        return String.Format("{0} is a {1}", name, GetType());
    }
}
