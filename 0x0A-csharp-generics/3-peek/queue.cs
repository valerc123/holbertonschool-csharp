using System;

/// <summary>
/// Generic class queue
/// </summary>
/// <typeparam name="T">The type the Queue contains</typeparam>
class Queue<T>
{
  /// <summary>
  /// The first node (head) in the Queue
  /// </summary>
  /// <value>gets/sets the head Node</value>
  public Node head { get; set; }

  /// <summary>
  /// The last node (tail) in the Queue
  /// </summary>
  /// <value>gets/sets the tail Node</value>
  public Node tail { get; set; }

  /// <summary>
  /// The number of nodes in the Queue
  /// </summary>
  /// <value>gets/sets the count int</value>
  public int count { get; set; }

  /// <summary>
  /// Gets the number of items in the Queue
  /// </summary>
  public int Count(){
    return count;
  }
  
  /// <summary>
  /// Adds a value to the end of the Queue
  /// </summary>
  /// <param name="value">The value to append, of type T</param>
  public void Enqueue(T value)
  {
    count++;

    if (head == null)
    {
      head = new Node(value);
      tail = head;
      return;
    }

    tail.next = new Node(value);
    tail = tail.next;
    return;
  }
  
  /// <summary>
  /// Remove the firts node of the Queue
  /// </summary>
  /// <returns>The first value of node removed</returns>
  public T Dequeue()
  {
    if (count == 0)
    {
      Console.WriteLine("Queue is empty");
      return default(T);
    }
    count--;
    T value = head.value;
    head = head.next;
    return (value);
  }

  /// <summary>
  /// Gets the first value in the Queue without removing it
  /// </summary>
  /// <returns>The first value</returns>
  public T Peek(){
    if(count == 0){
      Console.WriteLine("Queue is empty");
      return default(T);
    }
    T value = head.value;
    return (value);
  }

  /// <summary> 
  /// Checks if input is queue type 
  /// </summary>
  public Type CheckType(){
    return typeof(T);
  }

  /// <summary>
  /// Create a node to store data for the Queue
  /// </summary>
  public class Node
  {
    /// <summary>
    /// The value that the node contains
    /// </summary>
    /// <value>The value property gets/sets the value property of type T</value>
    public T value { get; set; }

    /// <summary>
    /// The next node in the linked list
    /// </summary>
    /// <value>The next property gets/sets the next property of type Node</value>
    public Node next { get; set; }

    public Node(T value)
    {
      this.value = value;
      this.next = null;
    }
  }
}
