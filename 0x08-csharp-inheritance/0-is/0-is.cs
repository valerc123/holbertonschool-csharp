using System;


/// <summary> Object Class </summary>
class Obj
{
    /// <summary> Check if object is an int </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int) {
            return true;
        }
        else {
            return false;
        }
    }
}
