using System;
using System.Reflection;

/// <summary>
/// This is our class Obj that contains methods to print properties and methods of any object.
/// </summary>
class Obj
{
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        PropertyInfo[] props = t.GetProperties();

        Console.WriteLine(t.Name + " Properties:");
        foreach (var element in props)
            Console.WriteLine(element.Name);
    }
        Type t = myObj.GetType();
        MethodInfo[] methods = t.GetMethods();
        Console.WriteLine(t.Name + " Methods:");
        foreach (var element in methods)
            Console.WriteLine(element.Name);
}