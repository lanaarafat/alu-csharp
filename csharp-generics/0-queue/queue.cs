using System;
/// <summary>
/// method
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// method type
    /// </summary>
    /// <returns></returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}