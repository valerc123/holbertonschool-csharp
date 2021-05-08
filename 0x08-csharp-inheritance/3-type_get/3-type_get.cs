using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        // Printing the properties of the object
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }

        // Printing the methods of the object
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
