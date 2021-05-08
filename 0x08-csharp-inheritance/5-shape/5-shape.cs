using System;

/// <summary>
/// Shape class. Shapely stuff.
/// </summary>
class Shape
{
    /// <summary>
    /// throws a NotImplementedException with message.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
