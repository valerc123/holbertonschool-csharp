using System;

///<summary> Obj class </summary>
class Obj
{
    /// <summary>
    /// Checks if object is an instance of, or an instance of a class
    /// that inherited from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
