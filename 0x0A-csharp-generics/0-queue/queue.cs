using System;

/// <summary>
/// Generic class queue
/// </summary>
/// <typeparam name="T">The type the Queue contains</typeparam>
class Queue<T>
{
  /// <summary> 
  /// Checks if input is queue type 
  /// </summary>
  public Type CheckType(){
    return typeof(T);
  }
}
