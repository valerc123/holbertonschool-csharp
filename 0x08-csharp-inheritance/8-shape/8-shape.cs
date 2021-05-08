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


/// <summary>
/// Rectangle class derived from Shape class.
/// </summary>
class Rectangle : Shape {
    // width of rectangle
    private int width;
    // height of rectangle
    private int height;

    /// <summary>
    /// Gets or sets field Width. Throws an exception if Width is negative.
    /// </summary>
    public int Width {
        get => width;
        set {
            if(value < 0){
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets field height. Throws an exception if height is negative.
    /// </summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    
    /// <summary>
    /// Area overrides Shape's Area() method.
    /// </summary>
    public new int Area()
    {
        return (height * width);
    }

    /// <summary>
    /// ToString overrides the object default.
    /// </summary>
    public override string ToString()
    {
        return String.Format("[{0}] {1} / {2}", this.GetType().Name, this.width, this.height);
    }
}

/// <summary>
/// Square class derived from rectangle class.
/// </summary>
class Square : Rectangle {
    // size of square
    private int size;
    /// <summary>
    /// Gets or sets Size of Square. Throws an exception if value is negative.
    /// </summary>
    public int Size{
        get => size;
        set{
            if(value < 0){
                throw new ArgumentException("Size must be greater than or equal to 0");
            }else {
                size = value;
                Width = value;
                Height = value;
            }
        }
    }
}