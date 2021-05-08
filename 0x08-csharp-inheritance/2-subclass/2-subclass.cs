using System;

///<summary> Obj class </summary>
class Obj
{
    /// <summary> 
    /// Returns True if the object is an instance of a class 
    /// that inherits from the specified class, otherwise return False.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}