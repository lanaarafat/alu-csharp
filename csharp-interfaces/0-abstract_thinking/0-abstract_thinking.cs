using System;
/// <summary>
/// abstract class
/// </summary>

public abstract class Base
{
    /// <summary>
    /// abstract class
    /// </summary>
    public string name;
    /// <summary>
    /// empty
    /// </summary>
    /// <returns></returns>
    public override string Tostring()
    {
        return($"{name} is a {this.GetType()}");
    }
}