using System;

/// <summary>
/// Generic class queue
/// </summary>
public class Queue<T>
{
  /// <summary> Checks if input is queue type <summary>
  public Type CheckType(){
    return typeof(T);
  }
}
